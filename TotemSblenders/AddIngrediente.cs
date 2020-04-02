using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TelaSblenders
{
    public partial class AddIngrediente : MaterialForm
    {
        public AddIngrediente()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
