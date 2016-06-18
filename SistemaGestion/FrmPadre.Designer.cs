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
            this._Pnl_Espera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
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
        private CONTROLES._Ctrl_Buscar _Ctrl_Buscar1;
    }
}

