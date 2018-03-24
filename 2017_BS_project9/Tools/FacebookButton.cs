using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
    using System.Dynamic;


namespace _2017_BS_project9
{
    public class FacebookButton:Button
    {
        public partial class FB_LoginDialog : Form
        {
            private readonly Uri _loginUrl;
            protected readonly FacebookClient _fb;

            public FacebookOAuthResult FacebookOAuthResult { get; private set; }

            public FB_LoginDialog(string appId, string extendedPermissions)
                : this(new FacebookClient(), appId, extendedPermissions)
            {
            }

            public FB_LoginDialog(FacebookClient fb, string appId, string extendedPermissions)
            {
                if (fb == null)
                    throw new ArgumentNullException("fb");
                if (string.IsNullOrWhiteSpace(appId))
                    throw new ArgumentNullException("appId");

                _fb = fb;
                _loginUrl = GenerateLoginUrl(appId, extendedPermissions);

                InitializeComponent();
            }

            private Uri GenerateLoginUrl(string appId, string extendedPermissions)
            {
                dynamic parameters = new ExpandoObject();
                parameters.client_id = appId;
                parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";

                // The requested response: an access token (token), an authorization code (code), or both (code token).
                parameters.response_type = "token";

                // list of additional display modes can be found at http://developers.facebook.com/docs/reference/dialogs/#display
                parameters.display = "popup";

                // add the 'scope' parameter only if we have extendedPermissions.
                if (!string.IsNullOrWhiteSpace(extendedPermissions))
                    parameters.scope = extendedPermissions;

                // when the Form is loaded navigate to the login url.
                return _fb.GetLoginUrl(parameters);
            }

            private void FacebookLoginDialog_Load(object sender, EventArgs e)
            {
                // make sure to use AbsoluteUri.

                webBrowser.Navigate(_loginUrl.AbsoluteUri);
            }

            private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
            {
                // whenever the browser navigates to a new url, try parsing the url.
                // the url may be the result of OAuth 2.0 authentication.

                FacebookOAuthResult oauthResult;
                if (_fb.TryParseOAuthCallbackUrl(e.Url, out oauthResult))
                {
                    // The url is the result of OAuth 2.0 authentication
                    FacebookOAuthResult = oauthResult;
                    DialogResult = FacebookOAuthResult.IsSuccess ? DialogResult.OK : DialogResult.No;
                }
                else
                {
                    // The url is NOT the result of OAuth 2.0 authentication.
                    FacebookOAuthResult = null;
                }
            }

            private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {

            }


            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.webBrowser = new System.Windows.Forms.WebBrowser();
                this.SuspendLayout();
                // 
                // webBrowser
                // 
                this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
                this.webBrowser.Location = new System.Drawing.Point(0, 0);
                this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
                this.webBrowser.Name = "webBrowser";
                this.webBrowser.ScrollBarsEnabled = false;
                this.webBrowser.Size = new System.Drawing.Size(661, 314);
                this.webBrowser.TabIndex = 0;
                this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
                this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
                // 
                // FB_LoginDialog
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(661, 314);
                this.Controls.Add(this.webBrowser);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "FB_LoginDialog";
                this.ShowInTaskbar = false;
                this.Text = "Login to Facebook ...";
                this.Load += new System.EventHandler(this.FacebookLoginDialog_Load);
                this.ResumeLayout(false);

            }

            #endregion

            public System.Windows.Forms.WebBrowser webBrowser;
        }



        private const string AppId = "1239132142925481";
        private const string ExtendedPermissions = "email";
        private string _accessToken;
        Dictionary<string, string> loginData;
        FacebookClient fb = null;



        public FacebookButton()
        {
            this.Click += new EventHandler(clickEvent);
        }

        private void clickEvent(object sender, EventArgs e)
        {
            //DO NOT DELETE needs to activate twice
            loginData = new Dictionary<string, string>();
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            logout();



            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);


        }


        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    dynamic result = fb.Get("me?fields=id,name,email");

                    Dictionary<string, string> data = new Dictionary<string, string>();

                    data.Add("name", (string)result.name);
                    data.Add("id", (string)result.id);
                    data.Add("email", (string)result.last_name);
                    loginData = data;
                    getLoginData();
                    logout();
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        public void logout(object sender = null, EventArgs e = null)
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);

        }


        public Dictionary<string, string> getLoginData()
        {
            return loginData;
        }

    }
}
