﻿namespace SistemaGestion.Ventas
{
    partial class FrmPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresupuestos));
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgConsulta = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresupuestoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVAPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionPres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlConsulta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.dtgBasesPresupuestos = new System.Windows.Forms.DataGridView();
            this.chkRecargo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgArticulosPresupuesto = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticuloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtArticuloId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroPresupuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BaseTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVATotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseMasCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaRecargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetencionPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorValidador = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.lblEliminarArticulo = new System.Windows.Forms.Label();
            this.tabFormulario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.PnlConsulta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBasesPresupuestos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulosPresupuesto)).BeginInit();
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
            this.tabFormulario.Size = new System.Drawing.Size(878, 581);
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
            this.tabPage1.Size = new System.Drawing.Size(870, 555);
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
            this.PresupuestoId,
            this.Identificacion,
            this.Nombre,
            this.Base,
            this.IVAPresupuesto,
            this.RetencionPres,
            this.Total});
            this.dtgConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConsulta.Location = new System.Drawing.Point(3, 47);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.Size = new System.Drawing.Size(864, 505);
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
            // PresupuestoId
            // 
            this.PresupuestoId.DataPropertyName = "PresupuestoId";
            this.PresupuestoId.HeaderText = "N° Presupuesto";
            this.PresupuestoId.Name = "PresupuestoId";
            this.PresupuestoId.ReadOnly = true;
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
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dtgBasesPresupuestos);
            this.tabPage2.Controls.Add(this.chkRecargo);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // dtgBasesPresupuestos
            // 
            this.dtgBasesPresupuestos.AllowUserToAddRows = false;
            this.dtgBasesPresupuestos.AllowUserToDeleteRows = false;
            this.dtgBasesPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBasesPresupuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBasesPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBasesPresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgBasesPresupuestos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBasesPresupuestos.Location = new System.Drawing.Point(11, 382);
            this.dtgBasesPresupuestos.Name = "dtgBasesPresupuestos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBasesPresupuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBasesPresupuestos.Size = new System.Drawing.Size(592, 155);
            this.dtgBasesPresupuestos.TabIndex = 14;
            this.dtgBasesPresupuestos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBasesPresupuestos_CellValueChanged);
            this.dtgBasesPresupuestos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgBasesPresupuestos_CurrentCellDirtyStateChanged);
            this.dtgBasesPresupuestos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgBasesPresupuestos_EditingControlShowing);
            // 
            // chkRecargo
            // 
            this.chkRecargo.AutoSize = true;
            this.chkRecargo.Location = new System.Drawing.Point(11, 347);
            this.chkRecargo.Name = "chkRecargo";
            this.chkRecargo.Size = new System.Drawing.Size(158, 17);
            this.chkRecargo.TabIndex = 0;
            this.chkRecargo.Text = "¿Recargo de Equivalencia?";
            this.chkRecargo.UseVisualStyleBackColor = true;
            this.chkRecargo.CheckedChanged += new System.EventHandler(this.chkRecargo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgArticulosPresupuesto);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(8, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 214);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículos";
            // 
            // dtgArticulosPresupuesto
            // 
            this.dtgArticulosPresupuesto.AllowUserToAddRows = false;
            this.dtgArticulosPresupuesto.AllowUserToDeleteRows = false;
            this.dtgArticulosPresupuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgArticulosPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticulosPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.ArticuloId,
            this.Cantidad,
            this.Precio,
            this.Dcto,
            this.IVA,
            this.Importe});
            this.dtgArticulosPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgArticulosPresupuesto.Location = new System.Drawing.Point(3, 56);
            this.dtgArticulosPresupuesto.Name = "dtgArticulosPresupuesto";
            this.dtgArticulosPresupuesto.Size = new System.Drawing.Size(822, 155);
            this.dtgArticulosPresupuesto.TabIndex = 13;
            this.dtgArticulosPresupuesto.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulosPresupuesto_CellEndEdit);
            this.dtgArticulosPresupuesto.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgArticulosPresupuesto_CellValidating);
            this.dtgArticulosPresupuesto.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulosPresupuesto_CellValueChanged);
            this.dtgArticulosPresupuesto.CurrentCellDirtyStateChanged += new System.EventHandler(this.dtgArticulosPresupuesto_CurrentCellDirtyStateChanged);
            this.dtgArticulosPresupuesto.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgArticulosPresupuesto_EditingControlShowing);
            this.dtgArticulosPresupuesto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgArticulosPresupuesto_RowHeaderMouseClick);
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
            this.panel1.Controls.Add(this.lblEliminarArticulo);
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
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtNIF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscarClientes);
            this.groupBox1.Controls.Add(this.txtClienteId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumeroPresupuesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 61);
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
            this.txtNombreCliente.Location = new System.Drawing.Point(524, 56);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(286, 20);
            this.txtNombreCliente.TabIndex = 14;
            // 
            // txtNIF
            // 
            this.txtNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNIF.Enabled = false;
            this.txtNIF.Location = new System.Drawing.Point(305, 56);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.ReadOnly = true;
            this.txtNIF.Size = new System.Drawing.Size(108, 20);
            this.txtNIF.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "NIF:";
            // 
            // txtClienteId
            // 
            this.txtClienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Location = new System.Drawing.Point(126, 59);
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
            this.label4.Location = new System.Drawing.Point(259, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // txtNumeroPresupuesto
            // 
            this.txtNumeroPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroPresupuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroPresupuesto.Enabled = false;
            this.txtNumeroPresupuesto.Location = new System.Drawing.Point(126, 28);
            this.txtNumeroPresupuesto.Name = "txtNumeroPresupuesto";
            this.txtNumeroPresupuesto.ReadOnly = true;
            this.txtNumeroPresupuesto.Size = new System.Drawing.Size(86, 20);
            this.txtNumeroPresupuesto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Presupuesto:";
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
            // ErrorValidador
            // 
            this.ErrorValidador.ContainerControl = this;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(306, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(107, 20);
            this.dtpFecha.TabIndex = 16;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Image = global::SistemaGestion.Properties.Resources.Close_2_icon;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(420, 9);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(27, 20);
            this.btnEliminarArticulo.TabIndex = 10;
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Visible = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
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
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClientes.Image = global::SistemaGestion.Properties.Resources._1468708463_11_Search;
            this.btnBuscarClientes.Location = new System.Drawing.Point(218, 59);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(26, 20);
            this.btnBuscarClientes.TabIndex = 2;
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // lblEliminarArticulo
            // 
            this.lblEliminarArticulo.AutoSize = true;
            this.lblEliminarArticulo.Location = new System.Drawing.Point(265, 13);
            this.lblEliminarArticulo.Name = "lblEliminarArticulo";
            this.lblEliminarArticulo.Size = new System.Drawing.Size(151, 13);
            this.lblEliminarArticulo.TabIndex = 11;
            this.lblEliminarArticulo.Text = "Eliminar artículo seleccionado:";
            this.lblEliminarArticulo.Visible = false;
            // 
            // FrmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 581);
            this.Controls.Add(this.tabFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPresupuestos";
            this.Text = "Presupuestos";
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgBasesPresupuestos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulosPresupuesto)).EndInit();
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
        private System.Windows.Forms.TextBox txtNumeroPresupuesto;
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
        private System.Windows.Forms.DataGridView dtgArticulosPresupuesto;
        private System.Windows.Forms.CheckBox chkRecargo;
        private System.Windows.Forms.DataGridView dtgBasesPresupuestos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresupuestoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVAPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetencionPres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
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
        private System.Windows.Forms.Label lblEliminarArticulo;
    }
}