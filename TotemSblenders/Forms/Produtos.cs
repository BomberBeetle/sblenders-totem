﻿using System;
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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using SblendersAPI.Models;

namespace TelaSblenders
{
    public partial class Produtos : MaterialForm
    {
        int pagina = 1;
        int paginas = 0;
        public  static ProdutoParcial[] produtos;

        void ComputeTotal()
        {
            decimal total = 0;
            foreach(PedidoProduto pedidoProduto in Program.Carrinho.produtos)
            {
                total += pedidoProduto.computatedPrice;
            }
            materialLabel1.Text = "Total: R$ " + total;
            materialRaisedButton2.Text = $"Carrinho ({Program.Carrinho.produtos.Length})";
        }

        void showPagina(int pagina)
        {
            foreach (CardProduto c in panel1.Controls)
            {
                c.Visible = false;
                Console.WriteLine(c.Name);
            }
            var max = (pagina * 8 > produtos.Length ? produtos.Length - (pagina - 1) * 8:8);
            for (int i = 0; i < max; i++)
            {
                int indexCopy = i;
                
                EventHandler clickEvent = new System.EventHandler((object sender, EventArgs e) =>
                {
                    Ingredientes form = new Ingredientes(produtos[(indexCopy) + (pagina - 1) * 8]);
                    form.ShowDialog();
                    ComputeTotal();
                });
                ((CardProduto)panel1.Controls[7 - i]).SetOnClick(clickEvent);
                ((CardProduto)panel1.Controls[7 - i]).Visible = true;
                ((CardProduto)panel1.Controls[7 - i]).lblNome.Text = produtos[(i) + (pagina - 1)*8].Name;
                ((CardProduto)panel1.Controls[7 - i]).lblPreco.Text = "R$" + produtos[(i) + (pagina - 1) * 8].Cost;
                ((CardProduto)panel1.Controls[7 - i]).pictureBox1.LoadAsync("https://localhost:44323/api/ProdutoFoto/" + produtos[(i) + (pagina - 1) * 8].ID);
            }
        }


        public Produtos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange200, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Carrinho c = (new Carrinho());
            c.ShowDialog();
            if((int)c.Tag ==1)
            {
                Close();
            }
            else
            {
                ComputeTotal();
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            string URL = $"https://localhost:44323/api/Produtos/";
            string urlParameters = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            ProdutoParcial[] resultado = serializer.Deserialize<List<ProdutoParcial>>(response.Content.ReadAsStringAsync().Result).ToArray();

            if (response.IsSuccessStatusCode)
            {
                produtos = resultado;
                pagina = 1;
                paginas = (int)Math.Ceiling(produtos.Length / 8d);
                showPagina(pagina);

            }
            else
            {
                MessageBox.Show("Erro em obter produtos da API. Contate um funcionário.");
            }

            client.Dispose();
        }


        private void voltarNaLista_Click(object sender, EventArgs e)
        {
            if (pagina != 1)
            {
                pagina--;
                showPagina(pagina);
            }
        }

        private void avancarNaLista_Click(object sender, EventArgs e)
        {
            if (pagina != paginas)
            {
                pagina++;
                showPagina(pagina);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        { Carrinho carrinho = new Carrinho();
            
            carrinho.ShowDialog();
        }
    }
}
