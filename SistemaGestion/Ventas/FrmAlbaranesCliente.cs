using SistemaGestion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.Ventas
{
    public partial class FrmAlbaranesCliente : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmAlbaranesCliente()
        {
            InitializeComponent();
            LlenarGrid(txtConsulta.Text);
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

        private void FrmAlbaranesCliente_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void FrmAlbaranesCliente_Activated(object sender, EventArgs e)
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
                if (chkRecargo.Enabled)
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
            if (bolAlbaranFinalizada)
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = true;
                MessageBox.Show("Disculpe, el albaran fue finalizado y no puede ser editado", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                strProceso = "M";
            }
        }
        private void BloquearControles(bool bolActivo)
        {
            if (bolAlbaranFinalizada)
            {
                bolActivo = false;
            }
            btnFinalizarAlbaran.Enabled = bolActivo;
            chkRecargo.Enabled = bolActivo;
            dtpFecha.Enabled = bolActivo;
            btnBuscarArticulos.Enabled = bolActivo;
            btnBuscarClientes.Enabled = bolActivo;
            lblEliminarArticulo.Enabled = bolActivo;
            btnEliminarArticulo.Enabled = bolActivo;
            lblEliminarArticulo.Visible = false;
            btnEliminarArticulo.Visible = false;
            dtgArticulosAlbaran.Enabled = bolActivo;
            dtgBasesAlbaran.Enabled = bolActivo;            
        }
        public void Inicializar()
        {
            SGPADatos.Dispose();
            dtgArticulosAlbaran.CellValidating -= dtgArticulosAlbaran_CellValidating;
            dtgArticulosAlbaran.Rows.Clear();
            dtgArticulosAlbaran.CellValidating += dtgArticulosAlbaran_CellValidating;
            dtgBasesAlbaran.Rows.Clear();
            strProceso = "";
            txtBase.Text = "";
            txtIVA.Text = "";
            txtRecargo.Text = "";
            txtRetencion.Text = "";
            txtTotal.Text = "";
            txtClienteId.Text = "";
            txtNumeroAlbaran.Text = "";
            txtNombreCliente.Text = "";
            txtNIF.Text = "";
            lblEliminarArticulo.Visible = false;
            btnEliminarArticulo.Visible = false;
            chkRecargo.Checked = false;            
            BloquearControles(false);
            SGPADatos = new SGPAEntities();
        }
        

        private void FrmAlbaranesCliente_FormClosing(object sender, FormClosingEventArgs e)
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
                if (!chkRecargo.Enabled & txtNumeroAlbaran.Text.Trim().Length == 0)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtConsulta.Text);
        }
        private void LlenarGrid(string strBusqueda)
        {
            try
            {
                dtgConsulta.AutoGenerateColumns = false;
                var oDatos = (from albaranes in SGPADatos.vw_AlbaranesClientesConsulta where (albaranes.NombreCliente.Contains(strBusqueda) || albaranes.AlbaranId.ToString().Contains(strBusqueda)) && albaranes.EmpresaId == FrmPadre.dcmCodCompania select albaranes).OrderByDescending(a => a.Fecha).AsNoTracking();
                dtgConsulta.DataSource = oDatos.ToList();              
                tabFormulario.SelectedIndex = 0;
                dtgConsulta.Columns[0].Width = 80;
            }
            catch
            {
            }
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                string strClienteId = "";
                FrmBusquedaClientes frmBusquedaClientes = new FrmBusquedaClientes();
                frmBusquedaClientes.ShowDialog();
                strClienteId = frmBusquedaClientes.strClienteId;
                if (strClienteId.Trim() != "")
                {
                    var oCliente = SGPADatos.Clientes.FirstOrDefault(a => a.EmpresaId == FrmPadre.dcmCodCompania && a.ClienteId.ToString() == strClienteId);
                    if (oCliente != null)
                    {
                        txtNombreCliente.Text = oCliente.NombreCliente;
                        txtNIF.Text = oCliente.Identificacion;
                        txtClienteId.Text = strClienteId;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para continuar", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
            }
        }
        private bool BuscarEnGrid(string strValor)
        {
            bool bolExiste = false;
            //int rowIndex = -1;
            foreach (DataGridViewRow dtgFilas in dtgArticulosAlbaran.Rows)
            {
                if (dtgFilas.Cells["ArticuloId"].Value != null)
                {
                    if (dtgFilas.Cells["ArticuloId"].Value.ToString().Equals(strValor))
                    {
                        //rowIndex = dtgFilas.Index;
                        bolExiste = true;
                        break;
                    }
                }
            }
            return bolExiste;
        }
        int intRowIndexBases = -1;
        private void EliminarGridBases(List<Clases.BasesImpuestosDistinct> oBasesImpuestosDistinct)
        {
            foreach (DataGridViewRow dtgFilas in dtgBasesAlbaran.Rows)
            {
                if (dtgFilas.Cells["IVATotal"].Value != null)
                {
                    var oExiste = oBasesImpuestosDistinct.Where(a => a.IVA.ToString() == dtgFilas.Cells["IVATotal"].Value.ToString());
                    if (oExiste.Count()==0)
                    {
                        //Se Elimina la fila en el grid de bases
                        dtgBasesAlbaran.Rows.RemoveAt(dtgFilas.Index);
                    }
                }
            }
        }
        private bool BuscarEnGridBases(string strValor)
        {
            bool bolExiste = false;
            //int rowIndex = -1;
            foreach (DataGridViewRow dtgFilas in dtgBasesAlbaran.Rows)
            {
                if (dtgFilas.Cells["IVATotal"].Value != null)
                {
                    if (dtgFilas.Cells["IVATotal"].Value.ToString().Equals(strValor))
                    {
                        intRowIndexBases = dtgFilas.Index;
                        bolExiste = true;
                        break;
                    }
                }
            }
            return bolExiste;
        }
        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNIF.Text.Trim() == "")
                {
                    MessageBox.Show("Debe seleccionar un cliente para continuar", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string strProductoId = "";
                    FrmBusquedaArticulos frmBusquedaArticulos = new FrmBusquedaArticulos();
                    frmBusquedaArticulos.ShowDialog();
                    strProductoId = frmBusquedaArticulos.strProductoId;
                    if (strProductoId.Trim() != "")
                    {
                        var oArticulo = SGPADatos.Articulos.FirstOrDefault(a => a.EmpresaId == FrmPadre.dcmCodCompania && a.ArticuloId.ToString() == strProductoId);
                        if (oArticulo != null)
                        {
                            if (!BuscarEnGrid(oArticulo.ArticuloId.ToString()))
                            {
                                //Se ingresa una nueva fila al grid 
                                //DataGridViewRow dtrFila = (DataGridViewRow)dtgArticulosPresupuesto.Rows[]
                                //dtrFila.Cells["NombreProducto"].Value = oArticulo.Descripcion.ToString();
                                //dtrFila.Cells["Precio"].Value = oArticulo.Precio.ToString();
                                //dtrFila.Cells["Cantidad"].Value = "0";
                                //dtrFila.Cells["Importe"].Value = "0";
                                dtgArticulosAlbaran.Rows.Add(oArticulo.Descripcion.ToString(), oArticulo.ArticuloId.ToString(), "0", string.Format("{0:n}", oArticulo.Precio), "", string.Format("{0:n}", oArticulo.Impuestos.Porcentaje), "0");
                                LlenarGridBases();
                            }
                            else
                            {
                                MessageBox.Show("El artículo ya existe en el albaran actual", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un artículo para continuar", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
            }
        }

        

        private void dtgArticulosAlbaran_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        private void dtgArticulosAlbaran_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void dtgArticulosAlbaran_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgArticulosAlbaran.IsCurrentCellDirty)
            {
                dtgArticulosAlbaran.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtgArticulosAlbaran_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal dcmDescuento = 0;
                decimal dcmCantidad = 0;
                decimal dcmPrecio = 0;
                decimal dcmImporte = 0;
                if (dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Cantidad"].Value != null)
                {
                    if (dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString() != "")
                    {
                        dcmCantidad = Convert.ToDecimal(dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    }
                }
                if (dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Precio"].Value.ToString() != "")
                {
                    dcmPrecio = Convert.ToDecimal(dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Precio"].Value);
                }
                if (dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Dcto"].Value != null)
                {
                    if (dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Dcto"].Value.ToString() != "")
                    {
                        dcmDescuento = Convert.ToDecimal(dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Dcto"].Value);
                    }
                }
                dcmImporte = (dcmCantidad * dcmPrecio) - (dcmCantidad * dcmPrecio * (dcmDescuento / 100));
                if (e.ColumnIndex == 2 || e.ColumnIndex == 4)
                {
                    //Se debe validar inventario
                    if (txtNumeroAlbaran.Text == "")
                    {
                        //Albaran nueva
                        string strArticulo = dtgArticulosAlbaran.Rows[e.RowIndex].Cells["ArticuloId"].Value.ToString();
                        var oArticulosInventario = SGPADatos.vw_ArticulosConsulta.FirstOrDefault(a => a.ArticuloId.ToString() == strArticulo && a.EmpresaId == FrmPadre.dcmCodCompania);
                        if (oArticulosInventario != null)
                        {
                            if ((oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida) < dcmCantidad)
                            {
                                dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Importe"].Value = "0,00";
                                dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Cantidad"].Value = "0";
                                dcmImporte = 0;
                                dcmCantidad = 0;
                                MessageBox.Show("No puede ingresar mas de " + (oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida).ToString() + " Unds del artículo " + oArticulosInventario.Descripcion, FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        string strArticulo = dtgArticulosAlbaran.Rows[e.RowIndex].Cells["ArticuloId"].Value.ToString();
                        var oDetalleAlbaran = SGPADatos.AlbaranesClientesDetalles.FirstOrDefault(a => a.AlbaranId.ToString() == txtNumeroAlbaran.Text && a.ArticuloId.ToString() == strArticulo);
                        if (oDetalleAlbaran != null)
                        {
                            var oArticulosInventario = SGPADatos.vw_ArticulosConsulta.FirstOrDefault(a => a.ArticuloId.ToString() == strArticulo && a.EmpresaId == FrmPadre.dcmCodCompania);
                            if (oArticulosInventario != null)
                            {
                                if ((oArticulosInventario.Cantidad - (oArticulosInventario.CantidadComprometida - oDetalleAlbaran.Cantidad)) < dcmCantidad)
                                {
                                    dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Importe"].Value = "0,00";
                                    dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Cantidad"].Value = "0";
                                    dcmImporte = 0;
                                    dcmCantidad = 0;
                                    MessageBox.Show("No puede ingresar mas de " + ((oArticulosInventario.Cantidad - (oArticulosInventario.CantidadComprometida - oDetalleAlbaran.Cantidad))).ToString() + " Unds del artículo " + oArticulosInventario.Descripcion, FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        else
                        {
                            var oArticulosInventario = SGPADatos.vw_ArticulosConsulta.FirstOrDefault(a => a.ArticuloId.ToString() == strArticulo && a.EmpresaId == FrmPadre.dcmCodCompania);
                            if (oArticulosInventario != null)
                            {
                                if ((oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida) < dcmCantidad)
                                {
                                    dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Importe"].Value = "0,00";
                                    dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Cantidad"].Value = "0";
                                    dcmImporte = 0;
                                    dcmCantidad = 0;
                                    MessageBox.Show("No puede ingresar mas de " + (oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida).ToString() + " Unds del artículo " + oArticulosInventario.Descripcion, FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                    }
                    dtgArticulosAlbaran.Rows[e.RowIndex].Cells["Importe"].Value = string.Format("{0:n}", dcmImporte);
                    LlenarGridBases();
                }
            }
            catch
            {
            }
        }

        private void dtgArticulosAlbaran_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgArticulosAlbaran.CurrentCell.ColumnIndex == 2)
            {
                //e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
                e.Control.KeyPress += Control_KeyPress;
            }
            if (dtgArticulosAlbaran.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress += Control_KeyPress1;
            }
        }

        private void Control_KeyPress1(object sender, KeyPressEventArgs e)
        {
            try
            {
               if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }


                bool IsDec = false;
                int nroDec = 0;

                for (int i = 0; i < dtgArticulosAlbaran.CurrentCell.Value.ToString().Length; i++)
                {
                    if (dtgArticulosAlbaran.CurrentCell.Value.ToString()[i] == ',')
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
            catch
            {

            }
        }
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            int intValor = 0;
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            if (!int.TryParse(e.KeyChar.ToString(), out intValor))
            {
                e.Handled = true;
                return;
            }
        }
        private void Totalizar()
        {
            decimal dcmBases = 0;
            decimal dcmIVA = 0;
            decimal dcmRecargo = 0;
            decimal dcmRetencion = 0;
            decimal dcmTotal = 0;
            foreach (DataGridViewRow dtgFilas in dtgBasesAlbaran.Rows)
            {
                if (dtgFilas.Cells["BaseTotal"].Value != null)
                {
                    dcmBases += Convert.ToDecimal(dtgFilas.Cells["BaseTotal"].Value);
                }
                if (dtgFilas.Cells["CuotaIVA"].Value != null)
                {
                    dcmIVA += Convert.ToDecimal(dtgFilas.Cells["CuotaIVA"].Value);
                }
                if (dtgFilas.Cells["CuotaRecargo"].Value != null)
                {
                    dcmRecargo += Convert.ToDecimal(dtgFilas.Cells["CuotaRecargo"].Value);
                }
                if (dtgFilas.Cells["Retencion"].Value != null)
                {
                    if (dtgFilas.Cells["Retencion"].Value.ToString() != "")
                    {
                        dcmRetencion += Convert.ToDecimal(dtgFilas.Cells["Retencion"].Value);
                    }
                }
            }
            dcmTotal = dcmBases + dcmIVA + dcmRecargo - dcmRetencion;
            txtBase.Text = string.Format("{0:n}",dcmBases);
            txtIVA.Text = string.Format("{0:n}", dcmIVA);
            txtRecargo.Text = string.Format("{0:n}", dcmRecargo);
            txtRetencion.Text = string.Format("{0:n}", dcmRetencion);
            txtTotal.Text = string.Format("{0:n}", dcmTotal);
        }
        private void LlenarGridBases()
        {
            List<Clases.BasesImpuestos> oBasesImpuestos = new List<Clases.BasesImpuestos>();
            List<Clases.BasesImpuestosDistinct> oBasesImpuestosDistinct = new List<Clases.BasesImpuestosDistinct>();
            foreach (DataGridViewRow dr in dtgArticulosAlbaran.Rows)
            {
                Clases.BasesImpuestos oBaseImpuesto = new Clases.BasesImpuestos();
                oBaseImpuesto.IVA = Convert.ToDecimal(dr.Cells["IVA"].Value.ToString());
                oBaseImpuesto.Base = Convert.ToDecimal(dr.Cells["Importe"].Value.ToString());
                oBasesImpuestos.Add(oBaseImpuesto);
            }
            IEnumerable<decimal> IVASDistinct = oBasesImpuestos.Select(x => x.IVA).Distinct();
            foreach (decimal dcmIVA in IVASDistinct)
            {
                //Se recorren los IVA
                Clases.BasesImpuestosDistinct oBaseImpuesto = new Clases.BasesImpuestosDistinct();
                oBaseImpuesto.IVA = dcmIVA;
                oBaseImpuesto.Base = oBasesImpuestos.Where(a => a.IVA == dcmIVA).Sum(a => a.Base);
                oBasesImpuestosDistinct.Add(oBaseImpuesto);
            }
            foreach (Clases.BasesImpuestosDistinct oBases in oBasesImpuestosDistinct)
            {
                //Se verifica si existe en el grid de base, si existe se modifica
                if (BuscarEnGridBases(oBases.IVA.ToString()))
                {
                    //Existe
                    decimal dcmRetencion = 0;
                    decimal dcmRetencionCalculo = 0;
                    decimal dcmRecargo = 0;
                    decimal dcmRecargoCalculo = 0;
                    decimal dcmCalculoIVA = oBases.Base * oBases.IVA / 100;
                    decimal dcmCalculoBaseMasIVA = oBases.Base + dcmCalculoIVA;
                    var oImpuestos = SGPADatos.Impuestos.FirstOrDefault(a => a.Porcentaje == oBases.IVA);
                    if (chkRecargo.Checked)
                    {
                        if (oImpuestos != null)
                        {
                            dcmRecargo = oImpuestos.RecargoEquivalencia;
                            dcmRecargoCalculo = oBases.Base * oImpuestos.RecargoEquivalencia / 100;
                        }
                    }
                    if (dtgBasesAlbaran.Rows[intRowIndexBases].Cells["RetencionPercent"].Value != null)
                    {
                        if (dtgBasesAlbaran.Rows[intRowIndexBases].Cells["RetencionPercent"].Value.ToString() != "")
                        {
                            dcmRetencion = Convert.ToDecimal(dtgBasesAlbaran.Rows[intRowIndexBases].Cells["RetencionPercent"].Value);
                        }
                    }
                    dcmRetencionCalculo = oBases.Base * dcmRetencion / 100;
                    dtgBasesAlbaran.Rows[intRowIndexBases].Cells["BaseTotal"].Value = string.Format("{0:n}", oBases.Base);
                    dtgBasesAlbaran.Rows[intRowIndexBases].Cells["IVATotal"].Value = string.Format("{0:n}", oBases.IVA);
                    dtgBasesAlbaran.Rows[intRowIndexBases].Cells["CuotaIVA"].Value = string.Format("{0:n}", dcmCalculoIVA);
                    dtgBasesAlbaran.Rows[intRowIndexBases].Cells["BaseMasCuota"].Value = string.Format("{0:n}", dcmCalculoBaseMasIVA);
                    dtgBasesAlbaran.Rows[intRowIndexBases].Cells["Recargo"].Value = string.Format("{0:n}", dcmRecargo);
                    dtgBasesAlbaran.Rows[intRowIndexBases].Cells["CuotaRecargo"].Value = string.Format("{0:n}", dcmRecargoCalculo);
                    dtgBasesAlbaran.Rows[intRowIndexBases].Cells["Retencion"].Value = string.Format("{0:n}", dcmRetencionCalculo);
                }
                else
                {
                    //No Existe
                    decimal dcmRecargo = 0;
                    decimal dcmRecargoCalculo = 0;
                    decimal dcmCalculoIVA = oBases.Base * oBases.IVA / 100;
                    decimal dcmCalculoBaseMasIVA = oBases.Base + dcmCalculoIVA;
                    var oImpuestos = SGPADatos.Impuestos.FirstOrDefault(a => a.Porcentaje == oBases.IVA);
                    if (chkRecargo.Checked)
                    {
                        if (oImpuestos != null)
                        {
                            dcmRecargo = oImpuestos.RecargoEquivalencia;
                            dcmRecargoCalculo = oBases.Base * oImpuestos.RecargoEquivalencia / 100;
                        }
                    }
                    dtgBasesAlbaran.Rows.Add(string.Format("{0:n}", oBases.Base), string.Format("{0:n}", oBases.IVA), string.Format("{0:n}", dcmCalculoIVA), string.Format("{0:n}", dcmCalculoBaseMasIVA), string.Format("{0:n}", dcmRecargo), string.Format("{0:n}", dcmRecargoCalculo), "", "");
                }
            }
            EliminarGridBases(oBasesImpuestosDistinct);
            Totalizar();
        }

        private void chkRecargo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridBases();
        }

        private void dtgBasesAlbaranes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgBasesAlbaran.IsCurrentCellDirty)
            {
                dtgBasesAlbaran.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtgBasesAlbaranes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal dcmRetencion = 0;
                decimal dcmRetencionCalculo = 0;
                decimal dcmBase = 0;
                if (dtgBasesAlbaran.Rows[e.RowIndex].Cells["BaseTotal"].Value != null)
                {
                    if (dtgBasesAlbaran.Rows[e.RowIndex].Cells["BaseTotal"].Value.ToString() != "")
                    {
                        dcmBase = Convert.ToDecimal(dtgBasesAlbaran.Rows[e.RowIndex].Cells["BaseTotal"].Value);
                    }
                }
                if (dtgBasesAlbaran.Rows[e.RowIndex].Cells["RetencionPercent"].Value != null)
                {
                    if (dtgBasesAlbaran.Rows[e.RowIndex].Cells["RetencionPercent"].Value.ToString() != "")
                    {
                        dcmRetencion = Convert.ToDecimal(dtgBasesAlbaran.Rows[e.RowIndex].Cells["RetencionPercent"].Value);
                    }
                }
                dcmRetencionCalculo = dcmBase * (dcmRetencion / 100);
                if (e.ColumnIndex == 6)
                {
                    dtgBasesAlbaran.Rows[e.RowIndex].Cells["Retencion"].Value = dcmRetencionCalculo.ToString();
                    Totalizar();
                }
            }
            catch
            {
            }
        }

        private void dtgBasesAlbaranes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgBasesAlbaran.CurrentCell.ColumnIndex == 6)
            {
                //e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
                e.Control.KeyPress += Control_KeyPress2; 
            }
        }

        private void Control_KeyPress2(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }
                bool IsDec = false;
                int nroDec = 0;
                for (int i = 0; i < dtgBasesAlbaran.CurrentCell.Value.ToString().Length; i++)
                {
                    if (dtgBasesAlbaran.CurrentCell.Value.ToString()[i] == ',')
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
            catch
            {

            }
        }
        private bool ValidarGuardar()
        {
            ErrorValidador.Dispose();
            if (txtClienteId.Text.Trim().Length == 0)
            {
                Clases.Utilidades.MostrarErrorControl(txtClienteId, ErrorValidador, "El campo es obligatorio");
                return false;
            }
            if (dtgArticulosAlbaran.Rows.Count == 0)
            {
                Clases.Utilidades.MostrarErrorControl(dtgArticulosAlbaran, ErrorValidador, "El campo es obligatorio");
                return false;
            }
            else
            {
                //Se valida que no existan articulos sin cantidades
                foreach (DataGridViewRow dtgFilas in dtgArticulosAlbaran.Rows)
                {
                    if (dtgFilas.Cells["Cantidad"].Value != null)
                    {
                        if (dtgFilas.Cells["Cantidad"].Value.ToString() == "")
                        {
                            MessageBox.Show("Debe ingresar las cantidades de todos los artículos en la lista", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                           return false;
                        }
                        else
                        {
                            if (Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString()) == 0)
                            {
                                MessageBox.Show("Debe ingresar las cantidades de todos los artículos en la lista", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar las cantidades de todos los artículos en la lista", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            if (dtgBasesAlbaran.Rows.Count == 0)
            {
                Clases.Utilidades.MostrarErrorControl(dtgBasesAlbaran, ErrorValidador, "El campo es obligatorio");
                return false;
            }
            return true;
        }
        public bool Modificar()
        {
            bool bolEditado = false;
            try
            {
                if (ValidarGuardar())
                {                   
                    //Se guarda primero la maestra de presupuesto
                    var oAlbaran = SGPADatos.AlbaranesClientes.FirstOrDefault(a => a.AlbaranId.ToString() == txtNumeroAlbaran.Text && a.EmpresaId==FrmPadre.dcmCodCompania);
                    if (oAlbaran.Finalizado)
                    {
                        MessageBox.Show("Disculpe, el albaran fue finalizado y no puede ser editado", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        oAlbaran.ClienteId = Convert.ToInt32(txtClienteId.Text);
                        oAlbaran.EmpresaId = FrmPadre.dcmCodCompania;
                        oAlbaran.Fecha = dtpFecha.Value;
                        oAlbaran.Facturado = false;
                        oAlbaran.AlbaranesRecargo = chkRecargo.Checked;
                        oAlbaran.Finalizado = bolAlbaranFinalizada;
                        SGPADatos.SaveChanges();
                        //Se elimina primero los registros
                        var oAlbaresDetalles = SGPADatos.AlbaranesClientesDetalles.Where(a => a.AlbaranId == oAlbaran.AlbaranId);
                        foreach (AlbaranesClientesDetalles oAlbaranesDetalleFila in oAlbaresDetalles)
                        {
                            SGPADatos.AlbaranesClientesDetalles.Remove(oAlbaranesDetalleFila);
                        }
                        SGPADatos.SaveChanges();
                        var oAlbaranesBases = SGPADatos.AlbaranesClientesBases.Where(a => a.AlbaranId == oAlbaran.AlbaranId);
                        foreach (AlbaranesClientesBases oAlbaranesBaseFila in oAlbaranesBases)
                        {
                            SGPADatos.AlbaranesClientesBases.Remove(oAlbaranesBaseFila);
                        }
                        SGPADatos.SaveChanges();
                        //Se guarda el detalle del presupuesto
                        foreach (DataGridViewRow dtgFilas in dtgArticulosAlbaran.Rows)
                        {
                            var oAlbaranesDetalle = new AlbaranesClientesDetalles();
                            oAlbaranesDetalle.AlbaranId = oAlbaran.AlbaranId;
                            oAlbaranesDetalle.ArticuloId = Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString());
                            oAlbaranesDetalle.Cantidad = Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString());
                            oAlbaranesDetalle.Precio = Convert.ToDecimal(dtgFilas.Cells["Precio"].Value.ToString());
                            if (dtgFilas.Cells["Dcto"].Value != null)
                            {
                                if (dtgFilas.Cells["Dcto"].Value.ToString() != "")
                                {
                                    oAlbaranesDetalle.Descuento = Convert.ToDecimal(dtgFilas.Cells["Dcto"].Value.ToString());
                                }
                            }
                            oAlbaranesDetalle.IVA = Convert.ToDecimal(dtgFilas.Cells["IVA"].Value.ToString());
                            oAlbaranesDetalle.Subtotal = Convert.ToDecimal(dtgFilas.Cells["Importe"].Value.ToString());
                            SGPADatos.AlbaranesClientesDetalles.Add(oAlbaranesDetalle);
                            SGPADatos.SaveChanges();
                            Clases.ManejoComprometidos oManejoComprometido = new Clases.ManejoComprometidos();
                            oManejoComprometido.InsertarMovimientoComprometido(Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString()), Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString()), oAlbaran.AlbaranId, "ALBARAN");
                        }
                        //Se guarda las bases del presupuesto
                        foreach (DataGridViewRow dtgFilas in dtgBasesAlbaran.Rows)
                        {
                            var oAlbaranBases = new AlbaranesClientesBases();
                            oAlbaranBases.AlbaranId = oAlbaran.AlbaranId;
                            oAlbaranBases.Base = Convert.ToDecimal(dtgFilas.Cells["BaseTotal"].Value.ToString());
                            oAlbaranBases.IVA = Convert.ToDecimal(dtgFilas.Cells["IVATotal"].Value.ToString());
                            oAlbaranBases.CuotaIVA = Convert.ToDecimal(dtgFilas.Cells["CuotaIVA"].Value.ToString());
                            oAlbaranBases.RecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["Recargo"].Value.ToString());
                            oAlbaranBases.CuotaRecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["CuotaRecargo"].Value.ToString());
                            if (dtgFilas.Cells["RetencionPercent"].Value != null)
                            {
                                if (dtgFilas.Cells["RetencionPercent"].Value.ToString() != "")
                                {
                                    oAlbaranBases.Retencion = Convert.ToDecimal(dtgFilas.Cells["RetencionPercent"].Value.ToString());
                                }
                            }
                            if (dtgFilas.Cells["Retencion"].Value != null)
                            {
                                if (dtgFilas.Cells["Retencion"].Value.ToString() != "")
                                {
                                    oAlbaranBases.CuotaRetencion = Convert.ToDecimal(dtgFilas.Cells["Retencion"].Value.ToString());
                                }
                            }
                            SGPADatos.AlbaranesClientesBases.Add(oAlbaranBases);
                            SGPADatos.SaveChanges();
                        }
                        txtNumeroAlbaran.Text = oAlbaran.AlbaranId.ToString();
                        FinalizarAlbaran(oAlbaran.AlbaranId);
                        LlenarGrid("");
                        Inicializar();
                        strProceso = "N";
                        return true;
                    }
                }
                return false;
            }
            catch (Exception oException)
            {
                return false;
            }
            return bolEditado;
        }
        public bool Guardar()
        {
            try
            {
                if (ValidarGuardar())
                {
                    //Se guarda primero la maestra de Albaranes
                    var oAlbaran = new AlbaranesClientes();
                    oAlbaran.ClienteId = Convert.ToInt32(txtClienteId.Text);
                    oAlbaran.EmpresaId = FrmPadre.dcmCodCompania;
                    oAlbaran.Fecha = dtpFecha.Value;
                    oAlbaran.Facturado = false;
                    oAlbaran.AlbaranesRecargo = chkRecargo.Checked;
                    oAlbaran.Finalizado = bolAlbaranFinalizada;
                    SGPADatos.AlbaranesClientes.Add(oAlbaran);
                    SGPADatos.SaveChanges();
                    //Se guarda el detalle del Albaranes
                    foreach (DataGridViewRow dtgFilas in dtgArticulosAlbaran.Rows)
                    {
                        var oAlbaranDetalle = new AlbaranesClientesDetalles();
                        oAlbaranDetalle.AlbaranId = oAlbaran.AlbaranId;
                        oAlbaranDetalle.ArticuloId = Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString());
                        oAlbaranDetalle.Cantidad = Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString());
                        oAlbaranDetalle.Precio = Convert.ToDecimal(dtgFilas.Cells["Precio"].Value.ToString());
                        if(dtgFilas.Cells["Dcto"].Value!=null)
                        {
                            if (dtgFilas.Cells["Dcto"].Value.ToString() != "")
                            {
                                oAlbaranDetalle.Descuento = Convert.ToDecimal(dtgFilas.Cells["Dcto"].Value.ToString());
                            }
                        }                        
                        oAlbaranDetalle.IVA = Convert.ToDecimal(dtgFilas.Cells["IVA"].Value.ToString());
                        oAlbaranDetalle.Subtotal = Convert.ToDecimal(dtgFilas.Cells["Importe"].Value.ToString());
                        SGPADatos.AlbaranesClientesDetalles.Add(oAlbaranDetalle);
                        SGPADatos.SaveChanges();
                        Clases.ManejoComprometidos oManejoComprometido = new Clases.ManejoComprometidos();
                        oManejoComprometido.InsertarMovimientoComprometido(Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString()), Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString()), oAlbaran.AlbaranId, "ALBARAN");
                    }
                    //Se guarda las bases del Albaran
                    foreach (DataGridViewRow dtgFilas in dtgBasesAlbaran.Rows)
                    {
                        var oAlbaranBases = new AlbaranesClientesBases();
                        oAlbaranBases.AlbaranId = oAlbaran.AlbaranId;
                        oAlbaranBases.Base = Convert.ToDecimal(dtgFilas.Cells["BaseTotal"].Value.ToString());
                        oAlbaranBases.IVA = Convert.ToDecimal(dtgFilas.Cells["IVATotal"].Value.ToString());
                        oAlbaranBases.CuotaIVA = Convert.ToDecimal(dtgFilas.Cells["CuotaIVA"].Value.ToString());
                        oAlbaranBases.RecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["Recargo"].Value.ToString());
                        oAlbaranBases.CuotaRecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["CuotaRecargo"].Value.ToString());
                        if (dtgFilas.Cells["RetencionPercent"].Value != null)
                        {
                            if (dtgFilas.Cells["RetencionPercent"].Value.ToString() != "")
                            {
                                oAlbaranBases.Retencion = Convert.ToDecimal(dtgFilas.Cells["RetencionPercent"].Value.ToString());
                            }
                        }
                        if (dtgFilas.Cells["Retencion"].Value != null)
                        {
                            if (dtgFilas.Cells["Retencion"].Value.ToString() != "")
                            {
                                oAlbaranBases.CuotaRetencion = Convert.ToDecimal(dtgFilas.Cells["Retencion"].Value.ToString());
                            }
                        }
                        SGPADatos.AlbaranesClientesBases.Add(oAlbaranBases);
                        SGPADatos.SaveChanges();
                    }
                    txtNumeroAlbaran.Text = oAlbaran.AlbaranId.ToString();
                    FinalizarAlbaran(oAlbaran.AlbaranId);
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
        private void CargarData(decimal dcmAlbaranId)
        {
            try
            {
                var oAlbaran = SGPADatos.AlbaranesClientes.FirstOrDefault(a => a.AlbaranId == dcmAlbaranId);
                if (oAlbaran != null)
                {
                    txtNumeroAlbaran.Text = oAlbaran.AlbaranId.ToString();
                    txtClienteId.Text = oAlbaran.ClienteId.ToString();
                    txtNIF.Text = oAlbaran.Clientes.Identificacion.ToString();
                    dtpFecha.Value = oAlbaran.Fecha;
                    txtNombreCliente.Text = oAlbaran.Clientes.NombreCliente.ToString();
                    bolAlbaranFinalizada = oAlbaran.Finalizado;
                    var oAlbaranesDetalles = SGPADatos.AlbaranesClientesDetalles.Where(a => a.AlbaranId == oAlbaran.AlbaranId);
                    foreach (AlbaranesClientesDetalles oAlbaranDetalleFila in oAlbaranesDetalles)
                    {
                        dtgArticulosAlbaran.Rows.Add(oAlbaranDetalleFila.Articulos.Descripcion.ToString(), oAlbaranDetalleFila.ArticuloId.ToString(), oAlbaranDetalleFila.Cantidad.ToString(), string.Format("{0:n}", oAlbaranDetalleFila.Precio), string.Format("{0:n}", oAlbaranDetalleFila.Descuento), string.Format("{0:n}", oAlbaranDetalleFila.IVA), string.Format("{0:n}", oAlbaranDetalleFila.Subtotal));
                    }
                    var oAlbaranesBases = SGPADatos.AlbaranesClientesBases.Where(a => a.AlbaranId == oAlbaran.AlbaranId);
                    foreach (AlbaranesClientesBases oAlbaranBaseFila in oAlbaranesBases)
                    {
                        dtgBasesAlbaran.Rows.Add(string.Format("{0:n}", oAlbaranBaseFila.Base), string.Format("{0:n}", oAlbaranBaseFila.IVA), string.Format("{0:n}", oAlbaranBaseFila.CuotaIVA), string.Format("{0:n}", oAlbaranBaseFila.Base+ oAlbaranBaseFila.CuotaIVA), string.Format("{0:n}", oAlbaranBaseFila.RecargoEquivalencia), string.Format("{0:n}", oAlbaranBaseFila.CuotaRecargoEquivalencia), string.Format("{0:n}", oAlbaranBaseFila.Retencion), string.Format("{0:n}", oAlbaranBaseFila.CuotaRetencion));
                    }
                    chkRecargo.Checked = (bool)oAlbaran.AlbaranesRecargo;
                    Totalizar();
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
                    CargarData(Convert.ToDecimal(dtgConsulta.SelectedRows[0].Cells["AlbaranId"].Value.ToString()));
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

        private void dtgArticulosAlbaran_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgConsulta.RowCount >= 0)
                {
                    Cursor = Cursors.WaitCursor;
                    if (dtgConsulta.SelectedRows.Count == 1)
                    {
                        lblEliminarArticulo.Visible = true;
                        btnEliminarArticulo.Visible = true;
                    }
                    else
                    {
                        lblEliminarArticulo.Visible = false;
                        btnEliminarArticulo.Visible = false;
                    }
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ou)
            {

            }
        }
        private void FinalizarAlbaran(decimal dcmAlbaranId)
        {
            try
            {
                if (bolAlbaranFinalizada)
                {
                    //Se finaliza el albaran
                    var oAlbaran = SGPADatos.AlbaranesClientes.FirstOrDefault(a => a.AlbaranId == dcmAlbaranId && a.EmpresaId == FrmPadre.dcmCodCompania);
                    oAlbaran.Finalizado = bolAlbaranFinalizada;
                    var oAlbaranesDetalles = SGPADatos.AlbaranesClientesDetalles.Where(a => a.AlbaranId == dcmAlbaranId);
                    foreach (AlbaranesClientesDetalles oAlbaranesFilas in oAlbaranesDetalles)
                    {
                        //Se genera el movimiento de inventario en existencias reales
                        Clases.ManejoInventario oManejoInventario = new Clases.ManejoInventario();
                        oManejoInventario.InsertarMovimientoInventario(oAlbaranesFilas.ArticuloId, oAlbaranesFilas.Cantidad, oAlbaran.AlbaranId, "ALBARAN");
                    }
                }
            }
            catch
            {
            }
        }
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult _Dial = MessageBox.Show("¿Desea eliminar el artículo seleccionado?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (_Dial == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    if (dtgArticulosAlbaran.SelectedRows.Count == 1)
                    {
                        //decimal dcmArticuloPresupuestoId = Convert.ToDecimal(dtgArticulosPresupuesto.SelectedRows[0].Cells["ArticuloId"].Value.ToString());
                        dtgArticulosAlbaran.Rows.RemoveAt(dtgArticulosAlbaran.SelectedRows[0].Index);
                        LlenarGridBases();
                        Totalizar();
                    }
                    Cursor = Cursors.Default;
                }
            }
            catch
            {

            }
        }
        bool bolAlbaranFinalizada=false;
        private void btnFinalizarAlbaran_Click(object sender, EventArgs e)
        {
            DialogResult _Dial = MessageBox.Show("¿Desea finalizar la albaran actual, luego no podrá ser modificada?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_Dial == DialogResult.Yes)
            {
                if (txtNumeroAlbaran.Text == "")
                {
                    //Albaran Nueva
                    bolAlbaranFinalizada = true;
                    Guardar();
                }
                else
                {
                    //Albaran Editada
                    bolAlbaranFinalizada = true;
                    Modificar();
                }
            }
        }
    }
}
