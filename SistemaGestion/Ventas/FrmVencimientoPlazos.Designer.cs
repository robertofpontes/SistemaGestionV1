namespace SistemaGestion.Ventas
{
    partial class FrmVencimientoPlazos
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
            this.dtgVencimientos = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.PlazoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCambiarFecha = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAceptarCambiarFecha = new System.Windows.Forms.Button();
            this.btnCancelarCambiarFecha = new System.Windows.Forms.Button();
            this.btnVencimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVencimientos)).BeginInit();
            this.pnlCambiarFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVencimientos
            // 
            this.dtgVencimientos.AllowUserToAddRows = false;
            this.dtgVencimientos.AllowUserToDeleteRows = false;
            this.dtgVencimientos.AllowUserToOrderColumns = true;
            this.dtgVencimientos.AllowUserToResizeColumns = false;
            this.dtgVencimientos.AllowUserToResizeRows = false;
            this.dtgVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVencimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlazoId,
            this.Fecha,
            this.Importe});
            this.dtgVencimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgVencimientos.Location = new System.Drawing.Point(0, 0);
            this.dtgVencimientos.Name = "dtgVencimientos";
            this.dtgVencimientos.Size = new System.Drawing.Size(341, 175);
            this.dtgVencimientos.TabIndex = 0;
            this.dtgVencimientos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgVencimientos_RowHeaderMouseClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(123, 192);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 22);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // PlazoId
            // 
            this.PlazoId.HeaderText = "PlazoId";
            this.PlazoId.Name = "PlazoId";
            this.PlazoId.ReadOnly = true;
            this.PlazoId.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // pnlCambiarFecha
            // 
            this.pnlCambiarFecha.Controls.Add(this.btnCancelarCambiarFecha);
            this.pnlCambiarFecha.Controls.Add(this.btnAceptarCambiarFecha);
            this.pnlCambiarFecha.Controls.Add(this.dtpFecha);
            this.pnlCambiarFecha.Location = new System.Drawing.Point(74, 52);
            this.pnlCambiarFecha.Name = "pnlCambiarFecha";
            this.pnlCambiarFecha.Size = new System.Drawing.Size(173, 78);
            this.pnlCambiarFecha.TabIndex = 34;
            this.pnlCambiarFecha.Visible = false;
            this.pnlCambiarFecha.VisibleChanged += new System.EventHandler(this.pnlCambiarFecha_VisibleChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(19, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(133, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // btnAceptarCambiarFecha
            // 
            this.btnAceptarCambiarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCambiarFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarCambiarFecha.Location = new System.Drawing.Point(19, 43);
            this.btnAceptarCambiarFecha.Name = "btnAceptarCambiarFecha";
            this.btnAceptarCambiarFecha.Size = new System.Drawing.Size(68, 22);
            this.btnAceptarCambiarFecha.TabIndex = 33;
            this.btnAceptarCambiarFecha.Text = "Aceptar";
            this.btnAceptarCambiarFecha.UseVisualStyleBackColor = true;
            this.btnAceptarCambiarFecha.Click += new System.EventHandler(this.btnAceptarCambiarFecha_Click);
            // 
            // btnCancelarCambiarFecha
            // 
            this.btnCancelarCambiarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCambiarFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCambiarFecha.Location = new System.Drawing.Point(93, 43);
            this.btnCancelarCambiarFecha.Name = "btnCancelarCambiarFecha";
            this.btnCancelarCambiarFecha.Size = new System.Drawing.Size(59, 22);
            this.btnCancelarCambiarFecha.TabIndex = 34;
            this.btnCancelarCambiarFecha.Text = "Cancelar";
            this.btnCancelarCambiarFecha.UseVisualStyleBackColor = true;
            this.btnCancelarCambiarFecha.Click += new System.EventHandler(this.btnCancelarCambiarFecha_Click);
            // 
            // btnVencimiento
            // 
            this.btnVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVencimiento.Image = global::SistemaGestion.Properties.Resources.calender_icon;
            this.btnVencimiento.Location = new System.Drawing.Point(12, 192);
            this.btnVencimiento.Name = "btnVencimiento";
            this.btnVencimiento.Size = new System.Drawing.Size(34, 22);
            this.btnVencimiento.TabIndex = 35;
            this.btnVencimiento.UseVisualStyleBackColor = true;
            this.btnVencimiento.Visible = false;
            this.btnVencimiento.Click += new System.EventHandler(this.btnVencimiento_Click);
            // 
            // FrmVencimientoPlazos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 235);
            this.Controls.Add(this.btnVencimiento);
            this.Controls.Add(this.pnlCambiarFecha);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtgVencimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVencimientoPlazos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmVencimientoPlazos";
            this.Load += new System.EventHandler(this.FrmVencimientoPlazos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVencimientos)).EndInit();
            this.pnlCambiarFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVencimientos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlazoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Panel pnlCambiarFecha;
        private System.Windows.Forms.Button btnCancelarCambiarFecha;
        private System.Windows.Forms.Button btnAceptarCambiarFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnVencimiento;
    }
}