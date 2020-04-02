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
    public partial class Ingredientes : MaterialForm
    {
        public Ingredientes()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialListView1_Click(object sender, EventArgs e)
        {
            (new AddIngrediente()).ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
