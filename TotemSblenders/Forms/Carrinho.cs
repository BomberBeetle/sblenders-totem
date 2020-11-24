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
            listView1.Items.Clear();
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
            Tag = 0;
            listView1.SelectedIndexChanged += new EventHandler((object o, EventArgs e) => { 
                if(listView1.SelectedIndices.Count == 0)
                {
                    return;
                }
                DeletThis delet = new DeletThis();
                delet.materialLabel1.Text = "Remover " + listView1.SelectedItems[0].SubItems[0].Text + "?";
                delet.ShowDialog();
                if (delet.result)
                {
                    var extract = new List<PedidoProduto>(Program.Carrinho.produtos);
                    extract.RemoveAt(listView1.SelectedIndices[0]);
                    Program.Carrinho.produtos = extract.ToArray();
                    ComputePrices();
                }
            });
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            (new TelaPgto()).ShowDialog();
            Tag = 1;
            Close(); 
        }
    }
}
