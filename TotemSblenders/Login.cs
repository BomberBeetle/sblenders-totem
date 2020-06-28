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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;

namespace TelaSblenders
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
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
                    MessageBox.Show($"sucesso no login;id {Program.userID}; token {Program.userToken}");
                }
                else
                {
                    if ((string)resultado["error"] == "AUTH_ERROR")
                    {
                        MessageBox.Show("credenciais erradas mermao");
                    }
                }

                client.Dispose();
            }
            //(new TInicial()).ShowDialog();
        }
    }
}
