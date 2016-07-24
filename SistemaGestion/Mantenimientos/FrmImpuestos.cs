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
    public partial class FrmImpuestos : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmImpuestos()
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
                dtgConsulta.DataSource = (from impuestos in SGPADatos.Impuestos where (impuestos.Porcentaje.ToString().Contains(strBusqueda)) select impuestos).ToList();
                tabFormulario.SelectedIndex = 0;
                dtgConsulta.Columns[0].Width = 80;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtConsulta.Text);
        }

        private void FrmImpuestos_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void FrmImpuestos_Activated(object sender, EventArgs e)
        {
            ActivarBotonera();
        }

        private void FrmImpuestos_FormClosing(object sender, FormClosingEventArgs e)
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
            txtRecargo.Enabled = bolActivo;
            txtPorcentaje.Enabled = bolActivo;
        }
        public void Inicializar()
        {
            strProceso = "";
            txtCodigo.Text = "";
            txtRecargo.Text = "";
            txtPorcentaje.Text = "";
            BloquearControles(false);
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
        private void CargarData(decimal dcmImpuestoId)
        {
            try
            {
                var oImpuesto= SGPADatos.Impuestos.FirstOrDefault(a => a.ImpuestoId == dcmImpuestoId);
                if (oImpuesto != null)
                {
                    txtPorcentaje.Text = oImpuesto.Porcentaje.ToString();
                    txtCodigo.Text = oImpuesto.ImpuestoId.ToString();
                    txtRecargo.Text= oImpuesto.RecargoEquivalencia.ToString();
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
                    CargarData(Convert.ToDecimal(dtgConsulta.SelectedRows[0].Cells["ImpuestoId"].Value.ToString()));
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
            if (txtPorcentaje.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(txtPorcentaje,ErrorValidador, "El campo es obligatorio");
                return false;
            }
            return true;
        }
        public bool Modificar()
        {
            bool bolEditado = false;
            decimal dcmRecargo = 0;
            if (txtRecargo.Text.Trim().Length > 0)
            {
                dcmRecargo=Convert.ToDecimal(txtRecargo.Text.Trim());
            }
            if (ValidarGuardar())
            {
                var oImpuesto = SGPADatos.Impuestos.FirstOrDefault(a => a.ImpuestoId.ToString() == txtCodigo.Text);
                if (oImpuesto != null)
                {
                    oImpuesto.Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                    oImpuesto.RecargoEquivalencia = dcmRecargo;
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
                decimal dcmRecargo = 0;
                if (txtRecargo.Text.Trim().Length > 0)
                {
                    dcmRecargo = Convert.ToDecimal(txtRecargo.Text.Trim());
                }
                if (ValidarGuardar())
                {
                    var oImpuesto = new Impuestos();
                    oImpuesto.Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                    oImpuesto.RecargoEquivalencia = dcmRecargo;
                    SGPADatos.Impuestos.Add(oImpuesto);
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

        private void txtRecargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtRecargo.Text.Length; i++)
            {
                if (txtRecargo.Text[i] == ',')
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
