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
        public int Quantidade;
        private int buffer;
        public AddIngrediente(int quantidade)
        {
            InitializeComponent();
            materialLabel1.Text = quantidade.ToString();
            buffer = quantidade;
            Quantidade = quantidade;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Quantidade = buffer;
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if(buffer > 0)
            {
                buffer--;
                materialLabel1.Text = buffer.ToString();
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            buffer++;
            materialLabel1.Text = buffer.ToString();
        }
    }
}
