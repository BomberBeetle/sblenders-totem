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
using MaterialSkin;

namespace TelaSblenders
{
    public partial class Produtos : MaterialForm
    {
        public Produtos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange200, TextShade.WHITE);
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialListView1_Click(object sender, EventArgs e)
        {
            (new Ingredientes()).ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            (new Carrinho()).ShowDialog();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
