﻿
namespace BancoFront.Forms
{
    partial class ProgramaBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramaBanco));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.movientosToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCuentaToolStripMenuItem,
            this.eliminarCuentaToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // agregarCuentaToolStripMenuItem
            // 
            this.agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            this.agregarCuentaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarCuentaToolStripMenuItem.Text = "Agregar Cuenta";
            this.agregarCuentaToolStripMenuItem.Click += new System.EventHandler(this.agregarCuentaToolStripMenuItem_Click);
            // 
            // eliminarCuentaToolStripMenuItem
            // 
            this.eliminarCuentaToolStripMenuItem.Name = "eliminarCuentaToolStripMenuItem";
            this.eliminarCuentaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarCuentaToolStripMenuItem.Text = "Eliminar Cuenta";
            this.eliminarCuentaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCuentaToolStripMenuItem_Click);
            // 
            // movientosToolStripMenuItem
            // 
            this.movientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoMovimientoToolStripMenuItem,
            this.verMovimientosToolStripMenuItem});
            this.movientosToolStripMenuItem.Name = "movientosToolStripMenuItem";
            this.movientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movientosToolStripMenuItem.Text = "Movimientos";
            // 
            // nuevoMovimientoToolStripMenuItem
            // 
            this.nuevoMovimientoToolStripMenuItem.Name = "nuevoMovimientoToolStripMenuItem";
            this.nuevoMovimientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoMovimientoToolStripMenuItem.Text = "Nuevo Movimiento";
            this.nuevoMovimientoToolStripMenuItem.Click += new System.EventHandler(this.nuevoMovimientoToolStripMenuItem_Click);
            // 
            // verMovimientosToolStripMenuItem
            // 
            this.verMovimientosToolStripMenuItem.Name = "verMovimientosToolStripMenuItem";
            this.verMovimientosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verMovimientosToolStripMenuItem.Text = "Ver Movimientos";
            this.verMovimientosToolStripMenuItem.Click += new System.EventHandler(this.verMovimientosToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(149, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 117);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido";
            // 
            // ProgramaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::BancoFront.Properties.Resources.santanderR;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProgramaBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastaayer Fío";
            this.Load += new System.EventHandler(this.ProgramaBanco_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCuentaToolStripMenuItem;
    }
}