﻿using SistemaGestion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class FrmPadre : Form
    {
        public static string strNombreSistema = "Sistema de Gestión SGPA V.";
        public static string strVersionSistema = "1.0";
        public static string strEmpresa = "";
        public static string strCodCompania = "";
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmPadre()
        {
            InitializeComponent();
            this.Text = strNombreSistema + strVersionSistema;
        }
        public FrmPadre(string strCompania)
        {
            InitializeComponent();
            strEmpresa = strCompania;
            decimal dcmEmpresa = Convert.ToDecimal(strEmpresa);
            var oEmpresa = SGPADatos.Empresas.FirstOrDefault(a => a.EmpresaId == dcmEmpresa);
            this.Text = strNombreSistema + strVersionSistema + " - "+oEmpresa.NombreEmpresa;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmEmpresas frmEmpresa = new Mantenimientos.FrmEmpresas();
            frmEmpresa.MdiParent = this;
            frmEmpresa.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", strNombreSistema + strVersionSistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void formaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmFormaPago frmFormaPago = new Mantenimientos.FrmFormaPago();
            frmFormaPago.MdiParent = this;
            frmFormaPago.Show();
        }
    }
}
