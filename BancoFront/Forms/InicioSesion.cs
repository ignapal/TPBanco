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

namespace BancoFront.Forms
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text)) {
                MessageBox.Show("Ingrese un nombre de usuario","Campo Vacío",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (String.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Ingrese una contraseña", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.Nombre = txtUsuario.Text;
            usuario.Contrasenia = txtContrasenia.Text;

            string url = "https://localhost:5001/obtenerUsuario";
            string usuarioJson = JsonConvert.SerializeObject(usuario);
            StringContent usuarioBody = new StringContent(usuarioJson, Encoding.UTF8, "application/json");

            var response = await HttpCliSingleton.GetClient().PostAsync(url, usuarioBody);
            var body = await response.Content.ReadAsStringAsync();

            try
            {
                Usuario usuario1 = JsonConvert.DeserializeObject<Usuario>(body);
                MessageBox.Show("Ponele que soy el programa", "dou");
            }
            catch (Exception)
            {
                MessageBox.Show("Credenciales Inválidas", "Reintente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.UseSystemPasswordChar == false)
            {
                txtContrasenia.UseSystemPasswordChar = true;
            }
            else {
                txtContrasenia.UseSystemPasswordChar = false;
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
