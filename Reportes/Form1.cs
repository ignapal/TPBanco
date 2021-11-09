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
            await CargarComboCuentas();
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

        private void ActualizarReporte(int? idCliente,int? idTipoCuenta,decimal? montoDesde, decimal? montoHasta, DateTime? fechaDesde, DateTime? fechaHasta) {
            this.SP_REPORTE_MOVIMIENTOSTableAdapter.Fill(this.DataSetMov.SP_REPORTE_MOVIMIENTOS, idCliente,idTipoCuenta,montoDesde,montoHasta,fechaDesde,fechaHasta);
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (dtpHasta.Enabled.Equals(true) && dtpDesde.Enabled.Equals(true) && dtpHasta.Value.Date < dtpDesde.Value.Date) {
                MessageBox.Show("La fecha Desde no puede ser mayor a la fecha Límite","Rango de fechas inválido", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (nudHasta.Enabled.Equals(true) && nudDesde.Enabled.Equals(true) && nudHasta.Value < nudDesde.Value)
            {
                MessageBox.Show("El monto Desde no puede ser mayor al monto Límite", "Rango de montos inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Monto
            decimal? montoDesde = null;
            decimal? montoHasta = null;
            if (nudDesde.Enabled.Equals(true)) {
                montoDesde = Convert.ToDecimal(nudDesde.Value);
            }
            if (nudHasta.Enabled.Equals(true))
            {
                montoHasta = Convert.ToDecimal(nudHasta.Value);
            }
            //Fecha
            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            if (dtpDesde.Enabled.Equals(true))
            {
                fechaDesde = dtpDesde.Value;
            }
            if (dtpHasta.Enabled.Equals(true))
            {
                fechaHasta = dtpHasta.Value;
            }
            //Tipo Cuenta
            int? idTipoCuenta = null;
            if (cboTiposCuenta.Enabled.Equals(true) && cboTiposCuenta.SelectedIndex >= 0) {
                idTipoCuenta = (int?)cboTiposCuenta.SelectedValue;
            }
            //Cliente
            int? idCliente = null;
            if (dgvClientes.Enabled.Equals(true) && idClienteSeleccionado != null)
            {
                idCliente = idClienteSeleccionado;
            }
            ActualizarReporte(idCliente,idTipoCuenta,montoDesde,montoHasta,fechaDesde,fechaHasta);
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
                cboTiposCuenta.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private void chFHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (chFHasta.CheckState == CheckState.Unchecked)
            {
                dtpHasta.Enabled = false;
                dtpHasta.Value = DateTime.Parse("19/03/1950");
            }
            else { 
                dtpHasta.Enabled = true;
                dtpHasta.Value = DateTime.Today;
            }
        }

        private void chFDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (chFDesde.CheckState == CheckState.Unchecked)
            {
                dtpDesde.Enabled = false;
                dtpDesde.Value = DateTime.Parse("19/03/1950");
            }
            else { 
                dtpDesde.Enabled = true;
                dtpDesde.Value = DateTime.Today;
            }
        }

        private void chMDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (chMDesde.CheckState == CheckState.Unchecked)
            {
                nudDesde.Enabled = false;
                nudDesde.Value = 1;
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
                nudHasta.Value = 1;
            }
            else {
                nudHasta.Enabled = true;

            } 
            
        }

        private void chTipoCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chTipoCuenta.CheckState == CheckState.Unchecked)
            {
                cboTiposCuenta.Enabled = false;
                cboTiposCuenta.SelectedIndex = -1;
            }
            else
            {
                cboTiposCuenta.Enabled = true;
            }
        }

        private void chCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chCliente.CheckState == CheckState.Unchecked)
            {
                dgvClientes.Enabled = false;
                idClienteSeleccionado = 0;
                lblCliente.Text = "";
            }
            else
            {
                dgvClientes.Enabled = true;
            }
        }
    }

    internal class TipoCuenta
    {
        public int IdTipoCuenta { get; set; }
        public string NombreTipoCuenta { get; set; }

        public TipoCuenta()
        {
            IdTipoCuenta = 0;
            NombreTipoCuenta = "";
        }
        public TipoCuenta(int idTipoCuenta, string nombreTipoCuenta)
        {
            IdTipoCuenta = idTipoCuenta;
            NombreTipoCuenta = nombreTipoCuenta;
        }
        public override string ToString()
        {
            return NombreTipoCuenta;
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
