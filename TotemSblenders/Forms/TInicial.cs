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
using SblendersAPI.Models;

namespace TelaSblenders
{
    public partial class TInicial : MaterialForm
    {
        public TInicial()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Program.Carrinho = new Pedido(Program.userRID, Program.userID, 0, DateTime.Now, "", new PedidoProduto[0]);
            (new Produtos()).ShowDialog();
        }
    }
}
