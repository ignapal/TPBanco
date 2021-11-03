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
using System.Net.Http;

namespace BancoFront.Forms.ProgramaPrincipal
{
    public partial class AgregarCliente : Form
    {
        private Cliente cliente;
        private readonly string urlBase = "https://localhost:5001/";
        public AgregarCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea volver? Perderá los datos que no haya insertado", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.Equals(DialogResult.Yes))
            {
                this.Dispose();
            }

        }
        private async Task CargarUltimoId()
        {
            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "getUltimoId");
                var body = await response.Content.ReadAsStringAsync();
                int ultimoId = JsonConvert.DeserializeObject<int>(body);
                lblNroCliente.Text = ultimoId.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el ultimo id de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private async Task CargarComboCuentas()
        {
            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "getTiposCuenta");
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
            LimpiarCliente();
        }

        private void LimpiarCliente()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCuenta();
        }

        private void LimpiarCuenta() {
            cboTiposCuenta.SelectedIndex = -1;
            txtCBU.Text = "";
            cboTiposCuenta.Focus();
        }

        private async void btnAgregarCuenta_Click(object sender, EventArgs e)
        {

            if (cboTiposCuenta.SelectedIndex == -1) {
                MessageBox.Show("Seleccione un tipo de cuenta", "Tipo de Cuenta Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTiposCuenta.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCBU.Text) || txtCBU.Text.Length != 22) {
                MessageBox.Show("Ingrese un CBU con formato válido", "CBU inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCBU.Focus();
                return;
            }


            try
            {
                decimal cbuValidado;
                try
                {
                    cbuValidado = Convert.ToDecimal(txtCBU.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un CBU con formato válido", "CBU inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCBU.Text = "";
                    txtCBU.Focus();
                    return;
                }
                if (ExisteCbuEnGrilla(cbuValidado)) {
                    MessageBox.Show("CBU ya existente", "CBU repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCBU.Focus();
                    return;
                }

                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "validarCbu/" + cbuValidado.ToString());
                var body = await response.Content.ReadAsStringAsync();

                bool existe = JsonConvert.DeserializeObject<bool>(body);
                if (existe) {
                    MessageBox.Show("CBU ya existente", "CBU repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCBU.Focus();
                    return;
                }

                Cuenta cuenta = new();
                cuenta.Saldo = 0;
                cuenta.IdCliente = Convert.ToInt32(lblNroCliente.Text);
                cuenta.TipoCuenta = Convert.ToInt32(cboTiposCuenta.SelectedValue);
                cuenta.Cbu = cbuValidado;

                cliente.Cuentas.Add(cuenta);
                dgvCuentas.Rows.Add(new object[] { cuenta.IdCliente, cboTiposCuenta.SelectedItem, cuenta.Cbu });
                LimpiarCuenta();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCuenta();
                return;
            }
        }

        private bool ExisteCbuEnGrilla(decimal cbu) {
            foreach (DataGridViewRow row in dgvCuentas.Rows)
            {
                if (Convert.ToDecimal(row.Cells["cbu"].Value).Equals(cbu)) {
                    return true;
                }
            }
            return false;
        }


        private async void LimpiarNuevaInsercion()
        {
            LimpiarCliente();
            LimpiarCuenta();
            await CargarUltimoId();
            dgvCuentas.Rows.Clear();
            cliente = new Cliente();
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.CurrentCell.ColumnIndex == 3) {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar la cuenta?", "Eliminar Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta.Equals(DialogResult.No))
                {
                    return;
                }
                else {

                    decimal cbuCuentaActual = Convert.ToDecimal(dgvCuentas.CurrentRow.Cells["cbu"].Value);

                    foreach (Cuenta cuenta in cliente.Cuentas)
                    {
                        if (cuenta.Cbu.Equals(cbuCuentaActual)) {
                            cliente.Cuentas.Remove(cuenta);
                            break;
                        }
                    }
                    dgvCuentas.Rows.Remove(dgvCuentas.CurrentRow);
                }
            }
        }

        private async void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de Cliente", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido de Cliente", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtDni.Text) || txtDni.Text.Length < 7 || txtDni.Text.Length > 9)
            {
                MessageBox.Show("Ingrese un Dni Válido", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return;
            }
            if (cliente.Cuentas.Count < 1 || dgvCuentas.Rows.Count < 1)
            {
                MessageBox.Show("No hay cuentas agregadas", "Agregue 1 cuenta como mínimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTiposCuenta.Focus();
                return;
            }


            cliente.Apellido = txtApellido.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Dni = Convert.ToInt32(txtDni.Text);
            cliente.IdCliente = Convert.ToInt32(lblNroCliente.Text);

            var usuarioJson = JsonConvert.SerializeObject(cliente);
            StringContent usuarioBody = new(usuarioJson, Encoding.UTF8, "application/json");

            try
            {
                var response = await HttpCliSingleton.GetClient().PostAsync(urlBase + "insertarCliente", usuarioBody);
                var body = await response.Content.ReadAsStringAsync();
                bool ok = JsonConvert.DeserializeObject<bool>(body);
                if (!ok)
                {
                    throw new Exception("Error al insertar usuario");
                }
                MessageBox.Show("Cliente y Cuentas agregados correctamente", "Exito al insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarNuevaInsercion();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el cliente y sus cuentas", "Error al insertar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
