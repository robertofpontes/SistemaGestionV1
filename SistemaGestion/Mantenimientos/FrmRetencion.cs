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
    public partial class FrmRetencion : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmRetencion()
        {
            InitializeComponent();
            LlenarGrid("");
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
                dtgConsulta.DataSource = (from retenciones in SGPADatos.Retenciones where retenciones.Porcentaje.ToString().Contains(strBusqueda) select retenciones).ToList();
                tabFormulario.SelectedIndex = 0;
                dtgConsulta.Columns[0].Width = 80;
            }
            catch
            {
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtConsulta.Text);
        }

        private void FrmRetencion_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void FrmRetencion_Activated(object sender, EventArgs e)
        {
            ActivarBotonera();
        }
        public bool Eliminar()
        {
            try
            {
                if (!txtPorcentaje.Enabled)
                {
                    var oRetenciones = SGPADatos.Retenciones.FirstOrDefault(a => a.RetencionId.ToString() == txtCodigo.Text);
                    if (oRetenciones != null)
                    {
                        SGPADatos.Retenciones.Remove(oRetenciones);
                        SGPADatos.SaveChanges();
                        LlenarGrid("");
                        Inicializar();
                        strProceso = "A";
                        ActivarBotonera();
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
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
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
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
                if (txtPorcentaje.Enabled)
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
            txtPorcentaje.Enabled = bolActivo;
        }
        public bool Modificar()
        {
            bool bolEditado = false;
            if (ValidarGuardar())
            {
                var oRetenciones = SGPADatos.Retenciones.FirstOrDefault(a => a.RetencionId.ToString() == txtCodigo.Text);
                if (oRetenciones != null)
                {
                    oRetenciones.Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                    SGPADatos.SaveChanges();
                    LlenarGrid("");
                }
            }
            return bolEditado;
        }
        public void Inicializar()
        {
            strProceso = "";
            txtCodigo.Text = "";
            txtPorcentaje.Text = "";
            BloquearControles(false);
        }

        private void FrmRetencion_FormClosing(object sender, FormClosingEventArgs e)
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
        private bool ValidarGuardar()
        {
            ErrorValidador.Dispose();
            if (txtPorcentaje.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(txtPorcentaje,ErrorValidador, "El campo es obligatorio");
                return false;
            }
            return true;
        }
        public bool Guardar()
        {
            try
            {
                if (ValidarGuardar())
                {
                    var oRetenciones = new Retenciones();
                    oRetenciones.Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                    SGPADatos.Retenciones.Add(oRetenciones);
                    SGPADatos.SaveChanges();
                    LlenarGrid("");
                    Inicializar();
                    strProceso = "N";
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private void tabFormulario_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex != 0)
            {
                if (!txtPorcentaje.Enabled & txtCodigo.Text.Trim().Length == 0)
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
        private void CargarData(decimal dcmRetencionId)
        {
            try
            {
                var oRetenciones = SGPADatos.Retenciones.FirstOrDefault(a => a.RetencionId == dcmRetencionId);
                if (oRetenciones != null)
                {
                    txtPorcentaje.Text = oRetenciones.Porcentaje.ToString();
                    txtCodigo.Text = oRetenciones.RetencionId.ToString();
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
                    CargarData(Convert.ToDecimal(dtgConsulta.SelectedRows[0].Cells["RetencionId"].Value.ToString()));
                    strProceso = "E";
                    ActivarBotonera();
                    Cursor = Cursors.Default;
                    tabFormulario.SelectedIndex = 1;
                }
            }
            catch
            {

            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPorcentaje.Text.Length; i++)
            {
                if (txtPorcentaje.Text[i] == ',')
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
    }
}