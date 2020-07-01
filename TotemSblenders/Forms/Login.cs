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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using MaterialSkin;

namespace TelaSblenders
{
    public partial class Login : MaterialForm
    {
        private bool GetUserDetails()
        {
            string URL = $"https://localhost:44323/api/Agente/{Program.userID}";
            string urlParameters = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Program.userToken);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            Dictionary<string, Object> resultado = (Dictionary<string, Object>)serializer.DeserializeObject(response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                if (resultado.ContainsKey("restaurant_id"))
                {
                    Program.userRID = int.Parse((string)resultado["restaurant_id"]);
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }

            client.Dispose();
        }

        public Login()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange200, TextShade.WHITE);
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "" || materialSingleLineTextField2.Text == "")
            {
                MessageBox.Show("Os campos de login e senha devem estar preenchidos!");
                return;
            }
            else {
                string URL = $"https://localhost:44323/api/AgenteToken/{Uri.EscapeUriString(materialSingleLineTextField1.Text)}/{Uri.EscapeUriString(materialSingleLineTextField2.Text)}";
                string urlParameters = "";
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                Dictionary<string, Object> resultado = (Dictionary<string, Object>)serializer.DeserializeObject(response.Content.ReadAsStringAsync().Result);
               
                if (response.IsSuccessStatusCode)
                {
                    Program.userID = int.Parse((string)resultado["id"]);
                    Program.userToken = (string)resultado["token"];
                    if (GetUserDetails())
                    {
                        (new TInicial()).ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Credenciais incorretas.");
                    }
                }
                else
                {
                    if ((string)resultado["error"] == "AUTH_ERROR")
                    {
                        MessageBox.Show("Credenciais incorretas.");
                    }
                }

                client.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            materialSingleLineTextField1.Text = "totem1";
            materialSingleLineTextField2.Text = "teste";
        }
    }
}
