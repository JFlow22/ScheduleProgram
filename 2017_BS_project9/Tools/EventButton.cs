using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class EventButton : MetroTile
    {
        public Event PraentEvent { set; get; }

        public EventButton(Event parent): base()
        {
            this.BackColor = System.Drawing.Color.White;
            this.PraentEvent = parent;
        }
    }
}
