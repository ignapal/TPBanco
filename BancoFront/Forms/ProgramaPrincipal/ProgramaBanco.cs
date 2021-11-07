using BancoBackend.Entidades;
using BancoFront.Forms.ProgramaPrincipal;
using BancoFront.Forms.ProgramaPrincipal.Cuentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFront.Forms
{
    public partial class ProgramaBanco : Form
    {
        public ProgramaBanco()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Versión 1.0 \r\n By: \r\n Victor Morales \r\n Ignacio Napal \r\n Juan Angeloni \r\n Ramiro Moreschi \r\n Nicolas Oviedo");
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarCliente().ShowDialog();
        }

        private void ProgramaBanco_Load(object sender, EventArgs e)
        {
            
        }

        private void nuevoMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoMovimiento().ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                this.Dispose();
            }
            return;
        }

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarCuenta().ShowDialog();
        }
    }
}
