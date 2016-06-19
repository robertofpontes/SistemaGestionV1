namespace SistemaGestion
{
    partial class FrmPadre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPadre));
            this._Pnl_Espera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosIVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Ctrl_Buscar1 = new SistemaGestion.CONTROLES._Ctrl_Buscar();
            this._Pnl_Espera.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Pnl_Espera
            // 
            this._Pnl_Espera.BackColor = System.Drawing.Color.SteelBlue;
            this._Pnl_Espera.Controls.Add(this.label1);
            this._Pnl_Espera.Location = new System.Drawing.Point(689, 72);
            this._Pnl_Espera.Name = "_Pnl_Espera";
            this._Pnl_Espera.Size = new System.Drawing.Size(108, 31);
            this._Pnl_Espera.TabIndex = 36;
            this._Pnl_Espera.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Por favor espere...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.impuestosIVAToolStripMenuItem,
            this.retenciónToolStripMenuItem,
            this.formaDePagoToolStripMenuItem,
            this.articulosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // impuestosIVAToolStripMenuItem
            // 
            this.impuestosIVAToolStripMenuItem.Name = "impuestosIVAToolStripMenuItem";
            this.impuestosIVAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.impuestosIVAToolStripMenuItem.Text = "Impuestos (IVA)";
            // 
            // retenciónToolStripMenuItem
            // 
            this.retenciónToolStripMenuItem.Name = "retenciónToolStripMenuItem";
            this.retenciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.retenciónToolStripMenuItem.Text = "Retención";
            // 
            // formaDePagoToolStripMenuItem
            // 
            this.formaDePagoToolStripMenuItem.Name = "formaDePagoToolStripMenuItem";
            this.formaDePagoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formaDePagoToolStripMenuItem.Text = "Forma de pago";
            this.formaDePagoToolStripMenuItem.Click += new System.EventHandler(this.formaDePagoToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // _Ctrl_Buscar1
            // 
            this._Ctrl_Buscar1.Dock = System.Windows.Forms.DockStyle.Top;
            this._Ctrl_Buscar1.Location = new System.Drawing.Point(0, 24);
            this._Ctrl_Buscar1.Name = "_Ctrl_Buscar1";
            this._Ctrl_Buscar1.Size = new System.Drawing.Size(847, 27);
            this._Ctrl_Buscar1.TabIndex = 38;
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 419);
            this.Controls.Add(this._Ctrl_Buscar1);
            this.Controls.Add(this._Pnl_Espera);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPadre";
            this.Text = "Sistema de Gestión V 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this._Pnl_Espera.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel _Pnl_Espera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        public CONTROLES._Ctrl_Buscar _Ctrl_Buscar1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosIVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

