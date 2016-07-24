namespace SistemaGestion.Ventas
{
    partial class FrmBusquedaClientes
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
            this.dtgConsulta = new System.Windows.Forms.DataGridView();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlConsulta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.PnlConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConsulta
            // 
            this.dtgConsulta.AllowUserToAddRows = false;
            this.dtgConsulta.AllowUserToDeleteRows = false;
            this.dtgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.Descripcion,
            this.Identificacion,
            this.Direccion,
            this.Telefono});
            this.dtgConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConsulta.Location = new System.Drawing.Point(0, 44);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.Size = new System.Drawing.Size(633, 218);
            this.dtgConsulta.TabIndex = 3;
            this.dtgConsulta.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgConsulta_RowHeaderMouseDoubleClick);
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "Código";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "NombreCliente";
            this.Descripcion.HeaderText = "Nombre Cliente";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "NIF / CIF";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono1";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // PnlConsulta
            // 
            this.PnlConsulta.Controls.Add(this.label1);
            this.PnlConsulta.Controls.Add(this.txtConsulta);
            this.PnlConsulta.Controls.Add(this.btnConsultar);
            this.PnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlConsulta.Location = new System.Drawing.Point(0, 0);
            this.PnlConsulta.Name = "PnlConsulta";
            this.PnlConsulta.Size = new System.Drawing.Size(633, 44);
            this.PnlConsulta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto a Consultar:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsulta.Location = new System.Drawing.Point(125, 10);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(218, 20);
            this.txtConsulta.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(349, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmBusquedaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 262);
            this.Controls.Add(this.dtgConsulta);
            this.Controls.Add(this.PnlConsulta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusquedaClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
            this.PnlConsulta.ResumeLayout(false);
            this.PnlConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Panel PnlConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultar;
    }
}