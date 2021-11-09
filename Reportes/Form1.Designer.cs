
namespace Reportes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SP_REPORTE_MOVIMIENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMov = new Reportes.DataSetMov();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_REPORTE_MOVIMIENTOSTableAdapter = new Reportes.DataSetMovTableAdapters.SP_REPORTE_MOVIMIENTOSTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chMDesde = new System.Windows.Forms.CheckBox();
            this.chFDesde = new System.Windows.Forms.CheckBox();
            this.chMHasta = new System.Windows.Forms.CheckBox();
            this.chFHasta = new System.Windows.Forms.CheckBox();
            this.cboTiposCuenta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chTipoCuenta = new System.Windows.Forms.CheckBox();
            this.chCliente = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MOVIMIENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMov)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_REPORTE_MOVIMIENTOSBindingSource
            // 
            this.SP_REPORTE_MOVIMIENTOSBindingSource.DataMember = "SP_REPORTE_MOVIMIENTOS";
            this.SP_REPORTE_MOVIMIENTOSBindingSource.DataSource = this.DataSetMov;
            // 
            // DataSetMov
            // 
            this.DataSetMov.DataSetName = "DataSetMov";
            this.DataSetMov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMov";
            reportDataSource1.Value = this.SP_REPORTE_MOVIMIENTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.ReportMovimientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(770, 313);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_REPORTE_MOVIMIENTOSTableAdapter
            // 
            this.SP_REPORTE_MOVIMIENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(353, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(653, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(260, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ver Movimientos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.Location = new System.Drawing.Point(267, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(558, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.Location = new System.Drawing.Point(94, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Clientes";
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
            this.cliente,
            this.seleccionar});
            this.dgvClientes.Enabled = false;
            this.dgvClientes.Location = new System.Drawing.Point(12, 166);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(237, 126);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.Visible = false;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.ReadOnly = true;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseColumnTextForButtonValue = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblCliente.Location = new System.Drawing.Point(353, 112);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 22);
            this.lblCliente.TabIndex = 9;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Location = new System.Drawing.Point(294, 272);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 10;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Location = new System.Drawing.Point(585, 272);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 11;
            // 
            // nudHasta
            // 
            this.nudHasta.Enabled = false;
            this.nudHasta.Location = new System.Drawing.Point(585, 214);
            this.nudHasta.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudHasta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(200, 20);
            this.nudHasta.TabIndex = 12;
            this.nudHasta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDesde
            // 
            this.nudDesde.Enabled = false;
            this.nudDesde.Location = new System.Drawing.Point(294, 214);
            this.nudDesde.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudDesde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(200, 20);
            this.nudDesde.TabIndex = 13;
            this.nudDesde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Red;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(12, 323);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(773, 39);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chMDesde
            // 
            this.chMDesde.AutoSize = true;
            this.chMDesde.Location = new System.Drawing.Point(294, 194);
            this.chMDesde.Name = "chMDesde";
            this.chMDesde.Size = new System.Drawing.Size(15, 14);
            this.chMDesde.TabIndex = 15;
            this.chMDesde.UseVisualStyleBackColor = true;
            this.chMDesde.CheckedChanged += new System.EventHandler(this.chMDesde_CheckedChanged);
            // 
            // chFDesde
            // 
            this.chFDesde.AutoSize = true;
            this.chFDesde.Location = new System.Drawing.Point(294, 252);
            this.chFDesde.Name = "chFDesde";
            this.chFDesde.Size = new System.Drawing.Size(15, 14);
            this.chFDesde.TabIndex = 16;
            this.chFDesde.UseVisualStyleBackColor = true;
            this.chFDesde.CheckedChanged += new System.EventHandler(this.chFDesde_CheckedChanged);
            // 
            // chMHasta
            // 
            this.chMHasta.AutoSize = true;
            this.chMHasta.Location = new System.Drawing.Point(585, 194);
            this.chMHasta.Name = "chMHasta";
            this.chMHasta.Size = new System.Drawing.Size(15, 14);
            this.chMHasta.TabIndex = 17;
            this.chMHasta.UseVisualStyleBackColor = true;
            this.chMHasta.CheckedChanged += new System.EventHandler(this.chMHasta_CheckedChanged);
            // 
            // chFHasta
            // 
            this.chFHasta.AutoSize = true;
            this.chFHasta.Location = new System.Drawing.Point(585, 252);
            this.chFHasta.Name = "chFHasta";
            this.chFHasta.Size = new System.Drawing.Size(15, 14);
            this.chFHasta.TabIndex = 18;
            this.chFHasta.UseVisualStyleBackColor = true;
            this.chFHasta.CheckedChanged += new System.EventHandler(this.chFHasta_CheckedChanged);
            // 
            // cboTiposCuenta
            // 
            this.cboTiposCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposCuenta.Enabled = false;
            this.cboTiposCuenta.FormattingEnabled = true;
            this.cboTiposCuenta.Location = new System.Drawing.Point(584, 137);
            this.cboTiposCuenta.Name = "cboTiposCuenta";
            this.cboTiposCuenta.Size = new System.Drawing.Size(201, 21);
            this.cboTiposCuenta.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.Location = new System.Drawing.Point(612, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tipo de Cuenta";
            // 
            // chTipoCuenta
            // 
            this.chTipoCuenta.AutoSize = true;
            this.chTipoCuenta.Location = new System.Drawing.Point(584, 117);
            this.chTipoCuenta.Name = "chTipoCuenta";
            this.chTipoCuenta.Size = new System.Drawing.Size(15, 14);
            this.chTipoCuenta.TabIndex = 21;
            this.chTipoCuenta.UseVisualStyleBackColor = true;
            this.chTipoCuenta.CheckedChanged += new System.EventHandler(this.chTipoCuenta_CheckedChanged);
            // 
            // chCliente
            // 
            this.chCliente.AutoSize = true;
            this.chCliente.Location = new System.Drawing.Point(15, 137);
            this.chCliente.Name = "chCliente";
            this.chCliente.Size = new System.Drawing.Size(15, 14);
            this.chCliente.TabIndex = 22;
            this.chCliente.UseVisualStyleBackColor = true;
            this.chCliente.CheckedChanged += new System.EventHandler(this.chCliente_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.chCliente);
            this.Controls.Add(this.chTipoCuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTiposCuenta);
            this.Controls.Add(this.chFHasta);
            this.Controls.Add(this.chMHasta);
            this.Controls.Add(this.chFDesde);
            this.Controls.Add(this.chMDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.nudDesde);
            this.Controls.Add(this.nudHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ver Movimientos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MOVIMIENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMov)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_REPORTE_MOVIMIENTOSBindingSource;
        private DataSetMov DataSetMov;
        private DataSetMovTableAdapters.SP_REPORTE_MOVIMIENTOSTableAdapter SP_REPORTE_MOVIMIENTOSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
        private System.Windows.Forms.CheckBox chMDesde;
        private System.Windows.Forms.CheckBox chFDesde;
        private System.Windows.Forms.CheckBox chMHasta;
        private System.Windows.Forms.CheckBox chFHasta;
        private System.Windows.Forms.ComboBox cboTiposCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chTipoCuenta;
        private System.Windows.Forms.CheckBox chCliente;
    }
}

