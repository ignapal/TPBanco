
namespace BancoFront.Forms.ProgramaPrincipal.Cuentas
{
    partial class EliminarCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCuenta));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCbuDe = new System.Windows.Forms.Label();
            this.cboCuentas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarCuenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombreCliente,
            this.dniCliente,
            this.seleccionarCliente});
            this.dgvClientes.Location = new System.Drawing.Point(12, 123);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(366, 315);
            this.dgvClientes.TabIndex = 25;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // dniCliente
            // 
            this.dniCliente.HeaderText = "DNI";
            this.dniCliente.Name = "dniCliente";
            this.dniCliente.ReadOnly = true;
            // 
            // seleccionarCliente
            // 
            this.seleccionarCliente.HeaderText = "Seleccionar";
            this.seleccionarCliente.Name = "seleccionarCliente";
            this.seleccionarCliente.ReadOnly = true;
            this.seleccionarCliente.Text = "Seleccionar";
            this.seleccionarCliente.UseColumnTextForButtonValue = true;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.ForeColor = System.Drawing.Color.Black;
            this.lblClientes.Location = new System.Drawing.Point(161, 98);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(79, 22);
            this.lblClientes.TabIndex = 26;
            this.lblClientes.Text = "Clientes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitulo.Location = new System.Drawing.Point(274, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 45);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Eliminar Cuenta";
            // 
            // lblCbuDe
            // 
            this.lblCbuDe.AutoSize = true;
            this.lblCbuDe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCbuDe.ForeColor = System.Drawing.Color.Black;
            this.lblCbuDe.Location = new System.Drawing.Point(599, 98);
            this.lblCbuDe.Name = "lblCbuDe";
            this.lblCbuDe.Size = new System.Drawing.Size(0, 22);
            this.lblCbuDe.TabIndex = 31;
            // 
            // cboCuentas
            // 
            this.cboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentas.FormattingEnabled = true;
            this.cboCuentas.Location = new System.Drawing.Point(425, 135);
            this.cboCuentas.Name = "cboCuentas";
            this.cboCuentas.Size = new System.Drawing.Size(345, 23);
            this.cboCuentas.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cuentas de:";
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(425, 238);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(135, 30);
            this.btnEliminarCuenta.TabIndex = 33;
            this.btnEliminarCuenta.Text = "Eliminar Cuenta";
            this.btnEliminarCuenta.UseVisualStyleBackColor = false;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Silver;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(640, 238);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 30);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // EliminarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarCuenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCbuDe);
            this.Controls.Add(this.cboCuentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EliminarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Cuenta";
            this.Load += new System.EventHandler(this.EliminarCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCliente;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionarCliente;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCbuDe;
        private System.Windows.Forms.ComboBox cboCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarCuenta;
        private System.Windows.Forms.Button btnVolver;
    }
}