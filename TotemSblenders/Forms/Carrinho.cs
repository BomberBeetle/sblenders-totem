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
    public partial class Carrinho : MaterialForm
    {
        void ComputePrices()
        {
            decimal total = 0;
            foreach (PedidoProduto pedidoProduto in Program.Carrinho.produtos)
            {
                ProdutoParcial produto = Array.Find(Produtos.produtos, a => a.ID == pedidoProduto.produtoID);
                string[] rowString = {produto.Name, "R$" + pedidoProduto.computatedPrice, pedidoProduto.pedidoProdutoQtde.ToString() };
                ListViewItem row = new ListViewItem(rowString);
                listView1.Items.Add(row);
                total += pedidoProduto.computatedPrice;
            }
            materialLabel1.Text = "Subtotal: R$ " + total;
            materialLabel2.Text = $"Quantidade de Produtos: {Program.Carrinho.produtos.Length}";
        }
        public Carrinho()
        {
            InitializeComponent();
            ComputePrices();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            (new TelaFinal()).ShowDialog();
        }
    }
}
