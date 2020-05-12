using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace TelaSblenders
{
    public partial class Sblendersses : MaterialSkin.Controls.MaterialForm
    {
        public Sblendersses()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange200, TextShade.WHITE);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            (new Produtos()).ShowDialog();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            (new Ingredientes()).ShowDialog();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            (new Login()).ShowDialog();
        }
    }
}
