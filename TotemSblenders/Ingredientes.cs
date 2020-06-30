using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using MaterialSkin.Controls;
using SblendersAPI.Models;

namespace TelaSblenders
{
    public partial class Ingredientes : MaterialForm
    {
        Produto produto;

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
                /*
                codigo pra mostrar as coisas; acesse as propriedades com produto.propriedade.
                */
            }
            else
            {
                MessageBox.Show("Erro em obter os deltalhes do produto da API. Contate um funcionário.");
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
