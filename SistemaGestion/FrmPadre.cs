using SistemaGestion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public static decimal dcmCodCompania;
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
            dcmCodCompania = dcmEmpresa;
            strCodCompania = strEmpresa;
            var oEmpresa = SGPADatos.Empresas.FirstOrDefault(a => a.EmpresaId == dcmEmpresa);
            this.Text = strNombreSistema + strVersionSistema + " - "+oEmpresa.NombreEmpresa;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmClientes frmClientes = new Mantenimientos.FrmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
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

        private void retenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmRetencion frmRetencion = new Mantenimientos.FrmRetencion();
            frmRetencion.MdiParent = this;
            frmRetencion.Show();
        }

        private void configurarImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument oPrintDocument = new PrintDocument();
            oPrintDocument.PrintPage += Pd_PrintPage;
            //pd.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog pPrintDialog = new PrintDialog();
            pPrintDialog.Document = oPrintDocument;
            bool bolAgregar = false;
            var oConfiguracionSistema = SGPADatos.SistemaConfiguracion.ToList();
            SistemaConfiguracion oSistemaConfiguracion = null;
            if (oConfiguracionSistema.Count == 0)
            {
                oSistemaConfiguracion = new SistemaConfiguracion();
                bolAgregar = true;
            }
            else
            {
                oSistemaConfiguracion = oConfiguracionSistema.First();
                pPrintDialog.PrinterSettings.PrinterName = oSistemaConfiguracion.NombreImpresora;
            }           
            if (pPrintDialog.ShowDialog() == DialogResult.OK)
            {
                string strNombreImpresora=pPrintDialog.PrinterSettings.PrinterName;
                if (bolAgregar)
                {
                    oSistemaConfiguracion.NombreImpresora = strNombreImpresora;
                    SGPADatos.SistemaConfiguracion.Add(oSistemaConfiguracion);
                    SGPADatos.SaveChanges();                    
                }
                else
                {
                    oSistemaConfiguracion.NombreImpresora = strNombreImpresora;
                    SGPADatos.SaveChanges();
                }
                MessageBox.Show("Configuración almacenada correctamente", strNombreSistema + strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Print Cancelled");
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.FrmProveedores frmProveedor = new Mantenimientos.FrmProveedores();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();
        }
    }
}
