namespace SistemaGestion.Mantenimientos
{
    partial class FrmEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresas));
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgConsulta = new System.Windows.Forms.DataGridView();
            this.FormaPagoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlConsulta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabFormulario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.PnlConsulta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormulario
            // 
            this.tabFormulario.Controls.Add(this.tabPage1);
            this.tabFormulario.Controls.Add(this.tabPage2);
            this.tabFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormulario.Location = new System.Drawing.Point(0, 0);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(707, 386);
            this.tabFormulario.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgConsulta);
            this.tabPage1.Controls.Add(this.PnlConsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgConsulta
            // 
            this.dtgConsulta.AllowUserToAddRows = false;
            this.dtgConsulta.AllowUserToDeleteRows = false;
            this.dtgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormaPagoId,
            this.Descripcion});
            this.dtgConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConsulta.Location = new System.Drawing.Point(3, 53);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.Size = new System.Drawing.Size(693, 304);
            this.dtgConsulta.TabIndex = 1;
            // 
            // FormaPagoId
            // 
            this.FormaPagoId.DataPropertyName = "FormaPagoId";
            this.FormaPagoId.HeaderText = "Código";
            this.FormaPagoId.Name = "FormaPagoId";
            this.FormaPagoId.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PnlConsulta
            // 
            this.PnlConsulta.Controls.Add(this.label1);
            this.PnlConsulta.Controls.Add(this.txtConsulta);
            this.PnlConsulta.Controls.Add(this.btnConsultar);
            this.PnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlConsulta.Location = new System.Drawing.Point(3, 3);
            this.PnlConsulta.Name = "PnlConsulta";
            this.PnlConsulta.Size = new System.Drawing.Size(693, 50);
            this.PnlConsulta.TabIndex = 0;
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
            this.txtConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(99, 56);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(218, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(99, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 386);
            this.Controls.Add(this.tabFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpresas";
            this.Text = "Empresas";
            this.tabFormulario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
            this.PnlConsulta.ResumeLayout(false);
            this.PnlConsulta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Panel PnlConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}