namespace SistemaGestion.Mantenimientos
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSWIFT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMunicipios = new SistemaGestion.Clases.ComboBoxConBorde();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProvincias = new SistemaGestion.Clases.ComboBoxConBorde();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNifCif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorValidador = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.tabFormulario.Size = new System.Drawing.Size(781, 386);
            this.tabFormulario.TabIndex = 2;
            this.tabFormulario.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabFormulario_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgConsulta);
            this.tabPage1.Controls.Add(this.PnlConsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 360);
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
            this.ClienteId,
            this.Descripcion,
            this.Identificacion,
            this.Direccion,
            this.Telefono});
            this.dtgConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConsulta.Location = new System.Drawing.Point(3, 47);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.Size = new System.Drawing.Size(767, 310);
            this.dtgConsulta.TabIndex = 1;
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
            this.PnlConsulta.Location = new System.Drawing.Point(3, 3);
            this.PnlConsulta.Name = "PnlConsulta";
            this.PnlConsulta.Size = new System.Drawing.Size(767, 44);
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
            this.tabPage2.Size = new System.Drawing.Size(773, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtSWIFT);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtNombreBanco);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtIBAN);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNumeroCuenta);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTelefono2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefono1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCodigoPostal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbMunicipios);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbProvincias);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNifCif);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 335);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(131, 240);
            this.txtObservaciones.MaxLength = 200;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(539, 66);
            this.txtObservaciones.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Observaciones:";
            // 
            // txtSWIFT
            // 
            this.txtSWIFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSWIFT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSWIFT.Location = new System.Drawing.Point(432, 206);
            this.txtSWIFT.MaxLength = 30;
            this.txtSWIFT.Name = "txtSWIFT";
            this.txtSWIFT.Size = new System.Drawing.Size(238, 20);
            this.txtSWIFT.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(391, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "SWIFT:";
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBanco.Location = new System.Drawing.Point(131, 206);
            this.txtNombreBanco.MaxLength = 100;
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(254, 20);
            this.txtNombreBanco.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nombre del Banco:";
            // 
            // txtIBAN
            // 
            this.txtIBAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIBAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIBAN.Location = new System.Drawing.Point(432, 177);
            this.txtIBAN.MaxLength = 30;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(238, 20);
            this.txtIBAN.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "IBAN:";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroCuenta.Location = new System.Drawing.Point(131, 177);
            this.txtNumeroCuenta.MaxLength = 30;
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(254, 20);
            this.txtNumeroCuenta.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Número de Cuenta:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(506, 145);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(465, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Email:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono2.Location = new System.Drawing.Point(341, 145);
            this.txtTelefono2.MaxLength = 50;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(107, 20);
            this.txtTelefono2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefono 2°:";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono1.Location = new System.Drawing.Point(131, 145);
            this.txtTelefono1.MaxLength = 50;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(117, 20);
            this.txtTelefono1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefono 1°:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Location = new System.Drawing.Point(132, 115);
            this.txtCodigoPostal.MaxLength = 10;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(86, 20);
            this.txtCodigoPostal.TabIndex = 4;
            this.txtCodigoPostal.TextChanged += new System.EventHandler(this.txtCodigoPostal_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Código Postal:";
            // 
            // cmbMunicipios
            // 
            this.cmbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMunicipios.FormattingEnabled = true;
            this.cmbMunicipios.Location = new System.Drawing.Point(515, 112);
            this.cmbMunicipios.Name = "cmbMunicipios";
            this.cmbMunicipios.Size = new System.Drawing.Size(155, 21);
            this.cmbMunicipios.TabIndex = 6;
            this.cmbMunicipios.DropDown += new System.EventHandler(this.cmbMunicipios_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Municipio:";
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(306, 112);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(142, 21);
            this.cmbProvincias.TabIndex = 5;
            this.cmbProvincias.DropDown += new System.EventHandler(this.cmbProvincias_DropDown);
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Provincia:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(131, 85);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(539, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección:";
            // 
            // txtNifCif
            // 
            this.txtNifCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNifCif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNifCif.Location = new System.Drawing.Point(308, 33);
            this.txtNifCif.MaxLength = 15;
            this.txtNifCif.Name = "txtNifCif";
            this.txtNifCif.Size = new System.Drawing.Size(127, 20);
            this.txtNifCif.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIF / CIF:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCliente.Location = new System.Drawing.Point(131, 59);
            this.txtNombreCliente.MaxLength = 100;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(539, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre del Cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(131, 33);
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
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 386);
            this.Controls.Add(this.tabFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.FrmClientes_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClientes_FormClosing);
            this.Load += new System.EventHandler(this.FrmClientes_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNifCif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBoxConBorde cmbProvincias;
        private Clases.ComboBoxConBorde cmbMunicipios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSWIFT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider ErrorValidador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}