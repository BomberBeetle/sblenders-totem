using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaSblenders
{
    public partial class CardProduto : UserControl
    {
        private EventHandler _clickedEvent;

        public void SetOnClick(EventHandler e)
        {
            if(_clickedEvent != null)
            {
                this.Click -= _clickedEvent;
                foreach(Control c in Controls)
                {
                    c.Click -= _clickedEvent;
                }
            }
            _clickedEvent = e;
            Click += _clickedEvent;
            foreach (Control c in Controls)
            {
                c.Click += _clickedEvent;
            }
           
        }

        public CardProduto()
        {
            InitializeComponent();
        }
    }
}
