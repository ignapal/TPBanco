using BancoBackend.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFront.Forms.ProgramaPrincipal.Cuentas
{
    public partial class EliminarCuenta : Form
    {
        private readonly string urlBase = "https://localhost:5001/";
        public EliminarCuenta()
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

                MessageBox.Show("No se pudieron obtener las cuentas del cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void EliminarCuenta_Load(object sender, EventArgs e)
        {
            await CargarDgvClientesAsync();
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

        private async void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            
            if (cboCuentas.SelectedIndex >= 0)
            {
                decimal cbu = Convert.ToDecimal(cboCuentas.SelectedValue.ToString());
                try
                {
                    var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + $"eliminarCuenta/{cbu}");
                    var body = await response.Content.ReadAsStringAsync();
                    bool ok = JsonConvert.DeserializeObject<bool>(body);
                    if (ok)
                    {
                        MessageBox.Show($"Cuenta: {cbu} eliminada correctamente", "Cuenta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        return;
                    }
                    else {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo eliminar la cuenta", "Error al eliminar cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else {
                MessageBox.Show("Seleccione una cuenta", "Seleccionar Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
        }

        private void Limpiar()
        {
            cboCuentas.DataSource = null;
            lblCbuDe.Text = "";
        }
    }
}
