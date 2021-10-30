using BancoBackend.Entidades;
using BancoBackend.Service;
using BancoFront.Forms;
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

namespace BancoFront
{
    public partial class formInicio : Form
    {
       
       
        public formInicio()
        {
            InitializeComponent();
        }

        private void formInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new Registro().ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            new InicioSesion().ShowDialog();
        }
    }
}
