using MaterialSkin.Controls;
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

namespace TelaSblenders
{
    public partial class TelaPgto : MaterialForm
    {
        public TelaPgto()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

            Program.Carrinho.agenteID = Program.userID;
            Program.Carrinho.dataHoraPedido = DateTime.Now;
            Program.Carrinho.endereco = "";
            Program.Carrinho.instrucoes = "";
            

            string URL = $"https://localhost:44323/api/Pedidos";
            string urlParameters = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Program.userToken);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            HttpResponseMessage response = client.PutAsync(urlParameters, new StringContent(serializer.Serialize(Program.Carrinho), Encoding.UTF8, "application/json")).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            string resultado = (response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                new TelaFinal(resultado).ShowDialog();
                Close();
            }
            else
            {
                Close();
            }
        }
    }
}
