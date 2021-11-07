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

namespace BancoFront.Forms.ProgramaPrincipal.Cuentas
{
    public partial class AgregarCuenta : Form
    {
        private readonly string urlBase = "https://localhost:5001/";
        private int idClienteSeleccionado;
        public AgregarCuenta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea volver? ", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta.Equals(DialogResult.Yes))
            {
                this.Dispose();
            }
        }

        private async void AgregarCuenta_Load(object sender, EventArgs e)
        {
            await CargarDgvClientesAsync();
            await CargarComboCuentas();
        }

        private async Task CargarComboCuentas()
        {
            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "getTiposCuenta");
                var body = await response.Content.ReadAsStringAsync();
                List<TipoCuenta> tiposCuenta = JsonConvert.DeserializeObject<List<TipoCuenta>>(body);

                if (tiposCuenta.Count < 1)
                {
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

        private async Task CargarDgvClientesAsync()
        {

            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "obtenerClientesActivos");
                var body = await response.Content.ReadAsStringAsync();
                List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(body);
                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(new object[] { cliente.IdCliente, cliente.Apellido + ", " + cliente.Nombre, cliente.Dni });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los clientes", "Fallo Carga de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentCell.ColumnIndex == 3) {
                idClienteSeleccionado = (int)dgvClientes.CurrentRow.Cells[0].Value;
                string nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                lblCliente.Text = nombre;
            }
        }

        private async void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            if (cboTiposCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cuenta", "Tipo de Cuenta Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTiposCuenta.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCBU.Text) || txtCBU.Text.Length != 22)
            {
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
                    if (cbuValidado < 0) { throw new Exception(); }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un CBU con formato válido", "CBU inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCBU.Text = "";
                    txtCBU.Focus();
                    return;
                }

                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "validarCbu/" + cbuValidado.ToString());
                var body = await response.Content.ReadAsStringAsync();

                bool existe = JsonConvert.DeserializeObject<bool>(body);
                if (existe)
                {
                    MessageBox.Show("CBU ya existente", "CBU repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCBU.Focus();
                    return;
                }

                Cuenta cuenta = new();
                cuenta.Saldo = 0;
                cuenta.IdCliente = Convert.ToInt32(idClienteSeleccionado);
                cuenta.TipoCuenta = Convert.ToInt32(cboTiposCuenta.SelectedValue);
                cuenta.Cbu = cbuValidado;

                try
                {
                    StringContent cuentaHttp = new(JsonConvert.SerializeObject(cuenta), Encoding.UTF8, "application/json");

                    var response1 = await HttpCliSingleton.GetClient().PostAsync(urlBase + "insertarCuenta", cuentaHttp);
                    var body1 = await response1.Content.ReadAsStringAsync();
                    bool ok1 = JsonConvert.DeserializeObject<bool>(body1);
                    if (ok1) {
                        MessageBox.Show("Cuenta insertada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo insertar la cuenta", "Fallo al insertar cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               

                

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void Limpiar()
        {
            cboTiposCuenta.SelectedIndex = -1;
            txtCBU.Text = "";
            lblCliente.Text = "";
        }
    }
}
