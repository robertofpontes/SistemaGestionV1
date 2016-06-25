using SistemaGestion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.Mantenimientos
{
    public partial class FrmArticulos : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmArticulos()
        {
            InitializeComponent();
            LlenarGrid("");
            LlenarImpuestos();
        }
        private void LlenarImpuestos()
        {
            try
            {
                cmbIVA.DataSource = (from impuestos in SGPADatos.Impuestos
                                            select new { impuestos.ImpuestoId, impuestos.Porcentaje }).ToList();
                cmbIVA.DisplayMember = "Porcentaje";
                cmbIVA.ValueMember = "ImpuestoId";
                cmbIVA.SelectedIndex = -1;
            }
            catch
            {
            }
        }
        private void CambiarColorControles(Control Controles)
        {
            foreach (Control oControl in Controles.Controls)
            {
                if (oControl.Controls.Count > 0)
                {
                    CambiarColorControles(oControl);
                }
                new Clases.Utilidades(new Control[] { oControl }).ObtenerFoco();
            }
        }
        private void LlenarGrid(string strBusqueda)
        {
            try
            {
                dtgConsulta.AutoGenerateColumns = false;
                dtgConsulta.DataSource = (from articulos in SGPADatos.Articulos where (articulos.Referencia.Contains(strBusqueda) || articulos.Descripcion.Contains(strBusqueda) || articulos.ArticuloId.ToString().Contains(strBusqueda)) && articulos.EmpresaId == FrmPadre.dcmCodCompania select articulos).ToList();
                tabFormulario.SelectedIndex = 0;
                dtgConsulta.Columns[0].Width = 80;
            }
            catch
            {
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecio.Text.Length; i++)
            {
                if (txtPrecio.Text[i] == ',')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 44)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtConsulta.Text);
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            ActivarBotonera();
        }
        string strProceso = "G";
        public void ActivarBotonera()
        {
            CONTROLES._Ctrl_Buscar._frm_Formulario = this;
            CONTROLES._Ctrl_Buscar._Tb_Tab = tabFormulario;
            CONTROLES._Ctrl_Buscar._Bl_Especial = true;
            CONTROLES._Ctrl_Buscar._txt_ExistForm.Text = "";
            CONTROLES._Ctrl_Buscar._txt_ExistForm.Text = "Abierto";
            ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
            if (strProceso == "N")
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
            }
            if (strProceso == "A")
            {
                CONTROLES._Ctrl_Buscar._Bl_Modifi = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
            }
            if (strProceso == "E")
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = true;
            }
            if (strProceso == "M")
            {
                CONTROLES._Ctrl_Buscar._Bl_Modifi = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
            }
            if (strProceso == "")
            {
                if (txtDescripcion.Enabled)
                {
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = true;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = true;
                }
                else
                {
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                    ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
                }
            }
        }
        public void HabilitarControles()
        {
            BloquearControles(true);
            strProceso = "M";
        }
        private void BloquearControles(bool bolActivo)
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = bolActivo;
            txtPrecio.Enabled = bolActivo;
            cmbIVA.Enabled = bolActivo;
            txtReferencia.Enabled = bolActivo;
        }
        public void Inicializar()
        {
            strProceso = "";
            txtCodigo.Text = "";
            txtReferencia.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";            
            cmbIVA.SelectedIndex = -1;
            BloquearControles(false);
        }

        private void FrmArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            CONTROLES._Ctrl_Buscar._txt_text.Text = "";
            CONTROLES._Ctrl_Buscar._txt_ExistForm.Text = "Cerrado";
        }
        public void CrearNuevo()
        {
            Inicializar();
            BloquearControles(true);
            strProceso = "A";
            tabFormulario.SelectedIndex = 1;
            ActivarBotonera();
        }

        private void tabFormulario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex != 0)
            {
                if (!txtDescripcion.Enabled & txtCodigo.Text.Trim().Length == 0)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
            }
        }
        private void CargarData(decimal dcmArticulo)
        {
            try
            {
                var oArticulo = SGPADatos.Articulos.FirstOrDefault(a => a.ArticuloId == dcmArticulo && a.EmpresaId == FrmPadre.dcmCodCompania);
                if (oArticulo != null)
                {
                    txtDescripcion.Text = oArticulo.Descripcion;
                    txtPrecio.Text = oArticulo.Precio.ToString();
                    txtReferencia.Text = oArticulo.Referencia;                    
                    var oImpuesto = SGPADatos.Impuestos.FirstOrDefault(a => a.ImpuestoId == oArticulo.ImpuestoId);
                    Clases.Utilidades.AsignarValorCombo(cmbIVA, oImpuesto.Porcentaje.ToString());                    
                    txtCodigo.Text = oArticulo.ArticuloId.ToString();
                }
            }
            catch
            {
            }
        }

        private void dtgConsulta_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgConsulta.RowCount >= 0)
                {
                    Cursor = Cursors.WaitCursor;
                    Inicializar();
                    CargarData(Convert.ToDecimal(dtgConsulta.SelectedRows[0].Cells["ArticuloId"].Value.ToString()));
                    strProceso = "E";
                    ActivarBotonera();
                    Cursor = Cursors.Default;
                    tabFormulario.SelectedIndex = 1;
                }
            }
            catch (Exception ou)
            {

            }
        }
        private bool ValidarGuardar()
        {
            ErrorValidador.Dispose();
            if (txtDescripcion.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtDescripcion, "El campo es obligatorio");
                return false;
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtPrecio, "El campo es obligatorio");
                return false;
            }            
            if (txtReferencia.Text.Trim().Length == 0)
            {
                ErrorValidador.SetError(txtReferencia, "El campo es obligatorio");
                return false;
            }
            if (cmbIVA.SelectedValue == null)
            {
                ErrorValidador.SetError(cmbIVA, "El campo es obligatorio");
                return false;
            }
            return true;
        }
        public bool Modificar()
        {
            bool bolEditado = false;
            if (ValidarGuardar())
            {
                var oArticulo = SGPADatos.Articulos.FirstOrDefault(a => a.ArticuloId.ToString() == txtCodigo.Text && a.EmpresaId== FrmPadre.dcmCodCompania);
                if (oArticulo != null)
                {
                    oArticulo.Descripcion = txtDescripcion.Text;
                    oArticulo.Referencia = txtReferencia.Text;
                    oArticulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                    oArticulo.ImpuestoId = Convert.ToDecimal(cmbIVA.SelectedValue.ToString());
                    SGPADatos.SaveChanges();
                    LlenarGrid("");
                }
            }
            return bolEditado;
        }
        public bool Guardar()
        {
            try
            {
                if (ValidarGuardar())
                {
                    var oArticulo = new Articulos();
                    oArticulo.Descripcion = txtDescripcion.Text;
                    oArticulo.Referencia = txtReferencia.Text;
                    oArticulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                    oArticulo.EmpresaId = FrmPadre.dcmCodCompania;
                    oArticulo.ImpuestoId = Convert.ToDecimal(cmbIVA.SelectedValue.ToString());
                    SGPADatos.Articulos.Add(oArticulo);
                    SGPADatos.SaveChanges();
                    LlenarGrid("");
                    Inicializar();
                    strProceso = "N";
                    return true;
                }
                return false;
            }
            catch (Exception oException)
            {
                return false;
            }
        }

        private void cmbIVA_DropDown(object sender, EventArgs e)
        {
            LlenarImpuestos();
        }
    }
}
