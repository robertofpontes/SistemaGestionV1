namespace SistemaGestion.Ventas
{
    partial class FrmFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturas));
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgConsulta = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVAPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionPres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlConsulta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFinalizarFactura = new System.Windows.Forms.Button();
            this.btnVencimiento = new System.Windows.Forms.Button();
            this.txtNumeroPlazos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtRetencion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgBasesFacturas = new System.Windows.Forms.DataGridView();
            this.BaseTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVATotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseMasCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaRecargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkRecargo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgArticulosFacturas = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticuloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.txtArticuloId = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopiarAlbaranes = new System.Windows.Forms.Button();
            this.btnBuscarPresupuesto = new System.Windows.Forms.Button();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorValidador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbFormaPago = new SistemaGestion.Clases.ComboBoxConBorde();
            this.tabFormulario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.PnlConsulta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBasesFacturas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulosFacturas)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tabFormulario.Size = new System.Drawing.Size(878, 604);
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
            this.tabPage1.Size = new System.Drawing.Size(870, 578);
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
            this.Fecha,
            this.FacturaId,
            this.Identificacion,
            this.Nombre,
            this.Base,
            this.IVAPresupuesto,
            this.RetencionPres,
            this.Total,
            this.Finalizado});
            this.dtgConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConsulta.Location = new System.Drawing.Point(3, 47);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.Size = new System.Drawing.Size(864, 528);
            this.dtgConsulta.TabIndex = 1;
            this.dtgConsulta.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgConsulta_RowHeaderMouseDoubleClick);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FacturaId
            // 
            this.FacturaId.DataPropertyName = "FacturaId";
            this.FacturaId.HeaderText = "N°Factura";
            this.FacturaId.Name = "FacturaId";
            this.FacturaId.ReadOnly = true;
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "NIF / CIF";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCliente";
            this.Nombre.HeaderText = "Nombre Cliente";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Base
            // 
            this.Base.DataPropertyName = "Base";
            this.Base.HeaderText = "Base";
            this.Base.Name = "Base";
            this.Base.ReadOnly = true;
            // 
            // IVAPresupuesto
            // 
            this.IVAPresupuesto.DataPropertyName = "CuotaIVA";
            this.IVAPresupuesto.HeaderText = "IVA";
            this.IVAPresupuesto.Name = "IVAPresupuesto";
            this.IVAPresupuesto.ReadOnly = true;
            // 
            // RetencionPres
            // 
            this.RetencionPres.DataPropertyName = "CuotaRetencion";
            this.RetencionPres.HeaderText = "Retención";
            this.RetencionPres.Name = "RetencionPres";
            this.RetencionPres.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Finalizado
            // 
            this.Finalizado.DataPropertyName = "Finalizado";
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.ReadOnly = true;
            // 
            // PnlConsulta
            // 
            this.PnlConsulta.Controls.Add(this.label1);
            this.PnlConsulta.Controls.Add(this.txtConsulta);
            this.PnlConsulta.Controls.Add(this.btnConsultar);
            this.PnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlConsulta.Location = new System.Drawing.Point(3, 3);
            this.PnlConsulta.Name = "PnlConsulta";
            this.PnlConsulta.Size = new System.Drawing.Size(864, 44);
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
            this.tabPage2.Controls.Add(this.btnFinalizarFactura);
            this.tabPage2.Controls.Add(this.btnVencimiento);
            this.tabPage2.Controls.Add(this.txtNumeroPlazos);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dtgBasesFacturas);
            this.tabPage2.Controls.Add(this.chkRecargo);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cmbFormaPago);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarFactura
            // 
            this.btnFinalizarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarFactura.Image = global::SistemaGestion.Properties.Resources.check_1_icon;
            this.btnFinalizarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizarFactura.Location = new System.Drawing.Point(689, 543);
            this.btnFinalizarFactura.Name = "btnFinalizarFactura";
            this.btnFinalizarFactura.Size = new System.Drawing.Size(137, 22);
            this.btnFinalizarFactura.TabIndex = 31;
            this.btnFinalizarFactura.Text = "Finalizar Factura";
            this.btnFinalizarFactura.UseVisualStyleBackColor = true;
            this.btnFinalizarFactura.Click += new System.EventHandler(this.btnFinalizarFactura_Click);
            // 
            // btnVencimiento
            // 
            this.btnVencimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVencimiento.Image = global::SistemaGestion.Properties.Resources.calender_icon;
            this.btnVencimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVencimiento.Location = new System.Drawing.Point(543, 543);
            this.btnVencimiento.Name = "btnVencimiento";
            this.btnVencimiento.Size = new System.Drawing.Size(129, 22);
            this.btnVencimiento.TabIndex = 30;
            this.btnVencimiento.Text = "Vencimiento";
            this.btnVencimiento.UseVisualStyleBackColor = true;
            this.btnVencimiento.Click += new System.EventHandler(this.btnVencimiento_Click);
            // 
            // txtNumeroPlazos
            // 
            this.txtNumeroPlazos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroPlazos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroPlazos.Location = new System.Drawing.Point(496, 545);
            this.txtNumeroPlazos.MaxLength = 2;
            this.txtNumeroPlazos.Name = "txtNumeroPlazos";
            this.txtNumeroPlazos.Size = new System.Drawing.Size(38, 20);
            this.txtNumeroPlazos.TabIndex = 29;
            this.txtNumeroPlazos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPlazos_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 549);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "N° Plazos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Forma de Pago:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBase);
            this.groupBox3.Controls.Add(this.txtRetencion);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtIVA);
            this.groupBox3.Controls.Add(this.txtRecargo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(628, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 157);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(89, 122);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(86, 20);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Base:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total:";
            // 
            // txtBase
            // 
            this.txtBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase.Enabled = false;
            this.txtBase.Location = new System.Drawing.Point(89, 18);
            this.txtBase.Name = "txtBase";
            this.txtBase.ReadOnly = true;
            this.txtBase.Size = new System.Drawing.Size(86, 20);
            this.txtBase.TabIndex = 16;
            this.txtBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRetencion
            // 
            this.txtRetencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetencion.Enabled = false;
            this.txtRetencion.Location = new System.Drawing.Point(89, 96);
            this.txtRetencion.Name = "txtRetencion";
            this.txtRetencion.ReadOnly = true;
            this.txtRetencion.Size = new System.Drawing.Size(86, 20);
            this.txtRetencion.TabIndex = 22;
            this.txtRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "IVA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Retención:";
            // 
            // txtIVA
            // 
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(89, 44);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(86, 20);
            this.txtIVA.TabIndex = 18;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRecargo
            // 
            this.txtRecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecargo.Enabled = false;
            this.txtRecargo.Location = new System.Drawing.Point(89, 70);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.ReadOnly = true;
            this.txtRecargo.Size = new System.Drawing.Size(86, 20);
            this.txtRecargo.TabIndex = 20;
            this.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Recargo:";
            // 
            // dtgBasesFacturas
            // 
            this.dtgBasesFacturas.AllowUserToAddRows = false;
            this.dtgBasesFacturas.AllowUserToDeleteRows = false;
            this.dtgBasesFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBasesFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBasesFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBasesFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BaseTotal,
            this.IVATotal,
            this.CuotaIVA,
            this.BaseMasCuota,
            this.Recargo,
            this.CuotaRecargo,
            this.RetencionPercent,
            this.Retencion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBasesFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBasesFacturas.Location = new System.Drawing.Point(11, 382);
            this.dtgBasesFacturas.Name = "dtgBasesFacturas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBasesFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBasesFacturas.Size = new System.Drawing.Size(592, 155);
            this.dtgBasesFacturas.TabIndex = 14;
            this.dtgBasesFacturas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBasesPresupuestos_CellValueChanged);
            this.dtgBasesFacturas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgBasesPresupuestos_CurrentCellDirtyStateChanged);
            this.dtgBasesFacturas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgBasesPresupuestos_EditingControlShowing);
            // 
            // BaseTotal
            // 
            this.BaseTotal.HeaderText = "Base";
            this.BaseTotal.Name = "BaseTotal";
            this.BaseTotal.ReadOnly = true;
            // 
            // IVATotal
            // 
            this.IVATotal.HeaderText = "IVA";
            this.IVATotal.Name = "IVATotal";
            this.IVATotal.ReadOnly = true;
            // 
            // CuotaIVA
            // 
            this.CuotaIVA.HeaderText = "Cuota IVA";
            this.CuotaIVA.Name = "CuotaIVA";
            this.CuotaIVA.ReadOnly = true;
            // 
            // BaseMasCuota
            // 
            this.BaseMasCuota.HeaderText = "Base+Cuota";
            this.BaseMasCuota.Name = "BaseMasCuota";
            this.BaseMasCuota.ReadOnly = true;
            // 
            // Recargo
            // 
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            // 
            // CuotaRecargo
            // 
            this.CuotaRecargo.HeaderText = "Cuota Recargo";
            this.CuotaRecargo.Name = "CuotaRecargo";
            this.CuotaRecargo.ReadOnly = true;
            // 
            // RetencionPercent
            // 
            this.RetencionPercent.HeaderText = "% Retención";
            this.RetencionPercent.Name = "RetencionPercent";
            // 
            // Retencion
            // 
            this.Retencion.HeaderText = "Retención";
            this.Retencion.Name = "Retencion";
            this.Retencion.ReadOnly = true;
            // 
            // chkRecargo
            // 
            this.chkRecargo.AutoSize = true;
            this.chkRecargo.Location = new System.Drawing.Point(11, 350);
            this.chkRecargo.Name = "chkRecargo";
            this.chkRecargo.Size = new System.Drawing.Size(158, 17);
            this.chkRecargo.TabIndex = 0;
            this.chkRecargo.Text = "¿Recargo de Equivalencia?";
            this.chkRecargo.UseVisualStyleBackColor = true;
            this.chkRecargo.CheckedChanged += new System.EventHandler(this.chkRecargo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgArticulosFacturas);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(8, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 214);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículos";
            // 
            // dtgArticulosFacturas
            // 
            this.dtgArticulosFacturas.AllowUserToAddRows = false;
            this.dtgArticulosFacturas.AllowUserToDeleteRows = false;
            this.dtgArticulosFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgArticulosFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticulosFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.ArticuloId,
            this.Cantidad,
            this.Precio,
            this.Dcto,
            this.IVA,
            this.Importe});
            this.dtgArticulosFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgArticulosFacturas.Location = new System.Drawing.Point(3, 56);
            this.dtgArticulosFacturas.Name = "dtgArticulosFacturas";
            this.dtgArticulosFacturas.Size = new System.Drawing.Size(822, 155);
            this.dtgArticulosFacturas.TabIndex = 13;
            this.dtgArticulosFacturas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulosPresupuesto_CellEndEdit);
            this.dtgArticulosFacturas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgArticulosPresupuesto_CellValidating);
            this.dtgArticulosFacturas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulosPresupuesto_CellValueChanged);
            this.dtgArticulosFacturas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgArticulosPresupuesto_CurrentCellDirtyStateChanged);
            this.dtgArticulosFacturas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgArticulosPresupuesto_EditingControlShowing);
            this.dtgArticulosFacturas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgArticulosPresupuesto_RowHeaderMouseClick);
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Descripción";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // ArticuloId
            // 
            this.ArticuloId.HeaderText = "ArticuloId";
            this.ArticuloId.Name = "ArticuloId";
            this.ArticuloId.ReadOnly = true;
            this.ArticuloId.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Dcto
            // 
            this.Dcto.HeaderText = "Dcto";
            this.Dcto.MaxInputLength = 8;
            this.Dcto.Name = "Dcto";
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminarArticulo);
            this.panel1.Controls.Add(this.txtArticuloId);
            this.panel1.Controls.Add(this.btnBuscarArticulos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 40);
            this.panel1.TabIndex = 12;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Image = global::SistemaGestion.Properties.Resources.Close_2_icon;
            this.btnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(261, 8);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(137, 21);
            this.btnEliminarArticulo.TabIndex = 10;
            this.btnEliminarArticulo.Text = "Eliminar Artículo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Visible = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // txtArticuloId
            // 
            this.txtArticuloId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArticuloId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArticuloId.Enabled = false;
            this.txtArticuloId.Location = new System.Drawing.Point(123, 9);
            this.txtArticuloId.Name = "txtArticuloId";
            this.txtArticuloId.Size = new System.Drawing.Size(86, 20);
            this.txtArticuloId.TabIndex = 0;
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArticulos.Image = global::SistemaGestion.Properties.Resources._1468708463_11_Search;
            this.btnBuscarArticulos.Location = new System.Drawing.Point(215, 9);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(26, 20);
            this.btnBuscarArticulos.TabIndex = 1;
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            this.btnBuscarArticulos.Click += new System.EventHandler(this.btnBuscarArticulos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Artículos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopiarAlbaranes);
            this.groupBox1.Controls.Add(this.btnBuscarPresupuesto);
            this.groupBox1.Controls.Add(this.txtPresupuesto);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtNIF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscarClientes);
            this.groupBox1.Controls.Add(this.txtClienteId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumeroFactura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // btnCopiarAlbaranes
            // 
            this.btnCopiarAlbaranes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarAlbaranes.Image = global::SistemaGestion.Properties.Resources.Packing_1_icon;
            this.btnCopiarAlbaranes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopiarAlbaranes.Location = new System.Drawing.Point(694, 26);
            this.btnCopiarAlbaranes.Name = "btnCopiarAlbaranes";
            this.btnCopiarAlbaranes.Size = new System.Drawing.Size(113, 21);
            this.btnCopiarAlbaranes.TabIndex = 10;
            this.btnCopiarAlbaranes.Text = "Albaranes";
            this.btnCopiarAlbaranes.UseVisualStyleBackColor = true;
            this.btnCopiarAlbaranes.Click += new System.EventHandler(this.btnCopiarAlbaranes_Click);
            // 
            // btnBuscarPresupuesto
            // 
            this.btnBuscarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPresupuesto.Image = global::SistemaGestion.Properties.Resources._1468708463_11_Search;
            this.btnBuscarPresupuesto.Location = new System.Drawing.Point(620, 26);
            this.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto";
            this.btnBuscarPresupuesto.Size = new System.Drawing.Size(26, 20);
            this.btnBuscarPresupuesto.TabIndex = 18;
            this.btnBuscarPresupuesto.UseVisualStyleBackColor = true;
            this.btnBuscarPresupuesto.Click += new System.EventHandler(this.btnBuscarPresupuesto_Click);
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresupuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPresupuesto.Enabled = false;
            this.txtPresupuesto.Location = new System.Drawing.Point(528, 26);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(86, 20);
            this.txtPresupuesto.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(438, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "N° Presupuesto:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(275, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(107, 20);
            this.dtpFecha.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre del Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(493, 56);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(314, 20);
            this.txtNombreCliente.TabIndex = 14;
            // 
            // txtNIF
            // 
            this.txtNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNIF.Enabled = false;
            this.txtNIF.Location = new System.Drawing.Point(274, 56);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.ReadOnly = true;
            this.txtNIF.Size = new System.Drawing.Size(108, 20);
            this.txtNIF.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "NIF:";
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClientes.Image = global::SistemaGestion.Properties.Resources._1468708463_11_Search;
            this.btnBuscarClientes.Location = new System.Drawing.Point(187, 59);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(26, 20);
            this.btnBuscarClientes.TabIndex = 2;
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // txtClienteId
            // 
            this.txtClienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Location = new System.Drawing.Point(95, 59);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(86, 20);
            this.txtClienteId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroFactura.Enabled = false;
            this.txtNumeroFactura.Location = new System.Drawing.Point(95, 28);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(86, 20);
            this.txtNumeroFactura.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Factura:";
            // 
            // ErrorValidador
            // 
            this.ErrorValidador.ContainerControl = this;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(226, 544);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(202, 21);
            this.cmbFormaPago.TabIndex = 26;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 604);
            this.Controls.Add(this.tabFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFacturas";
            this.Text = "Facturas";
            this.Activated += new System.EventHandler(this.FrmPresupuestos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPresupuestos_FormClosing);
            this.Load += new System.EventHandler(this.FrmPresupuestos_Load);
            this.tabFormulario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
            this.PnlConsulta.ResumeLayout(false);
            this.PnlConsulta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBasesFacturas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulosFacturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarArticulos;
        private System.Windows.Forms.TextBox txtArticuloId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgArticulosFacturas;
        private System.Windows.Forms.CheckBox chkRecargo;
        private System.Windows.Forms.DataGridView dtgBasesFacturas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtRetencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtRecargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dcto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVATotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseMasCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaRecargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retencion;
        private System.Windows.Forms.ErrorProvider ErrorValidador;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private Clases.ComboBoxConBorde cmbFormaPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarPresupuesto;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnVencimiento;
        private System.Windows.Forms.TextBox txtNumeroPlazos;
        private System.Windows.Forms.Button btnFinalizarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVAPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionPres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalizado;
        private System.Windows.Forms.Button btnCopiarAlbaranes;
    }
}