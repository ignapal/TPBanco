using BancoBackend.Entidades;
using Newtonsoft.Json;
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
using System.Windows.Forms;

namespace BancoFront
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            //Validaciones
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (String.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Ingrese una contraseña", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (String.IsNullOrEmpty(txtPassConfirmar.Text))
            {
                MessageBox.Show("Confirme su contraseña", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!txtContrasenia.Text.Equals(txtPassConfirmar.Text)) {
                MessageBox.Show("Las contraseñas no coinciden", "Contraseñas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Fin validaciones
            Usuario usuario = new Usuario();
            usuario.Nombre = txtUsuario.Text;
            usuario.Contrasenia = txtContrasenia.Text;

            //Registrar Usuario
            string url = "https://localhost:5001/insertarUsuario";
            var usuarioJson = JsonConvert.SerializeObject(usuario);
            StringContent usuarioBody = new StringContent(usuarioJson, Encoding.UTF8, "application/json");

            var response = await HttpCliSingleton.GetClient().PostAsync(url,usuarioBody);
            var body = await response.Content.ReadAsStringAsync();

            try
            {
                bool ok = JsonConvert.DeserializeObject<Boolean>(body); 
                MessageBox.Show("Se registro correctamente el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Fallo al insertar el usuario", "Reintente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void btnVerPass_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.UseSystemPasswordChar == false)
            {
                txtContrasenia.UseSystemPasswordChar = true;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = false;
            }
        }

        private void btnVerConfirmar_Click(object sender, EventArgs e)
        {
            if (txtPassConfirmar.UseSystemPasswordChar == false)
            {
                txtPassConfirmar.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassConfirmar.UseSystemPasswordChar = false;
            }
        }

        //private async void btnRegistrar_Click(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
        //    {
        //        MessageBox.Show("Ingrese un Nombre", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        txtNombre.Focus();
        //        return;
        //    }
        //    if (String.IsNullOrEmpty(txtApellido.Text.Trim())) {

        //        MessageBox.Show("Ingrese un Apellido", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        txtApellido.Focus();
        //        return;
        //    }

        //    try {
        //        if (Convert.ToInt32(txtDni.Text) < 1) {
        //            MessageBox.Show("Ingrese un numero válido", "DNI Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            txtDni.Focus();
        //            return;
        //        }
        //    } catch {
        //        MessageBox.Show("Ingrese un numero válido", "DNI Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        txtDni.Focus();
        //        return;
        //    }
        //    cliente.Dni = Convert.ToInt32(txtDni.Text);
        //    cliente.Apellido = txtApellido.Text;
        //    cliente.Nombre = txtNombre.Text;


        //    string url = "https://localhost:5001/banco/Cliente";
        //    var content = JsonConvert.SerializeObject<Cliente>;

        //    var response = await httpClient.PostAsync(url, content);
        //    var body = await response.Content.ReadAsStringAsync();
        //    bool result = JsonConvert.DeserializeObject<Boolean>(body);
        //    if (result)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Registro realizado correctamente", "Resultado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        if (dialogResult == DialogResult.OK)
        //        {
        //            this.Dispose();
        //        }
        //    }
        //    else {
        //        DialogResult dialogResult = MessageBox.Show("No se completo el registro", "Resultado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //}

        //private void btnLimpiar_Click(object sender, EventArgs e)
        //{
        //    Limpiar();
        //}

        //private void Limpiar()
        //{
        //    txtApellido.Text = "";
        //    txtNombre.Text = "";
        //    txtDni.Text = "";
        //}
    }
}
