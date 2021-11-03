
namespace BancoFront.Forms.ProgramaPrincipal
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTiposCuenta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNroCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(105, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 22);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCliente.Location = new System.Drawing.Point(261, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(201, 45);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente Nro: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(323, 124);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(135, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(561, 124);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(135, 23);
            this.txtDni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(604, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(344, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cuenta";
            // 
            // cboTiposCuenta
            // 
            this.cboTiposCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposCuenta.FormattingEnabled = true;
            this.cboTiposCuenta.ItemHeight = 15;
            this.cboTiposCuenta.Location = new System.Drawing.Point(78, 261);
            this.cboTiposCuenta.Name = "cboTiposCuenta";
            this.cboTiposCuenta.Size = new System.Drawing.Size(135, 23);
            this.cboTiposCuenta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo de Cuenta";
            // 
            // txtCBU
            // 
            this.txtCBU.Location = new System.Drawing.Point(313, 261);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(152, 23);
            this.txtCBU.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(363, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "CBU";
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCuenta.Location = new System.Drawing.Point(561, 256);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(135, 30);
            this.btnAgregarCuenta.TabIndex = 7;
            this.btnAgregarCuenta.Text = "Agregar Cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.AllowUserToResizeColumns = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            this.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCuentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.tipoCuenta,
            this.cbu,
            this.btnEliminar});
            this.dgvCuentas.Location = new System.Drawing.Point(18, 350);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCuentas.RowTemplate.Height = 25;
            this.dgvCuentas.Size = new System.Drawing.Size(522, 272);
            this.dgvCuentas.TabIndex = 9;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idCliente.Visible = false;
            this.idCliente.Width = 79;
            // 
            // tipoCuenta
            // 
            this.tipoCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoCuenta.HeaderText = "Tipo de Cuenta";
            this.tipoCuenta.Name = "tipoCuenta";
            this.tipoCuenta.ReadOnly = true;
            this.tipoCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cbu
            // 
            this.cbu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbu.HeaderText = "CBU";
            this.cbu.Name = "cbu";
            this.cbu.ReadOnly = true;
            this.cbu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(215, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cuentas";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.Brown;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(561, 463);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(135, 30);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.BackColor = System.Drawing.Color.Brown;
            this.btnLimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar1.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar1.Location = new System.Drawing.Point(716, 119);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(61, 30);
            this.btnLimpiar1.TabIndex = 4;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = false;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(716, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Silver;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(561, 522);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 30);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNroCliente.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNroCliente.Location = new System.Drawing.Point(456, 10);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(39, 45);
            this.lblNroCliente.TabIndex = 23;
            this.lblNroCliente.Text = "?";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.txtCBU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTiposCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTiposCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCBU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbu;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}