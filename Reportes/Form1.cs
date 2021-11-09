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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetMov.SP_REPORTE_MOVIMIENTOS' table. You can move, or remove it, as needed.
            this.SP_REPORTE_MOVIMIENTOSTableAdapter.Fill(this.DataSetMov.SP_REPORTE_MOVIMIENTOS, null, null, null, null, null, null);

            this.reportViewer1.RefreshReport();
        }
    }
}
