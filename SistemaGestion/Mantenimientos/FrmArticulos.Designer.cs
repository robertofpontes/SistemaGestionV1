namespace SistemaGestion.Mantenimientos
{
    partial class FrmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgConsulta = new System.Windows.Forms.DataGridView();
            this.ArticuloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlConsulta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.ChkCodigoBarra = new System.Windows.Forms.CheckBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorValidador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbUnidadManejo = new SistemaGestion.Clases.ComboBoxConBorde();
            this.cmbIVA = new SistemaGestion.Clases.ComboBoxConBorde();
            this.tabFormulario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.PnlConsulta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidador)).BeginInit();
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
            this.tabFormulario.Size = new System.Drawing.Size(589, 230);
            this.tabFormulario.TabIndex = 3;
            this.tabFormulario.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabFormulario_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgConsulta);
            this.tabPage1.Controls.Add(this.PnlConsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 204);
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
            this.ArticuloId,
            this.Referencia,
            this.Descripcion});
            this.dtgConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConsulta.Location = new System.Drawing.Point(3, 47);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.Size = new System.Drawing.Size(575, 154);
            this.dtgConsulta.TabIndex = 1;
            this.dtgConsulta.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgConsulta_RowHeaderMouseDoubleClick);
            // 
            // ArticuloId
            // 
            this.ArticuloId.DataPropertyName = "ArticuloId";
            this.ArticuloId.HeaderText = "Código";
            this.ArticuloId.Name = "ArticuloId";
            this.ArticuloId.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
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
            this.PnlConsulta.Size = new System.Drawing.Size(575, 44);
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
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbUnidadManejo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoBarra);
            this.groupBox1.Controls.Add(this.ChkCodigoBarra);
            this.groupBox1.Controls.Add(this.txtReferencia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbIVA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Artículo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Código Barra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Unidad Manejo:";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarra.Enabled = false;
            this.txtCodigoBarra.Location = new System.Drawing.Point(233, 112);
            this.txtCodigoBarra.MaxLength = 10;
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.ReadOnly = true;
            this.txtCodigoBarra.Size = new System.Drawing.Size(234, 20);
            this.txtCodigoBarra.TabIndex = 35;
            // 
            // ChkCodigoBarra
            // 
            this.ChkCodigoBarra.AutoSize = true;
            this.ChkCodigoBarra.Location = new System.Drawing.Point(116, 112);
            this.ChkCodigoBarra.Name = "ChkCodigoBarra";
            this.ChkCodigoBarra.Size = new System.Drawing.Size(108, 17);
            this.ChkCodigoBarra.TabIndex = 34;
            this.ChkCodigoBarra.Text = "Código de Barra?";
            this.ChkCodigoBarra.UseVisualStyleBackColor = true;
            this.ChkCodigoBarra.CheckedChanged += new System.EventHandler(this.ChkCodigoBarra_CheckedChanged);
            // 
            // txtReferencia
            // 
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Enabled = false;
            this.txtReferencia.Location = new System.Drawing.Point(298, 33);
            this.txtReferencia.MaxLength = 10;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(86, 20);
            this.txtReferencia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Referencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "IVA:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Location = new System.Drawing.Point(116, 85);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(117, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(116, 59);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(351, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(116, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // ErrorValidador
            // 
            this.ErrorValidador.ContainerControl = this;
            // 
            // cmbUnidadManejo
            // 
            this.cmbUnidadManejo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadManejo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnidadManejo.FormattingEnabled = true;
            this.cmbUnidadManejo.Location = new System.Drawing.Point(116, 138);
            this.cmbUnidadManejo.Name = "cmbUnidadManejo";
            this.cmbUnidadManejo.Size = new System.Drawing.Size(217, 21);
            this.cmbUnidadManejo.TabIndex = 37;
            this.cmbUnidadManejo.DropDown += new System.EventHandler(this.cmbUnidadManejo_DropDown);
            // 
            // cmbIVA
            // 
            this.cmbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIVA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbIVA.FormattingEnabled = true;
            this.cmbIVA.Location = new System.Drawing.Point(298, 85);
            this.cmbIVA.Name = "cmbIVA";
            this.cmbIVA.Size = new System.Drawing.Size(169, 21);
            this.cmbIVA.TabIndex = 4;
            this.cmbIVA.DropDown += new System.EventHandler(this.cmbIVA_DropDown);
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 230);
            this.Controls.Add(this.tabFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmArticulos";
            this.Text = "Artículos";
            this.Activated += new System.EventHandler(this.FrmArticulos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmArticulos_FormClosing);
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.tabFormulario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
            this.PnlConsulta.ResumeLayout(false);
            this.PnlConsulta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgConsulta;
        private System.Windows.Forms.Panel PnlConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.ComboBoxConBorde cmbIVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ErrorValidador;
        private System.Windows.Forms.Label label9;
        private Clases.ComboBoxConBorde cmbUnidadManejo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.CheckBox ChkCodigoBarra;
    }
}