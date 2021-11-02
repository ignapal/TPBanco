using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoBackend.Entidades;

namespace BancoFront.Forms.ProgramaPrincipal
{
    public partial class AgregarCliente : Form
    {
        List<Cuenta> cuentas;
        public AgregarCliente()
        {
            InitializeComponent();
            cuentas = new List<Cuenta>();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private async Task CargarUltimoId()
        {
            string url = "https://localhost:5001/getUltimoId";
            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                int ultimoId = JsonConvert.DeserializeObject<int>(body);
                lblNroCliente.Text = ultimoId.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el ultimo id de cliente","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private async Task CargarComboCuentas()
        {
            try
            {
                string url = "https://localhost:5001/getTiposCuenta";
                var response = await HttpCliSingleton.GetClient().GetAsync(url);
                var body = await response.Content.ReadAsStringAsync();
                List<TipoCuenta> tiposCuenta = JsonConvert.DeserializeObject<List<TipoCuenta>>(body);

                if (tiposCuenta.Count < 1) {
                    throw new Exception("No se pudo obtener los tipos de cuenta");
                }

                cboTiposCuenta.DataSource = tiposCuenta;

                cboTiposCuenta.ValueMember = "IdTipoCuenta";
                cboTiposCuenta.DisplayMember = "NombreTipoCuenta";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private async void AgregarCliente_Load(object sender, EventArgs e)
        {
           await CargarUltimoId();
           await CargarComboCuentas();
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboTiposCuenta.SelectedIndex = -1;
            txtCBU.Text = "";
        }

        private async void btnAgregarCuenta_Click(object sender, EventArgs e)
        {

            if (cboTiposCuenta.SelectedIndex == -1) {
                MessageBox.Show("Seleccione un tipo de cuenta", "Tipo de Cuenta Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtCBU.Text) || txtCBU.Text.Length != 22) {
                MessageBox.Show("Ingrese un CBU con formato válido", "CBU inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                decimal cbuValidado = Convert.ToDecimal(txtCBU.Text);

                string url = "https://localhost:5001/validarCbu/" + cbuValidado.ToString();
                var response = await HttpCliSingleton.GetClient().GetAsync(url);
                var body = await response.Content.ReadAsStringAsync();

                bool existe = JsonConvert.DeserializeObject<bool>(body);
                if (existe) {
                    MessageBox.Show("CBU ya existente", "CBU repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cuenta cuenta = new Cuenta();
                cuenta.Saldo = 0;
                cuenta.IdCliente = Convert.ToInt32(lblNroCliente.Text);
                cuenta.TipoCuenta = Convert.ToInt32(cboTiposCuenta.SelectedValue);
                cuenta.Cbu = cbuValidado;

                cuentas.Add(cuenta);
                dgvCuentas.Rows.Add(new object[] { cboTiposCuenta.SelectedItem.ToString(),cuenta.IdCliente,cuenta.Cbu});

            }
            catch (Exception )
            {
                MessageBox.Show("Fallo todo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }
    }
}
