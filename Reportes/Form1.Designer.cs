
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetMov = new Reportes.DataSetMov();
            this.SP_REPORTE_MOVIMIENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_MOVIMIENTOSTableAdapter = new Reportes.DataSetMovTableAdapters.SP_REPORTE_MOVIMIENTOSTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MOVIMIENTOSBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.reportViewer1.Size = new System.Drawing.Size(770, 436);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetMov
            // 
            this.DataSetMov.DataSetName = "DataSetMov";
            this.DataSetMov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REPORTE_MOVIMIENTOSBindingSource
            // 
            this.SP_REPORTE_MOVIMIENTOSBindingSource.DataMember = "SP_REPORTE_MOVIMIENTOS";
            this.SP_REPORTE_MOVIMIENTOSBindingSource.DataSource = this.DataSetMov;
            // 
            // SP_REPORTE_MOVIMIENTOSTableAdapter
            // 
            this.SP_REPORTE_MOVIMIENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 455);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ver Movimientos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MOVIMIENTOSBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_REPORTE_MOVIMIENTOSBindingSource;
        private DataSetMov DataSetMov;
        private DataSetMovTableAdapters.SP_REPORTE_MOVIMIENTOSTableAdapter SP_REPORTE_MOVIMIENTOSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

