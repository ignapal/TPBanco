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

namespace Reportes
{
    public partial class Form1 : Form
    {
        private int? idClienteSeleccionado = null;
        private readonly string urlBase = "https://localhost:5001/";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarDgvClientesAsync();
            this.reportViewer1.RefreshReport();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentCell.ColumnIndex == 2) {
                idClienteSeleccionado = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                lblCliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
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
                    dgvClientes.Rows.Add(new object[] { cliente.IdCliente, cliente.Apellido + ", " + cliente.Nombre});
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los clientes", "Fallo Carga de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }

        }

        private void ActualizarReporte(int? idCliente,int? idTipoCuenta,decimal montoDesde, decimal montoHasta, DateTime fechaDesde, DateTime fechaHasta) {
            this.SP_REPORTE_MOVIMIENTOSTableAdapter.Fill(this.DataSetMov.SP_REPORTE_MOVIMIENTOS, idCliente,idTipoCuenta,montoDesde,montoHasta,fechaDesde,fechaHasta);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (dtpHasta.Value.Date > dtpDesde.Value.Date) {
                MessageBox.Show("La fecha Desde no puede ser mayor a la fecha Límite","Rango de fechas inválido", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (nudHasta.Value > nudDesde.Value)
            {
                MessageBox.Show("El monto Desde no puede ser mayor al monto Límite", "Rango de montos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chFHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (chFHasta.CheckState == CheckState.Unchecked)
            {
                dtpHasta.Enabled = false;
            }
            else { dtpHasta.Enabled = true; }
        }

        private void chFDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (chFDesde.CheckState == CheckState.Unchecked)
            {
                dtpDesde.Enabled = false;
            }
            else { dtpDesde.Enabled = true; }
        }

        private void chMDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (chMDesde.CheckState == CheckState.Unchecked)
            {
                nudDesde.Enabled = false;
            }
            else {
                nudDesde.Enabled = true;
            }
        }

        private void chMHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (chMHasta.CheckState == CheckState.Unchecked)
            {
                nudHasta.Enabled = false;
            }
            else {
                nudHasta.Enabled = true;
            } 
            
        }
    }

    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime? FechaBaja { get; set; }

        public Cliente()
        {
            IdCliente = 0;
            Nombre = "";
            Apellido = "";
            Dni = 0;
        }

        public Cliente(int idCliente, string nombre, string apellido, int dni, DateTime fechaBaja)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaBaja = fechaBaja;
        }

        public override string ToString()
        {
            return $"{Apellido}, {Nombre}";
        }
    }
}
