using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using MaterialSkin.Controls;
using SblendersAPI.Models;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace TelaSblenders
{
    public partial class Ingredientes : MaterialForm
    {
        Produto produto;

        public string getCategoriaNome(int id)
        {
            string URL = $"https://localhost:44323/api/CategoriaIngrediente/{id}";
            string urlParameters = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string resultado = serializer.Deserialize<string>(response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                return resultado;
                
            }
            else
            {
                return id.ToString();
            }

            client.Dispose();
        }
        public Ingredientes(ProdutoParcial p)
        {
            InitializeComponent();
            

            string URL = $"https://localhost:44323/api/Produtos/{p.ID}";
            string urlParameters = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            Produto resultado = serializer.Deserialize<Produto>(response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                produto = resultado;
                materialLabel4.Text = "Descrição: " + produto.Desc;
                List<int> categorias = new List<int>{ };
                bool hasPages = false;
                foreach(ProdutoIngrediente pI in produto.ingredientes){
                    if (categorias.Contains(pI.CategoriaIngredienteID))
                    {
                        string[] rowStrings = { pI.Name, "R$ " + pI.Price, pI.DefaultQuantity.ToString(), pI.Desc };
                        ListViewItem row = new ListViewItem(rowStrings);
                        ((MaterialListView)materialTabControl1.Controls[categorias.IndexOf(pI.CategoriaIngredienteID)].Controls[0]).Items.Add(row);
                    }
                    else
                    {
                        categorias.Add(pI.CategoriaIngredienteID);
                        MaterialListView l = new MaterialListView();
                        l.Dock = DockStyle.Fill;
                        ColumnHeader nameHeader = new ColumnHeader();
                        nameHeader.Text = "Ingrediente";
                        nameHeader.Width = 180;
                        ColumnHeader costHeader = new ColumnHeader();
                        costHeader.Text = "Custo";
                        costHeader.Width = 140;
                        ColumnHeader descHeader = new ColumnHeader();
                        descHeader.Text = "Descrição";
                        descHeader.Width = 300;
                        ColumnHeader qHeader = new ColumnHeader();
                        qHeader.Text = "Quantidade";
                        qHeader.Width = 100;
                        l.Columns.AddRange(new ColumnHeader[] { nameHeader, costHeader, qHeader, descHeader});
                        l.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                        TabPage categoriaPage = new TabPage();
                        categoriaPage.BackColor = Color.Red;
                        categoriaPage.Text = getCategoriaNome(pI.CategoriaIngredienteID); //transformar issso em uma chamada de API pra pegar o nome dps
                        categoriaPage.Controls.Add(l);                    
                        string[] rowStrings = { pI.Name, "R$ " + pI.Price, pI.DefaultQuantity.ToString(), pI.Desc };
                        ListViewItem row = new ListViewItem(rowStrings);
                        l.Items.Add(row);
                        materialTabControl1.TabPages.Add(categoriaPage);
                        hasPages = true;
                    }
                    if (hasPages)
                    {
                        materialTabSelector1.BaseTabControl = materialTabControl1;
                        materialTabSelector1.Invalidate();
                        materialTabSelector1.Update();
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro em obter os detalhes do produto da API. Contate um funcionário.");
                Close();
            }

            client.Dispose();
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
            //isso nao faz absolutamente nada mas é um breakpoint conveniente.
            materialTabControl1.Name = materialTabControl1.Name;
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

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
