using System;
using System.Data;
using System.Data.SqlClient;

namespace _2017_BS_project9
{
    public class User
    {
        // accs
        public string   ID    { set; get; }
        public string   Name  { set; get; }
        public string   Pwd   { set; get; }
        public string   FB_ID { set; get; }
        /// <summary>
        /// set type
        /// Student
        /// Secretary
        /// Lecturer
        /// Practitioner
        /// Head Of Department
        /// House Keeper
        /// </summary>
        /// <param name="type">user type</param>
        /// <returns>true if valid</returns>
        public string Type { set; get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="name">user name</param>
        /// <param name="pwd">user password</param>
        /// <param name="type">user type - 1,2,3</param>
        public User(string id, string name, string pwd, string type)
        {
            ID = id;
            Name = name;
            Pwd = pwd;
            Type = type;
        }


        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="name">user name</param>
        /// <param name="pwd">user password</param>
        /// <param name="type">user type - 1,2,3</param>
        public User(object id, object name, object pwd, object type)
        {
            ID = id.ToString();
            Name = name.ToString();
            Pwd = pwd.ToString();
            Type = type.ToString();
        }


        /// <summary>
        /// empty user
        /// </summary>
        public User(){}
        
        /// <summary>
        /// Copy Ctor for User -> User
        /// </summary>
        /// <param name="u">User to clone</param>
        public User(User u)
        {
            this.ID     = u.ID;
            this.Name   = u.Name;
            this.Pwd    = u.Pwd;
            this.Type  = u.Type;
        }

        /// <summary>
        /// toString override
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Name + " : " + ID + " : " + Type;
        }
    }
}
