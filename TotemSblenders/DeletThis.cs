using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaSblenders
{
    public partial class DeletThis : MaterialForm
    {
        public bool result = false;
        
        public DeletThis()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            result = true;
            Close();
        }
    }
}
