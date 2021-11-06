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

namespace BancoFront.Forms.ProgramaPrincipal
{
    public partial class NuevoMovimiento : Form
    {
        private readonly string urlBase = "https://localhost:5001/";
        private int idUltimoMovimiento;
        public NuevoMovimiento()
        {
            InitializeComponent();
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea volver? ", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (respuesta.Equals(DialogResult.Yes))
            {
                this.Dispose();
            }
        }

        private async Task ObtenerIdUltimoMovimiento() {
            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "getUltimoMovimientoId");
                var body = await response.Content.ReadAsStringAsync();
                idUltimoMovimiento = JsonConvert.DeserializeObject<int>(body);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el ultimo id de movimiento", "Fallo Carga de ultimoIdMovimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            
        }
        private async Task CargarDgvClientesAsync() {

            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "obtenerClientesActivos");
                var body = await response.Content.ReadAsStringAsync();
                List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(body);
                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(new object[] { cliente.IdCliente,cliente.Apellido +", "+ cliente.Nombre, cliente.Dni});
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los clientes", "Fallo Carga de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            
        }

        private async void NuevoMovimiento_Load(object sender, EventArgs e)
        {
            await CargarDgvClientesAsync();
            await ObtenerIdUltimoMovimiento();
        }

        private async void btnTransferir_Click(object sender, EventArgs e)
        {

            decimal montoTransferencia;
            decimal cbuDestinoTrans;
            decimal cbuOrigenTrans;

            //Validaciones
            if (cboCuentas.SelectedIndex < 0) {
                MessageBox.Show("Selecciona la cuenta de origen", "Cuenta de Origen Nula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCuentas.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtCbuDestino.Text.Trim()))
            {
                MessageBox.Show("Selecciona la cuenta de destino", "Cuenta de Destino Nula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCbuDestino.Focus();
                return;
            }

            if (txtCbuDestino.Text.Trim().Length != 22)
            {
                MessageBox.Show("El CBU debe contener 22 dígitos", "CBU inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCbuDestino.Focus();
                return;
            }

            if (cboCuentas.SelectedValue.ToString().Trim().Equals(txtCbuDestino.Text.Trim()))
            {
                MessageBox.Show("No puede transferir dinero de una cuenta a sí misma", "CBU de ambas cuentas iguales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCbuDestino.Focus();
                return;
            }

            try
            {
                Cuenta cuentaDestinoSelected = (Cuenta)cboCuentas.SelectedItem;
                montoTransferencia = Convert.ToDecimal(txtMonto.Text.Trim());

                if (montoTransferencia > cuentaDestinoSelected.Saldo)
                {
                    MessageBox.Show("No dispone de el importe que desea transferir", "Saldo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonto.Focus();
                    return;
                }

                if (montoTransferencia < 1)
                {
                    MessageBox.Show("Ingrese un monto mayor a $1", "Monto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonto.Focus();
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un monto válido", "Monto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtMonto.Text.Trim()))
            {
                MessageBox.Show("No puede transferir dinero de una cuenta a sí misma", "CBU de ambas cuentas iguales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }
            //Fin validaciones

            if (MessageBox.Show($" Desde CBU:{cboCuentas.SelectedValue}\r\n Para CBU:{txtCbuDestino.Text} \r\n Por el monto de: ${txtMonto.Text}", "¿Desea realizar la transferencia?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {

                cbuOrigenTrans = Convert.ToDecimal(cboCuentas.SelectedValue.ToString());
                cbuDestinoTrans = Convert.ToDecimal(txtCbuDestino.Text);

                Movimiento movimiento = new();
                movimiento.CbuOrigen = cbuOrigenTrans;
                movimiento.CbuDestino = cbuDestinoTrans;
                movimiento.IdMovimiento = idUltimoMovimiento;
                movimiento.Monto = montoTransferencia;
                try
                {
                    string movimientoJson = JsonConvert.SerializeObject(movimiento);
                    StringContent data = new(movimientoJson, Encoding.UTF8, "application/json");

                    var response = await HttpCliSingleton.GetClient().PostAsync(urlBase + "insertarMovimiento", data);
                    var body = await response.Content.ReadAsStringAsync();
                    bool ok = JsonConvert.DeserializeObject<bool>(body);
                    if (!ok) {
                        throw new Exception("No se pudo realizar la transferencia. Reintente");
                    }
                    MessageBox.Show($"Transferencia Realizada\r\n De:{cboCuentas.SelectedValue}\r\n Para:{txtCbuDestino.Text}\r\n Monto: ${txtMonto.Text}", "Transferencia Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    await ObtenerIdUltimoMovimiento();
                    return;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error al realizar transferencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
            }
            return;
        }

        private void Limpiar()
        {
            cboCuentas.DataSource = null;
            txtCbuDestino.Text = "";
            txtMonto.Text = "";
            lblCbuDe.Text = "";
        }

        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentCell.ColumnIndex == 3)
                {
                  int idClienteSeleccionado = (int)dgvClientes.CurrentRow.Cells[0].Value;
                   await CargarComboCuentas(idClienteSeleccionado);
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("No se pudieron obtener las cuentas del cliente seleccionado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cboCuentas.DataSource = null;
                return;
            }
            
        }

        private async Task CargarComboCuentas(int id)
        {
            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + $"obtenerCuentasActivas/{id}");
                var body = await response.Content.ReadAsStringAsync();
                List<Cuenta> cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(body);
                cboCuentas.DataSource = cuentas;
                lblCbuDe.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                cboCuentas.Items.Clear();
                MessageBox.Show("No se pudieron cargar las cuentas", "Fallo Carga de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}
