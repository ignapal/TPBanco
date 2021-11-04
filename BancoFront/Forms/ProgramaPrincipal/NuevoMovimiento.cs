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

namespace BancoFront.Forms.ProgramaPrincipal
{
    public partial class NuevoMovimiento : Form
    {
        private readonly string urlBase = "https://localhost:5001/";
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

        private async Task CargarComboClientesAsync() {

            try
            {
                var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + "obtenerClientesActivos");
                var body = await response.Content.ReadAsStringAsync();
                List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(body);
                cboClientes.DataSource = clientes;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los clientes", "Fallo Carga de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
            
        }

        private async void NuevoMovimiento_Load(object sender, EventArgs e)
        {
            await CargarComboClientesAsync();
            
        }

        //private async Task CargarComboCuentas()
        //{
        //    try
        //    {
        //        Cliente cliente = (Cliente)cboClientes.SelectedItem;
        //        var response = await HttpCliSingleton.GetClient().GetAsync(urlBase + $"obtenerCuentasActivas/{cliente.IdCliente}");
        //        var body = await response.Content.ReadAsStringAsync();
        //        List<Cuenta> cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(body);
        //        cboCuentas.DataSource = cuentas;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("No se pudieron cargar las cuentas", "Fallo Carga de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        cboClientes.SelectedItem = -1;
        //        this.Dispose();
        //    }
        //}

        //private async void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    await CargarComboCuentas();
        //}
    }
}
