using BancoBackend.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFront
{
    public partial class formInicio : Form
    {
        private HttpClient httpClient = new HttpClient();
        public formInicio()
        {
            InitializeComponent();
        }

        private async void formInicio_Load(object sender, EventArgs e)
        {
            await GetCliente();
            loader.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async Task GetCliente(){
            string url = "https://localhost:5001/banco/Cliente";
            var response = await httpClient.GetAsync(url);
            var body = await response.Content.ReadAsStringAsync();

            Cliente cliente = JsonConvert.DeserializeObject<Cliente>(body);

            if (cliente == null)
            {
                btnInicio.Text = "Registrarse";
            }
            else {
                btnInicio.Text = "Iniciar Sesion";
            }
        }
    }
}
