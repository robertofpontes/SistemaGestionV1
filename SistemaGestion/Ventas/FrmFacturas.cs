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
    public partial class FrmFacturas : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        bool bolAlbaranes = false;
        List<Clases.RecibosFactura> oRecibosFacturas = new List<Clases.RecibosFactura>();

        //Para copiar los albaranes
        

        public FrmFacturas()
        {
            InitializeComponent();
            LlenarGrid(txtConsulta.Text);
            LlenarFormaPago();
        }
        private void LlenarFormaPago()
        {
            try
            {
                cmbFormaPago.DataSource = (from formapago in SGPADatos.FormasPagos
                                           select new { formapago.FormaPagoId, formapago.Descripcion }).ToList();
                cmbFormaPago.DisplayMember = "Descripcion";
                cmbFormaPago.ValueMember = "FormaPagoId";
                cmbFormaPago.SelectedIndex = -1;
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

        private void FrmPresupuestos_Load(object sender, EventArgs e)
        {
            CambiarColorControles(this);
        }

        private void FrmPresupuestos_Activated(object sender, EventArgs e)
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
            if (bolFacturaFinalizada)
            {
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_nuevo2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_editar2.Enabled = true;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_guardar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_cancelar2.Enabled = false;
                ((FrmPadre)this.MdiParent)._Ctrl_Buscar1._Bt_borrar2.Enabled = true;
                MessageBox.Show("Disculpe, la factura fue finalizada y no puede ser editada", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                strProceso = "M";
            }
        }
        private void BloquearControles(bool bolActivo)
        {
            if(bolFacturaFinalizada)
            {
                bolActivo = false;
            }
            chkRecargo.Enabled = bolActivo;
            dtpFecha.Enabled = bolActivo;
            btnBuscarArticulos.Enabled = bolActivo;
            btnBuscarClientes.Enabled = bolActivo;
            btnEliminarArticulo.Enabled = bolActivo;
            btnEliminarArticulo.Visible = false;
            dtgArticulosFacturas.Enabled = bolActivo;
            btnVencimiento.Enabled = bolActivo;
            if (strProceso == "A"|| strProceso == "")
            {
                btnBuscarPresupuesto.Enabled = bolActivo;
            }
            else
            {
                btnBuscarPresupuesto.Enabled = false;
            }
            txtNumeroPlazos.Enabled = bolActivo;
            cmbFormaPago.Enabled = bolActivo;
            btnFinalizarFactura.Enabled = bolActivo;
            dtgBasesFacturas.Enabled = bolActivo;
        }
        public void Inicializar()
        {
            SGPADatos.Dispose();
            oRecibosFacturas = new List<Clases.RecibosFactura>();
            dtgArticulosFacturas.CellValidating -= dtgArticulosPresupuesto_CellValidating;
            dtgArticulosFacturas.Rows.Clear();
            dtgArticulosFacturas.CellValidating += dtgArticulosPresupuesto_CellValidating;
            dtgBasesFacturas.Rows.Clear();
            bolAlbaranes = false;
            strProceso = "";
            txtBase.Text = "";
            txtIVA.Text = "";
            btnCopiarAlbaranes.Enabled = true;
            bolFacturaFinalizada = false;
            txtRecargo.Text = "";
            txtRetencion.Text = "";
            txtTotal.Text = "";
            txtClienteId.Text = "";
            txtNumeroFactura.Text = "";
            txtNombreCliente.Text = "";
            txtPresupuesto.Text = "";
            txtNumeroPlazos.Text = "";
            cmbFormaPago.SelectedIndex = -1;
            txtNIF.Text = "";
            btnEliminarArticulo.Visible = false;
            chkRecargo.Checked = false;
            BloquearControles(false);
            SGPADatos = new SGPAEntities();
        }


        private void FrmPresupuestos_FormClosing(object sender, FormClosingEventArgs e)
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
                if (!chkRecargo.Enabled & txtNumeroFactura.Text.Trim().Length == 0)
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
                var oDatos = (from facturas in SGPADatos.vw_FacturasConsulta where (facturas.NombreCliente.Contains(strBusqueda) || facturas.FacturaId.ToString().Contains(strBusqueda)) && facturas.EmpresaId == FrmPadre.dcmCodCompania select facturas).OrderByDescending(a => a.Fecha).AsNoTracking();
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
            foreach (DataGridViewRow dtgFilas in dtgArticulosFacturas.Rows)
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
            foreach (DataGridViewRow dtgFilas in dtgBasesFacturas.Rows)
            {
                if (dtgFilas.Cells["IVATotal"].Value != null)
                {
                    var oExiste = oBasesImpuestosDistinct.Where(a => a.IVA.ToString() == dtgFilas.Cells["IVATotal"].Value.ToString());
                    if (oExiste.Count() == 0)
                    {
                        //Se Elimina la fila en el grid de bases
                        dtgBasesFacturas.Rows.RemoveAt(dtgFilas.Index);
                    }
                }
            }
        }
        private bool BuscarEnGridBases(string strValor)
        {
            bool bolExiste = false;
            //int rowIndex = -1;
            foreach (DataGridViewRow dtgFilas in dtgBasesFacturas.Rows)
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
                                dtgArticulosFacturas.Rows.Add(oArticulo.Descripcion.ToString(), oArticulo.ArticuloId.ToString(), "0", string.Format("{0:n}", oArticulo.Precio), "", string.Format("{0:n}", oArticulo.Impuestos.Porcentaje), "0");
                                LlenarGridBases();
                            }
                            else
                            {
                                MessageBox.Show("El artículo ya existe en la factura actual", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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



        private void dtgArticulosPresupuesto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dtgArticulosPresupuesto_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dtgArticulosPresupuesto_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgArticulosFacturas.IsCurrentCellDirty)
            {
                dtgArticulosFacturas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtgArticulosPresupuesto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal dcmDescuento = 0;
                decimal dcmCantidad = 0;
                decimal dcmPrecio = 0;
                decimal dcmImporte = 0;
                if (dtgArticulosFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value != null)
                {
                    if (dtgArticulosFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString() != "")
                    {
                        dcmCantidad = Convert.ToDecimal(dtgArticulosFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    }
                }
                if (dtgArticulosFacturas.Rows[e.RowIndex].Cells["Precio"].Value.ToString() != "")
                {
                    dcmPrecio = Convert.ToDecimal(dtgArticulosFacturas.Rows[e.RowIndex].Cells["Precio"].Value);
                }
                if (dtgArticulosFacturas.Rows[e.RowIndex].Cells["Dcto"].Value != null)
                {
                    if (dtgArticulosFacturas.Rows[e.RowIndex].Cells["Dcto"].Value.ToString() != "")
                    {
                        dcmDescuento = Convert.ToDecimal(dtgArticulosFacturas.Rows[e.RowIndex].Cells["Dcto"].Value);
                    }
                }
                dcmImporte = (dcmCantidad * dcmPrecio) - (dcmCantidad * dcmPrecio * (dcmDescuento / 100));
                if (e.ColumnIndex == 2 || e.ColumnIndex == 4)
                {
                    //Se debe validar inventario
                    if (txtNumeroFactura.Text == "")
                    {
                        //Factura nueva
                        string strArticulo = dtgArticulosFacturas.Rows[e.RowIndex].Cells["ArticuloId"].Value.ToString();
                        var oArticulosInventario = SGPADatos.vw_ArticulosConsulta.FirstOrDefault(a => a.ArticuloId.ToString() == strArticulo && a.EmpresaId == FrmPadre.dcmCodCompania);
                        if (oArticulosInventario != null)
                        {
                            if ((oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida) < dcmCantidad)
                            {
                                dtgArticulosFacturas.Rows[e.RowIndex].Cells["Importe"].Value = "0,00";
                                dtgArticulosFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value = "0";
                                dcmImporte = 0;
                                dcmCantidad = 0;
                                MessageBox.Show("No puede ingresar mas de " + (oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida).ToString() + " Unds del artículo " + oArticulosInventario.Descripcion, FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        string strArticulo = dtgArticulosFacturas.Rows[e.RowIndex].Cells["ArticuloId"].Value.ToString();
                        var oDetalleFactura = SGPADatos.FacturasDetalles.FirstOrDefault(a=>a.FacturaId.ToString()==txtNumeroFactura.Text && a.ArticuloId.ToString()== strArticulo);
                        if (oDetalleFactura != null)
                        {
                            var oArticulosInventario = SGPADatos.vw_ArticulosConsulta.FirstOrDefault(a => a.ArticuloId.ToString() == strArticulo && a.EmpresaId == FrmPadre.dcmCodCompania);
                            if (oArticulosInventario != null)
                            {
                                if ((oArticulosInventario.Cantidad - (oArticulosInventario.CantidadComprometida- oDetalleFactura.Cantidad)) < dcmCantidad)
                                {
                                    dtgArticulosFacturas.Rows[e.RowIndex].Cells["Importe"].Value = "0,00";
                                    dtgArticulosFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value = "0";
                                    dcmImporte = 0;
                                    dcmCantidad = 0;
                                    MessageBox.Show("No puede ingresar mas de " + ((oArticulosInventario.Cantidad - (oArticulosInventario.CantidadComprometida - oDetalleFactura.Cantidad))).ToString() + " Unds del artículo " + oArticulosInventario.Descripcion, FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                    dtgArticulosFacturas.Rows[e.RowIndex].Cells["Importe"].Value = "0,00";
                                    dtgArticulosFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value = "0";
                                    dcmImporte = 0;
                                    dcmCantidad = 0;
                                    MessageBox.Show("No puede ingresar mas de " + (oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida).ToString() + " Unds del artículo " + oArticulosInventario.Descripcion, FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                    }
                    dtgArticulosFacturas.Rows[e.RowIndex].Cells["Importe"].Value = string.Format("{0:n}", dcmImporte);
                    LlenarGridBases();
                }
            }
            catch
            {
            }
        }

        private void dtgArticulosPresupuesto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgArticulosFacturas.CurrentCell.ColumnIndex == 2)
            {
                //e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
                e.Control.KeyPress += Control_KeyPress;
            }
            if (dtgArticulosFacturas.CurrentCell.ColumnIndex == 4)
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

                for (int i = 0; i < dtgArticulosFacturas.CurrentCell.Value.ToString().Length; i++)
                {
                    if (dtgArticulosFacturas.CurrentCell.Value.ToString()[i] == ',')
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
            foreach (DataGridViewRow dtgFilas in dtgBasesFacturas.Rows)
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
            txtBase.Text = string.Format("{0:n}", dcmBases);
            txtIVA.Text = string.Format("{0:n}", dcmIVA);
            txtRecargo.Text = string.Format("{0:n}", dcmRecargo);
            txtRetencion.Text = string.Format("{0:n}", dcmRetencion);
            txtTotal.Text = string.Format("{0:n}", dcmTotal);
        }
        private void LlenarGridBases()
        {
            List<Clases.BasesImpuestos> oBasesImpuestos = new List<Clases.BasesImpuestos>();
            List<Clases.BasesImpuestosDistinct> oBasesImpuestosDistinct = new List<Clases.BasesImpuestosDistinct>();
            foreach (DataGridViewRow dr in dtgArticulosFacturas.Rows)
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
                    if (dtgBasesFacturas.Rows[intRowIndexBases].Cells["RetencionPercent"].Value != null)
                    {
                        if (dtgBasesFacturas.Rows[intRowIndexBases].Cells["RetencionPercent"].Value.ToString() != "")
                        {
                            dcmRetencion = Convert.ToDecimal(dtgBasesFacturas.Rows[intRowIndexBases].Cells["RetencionPercent"].Value);
                        }
                    }
                    dcmRetencionCalculo = oBases.Base * dcmRetencion / 100;
                    dtgBasesFacturas.Rows[intRowIndexBases].Cells["BaseTotal"].Value = string.Format("{0:n}", oBases.Base);
                    dtgBasesFacturas.Rows[intRowIndexBases].Cells["IVATotal"].Value = string.Format("{0:n}", oBases.IVA);
                    dtgBasesFacturas.Rows[intRowIndexBases].Cells["CuotaIVA"].Value = string.Format("{0:n}", dcmCalculoIVA);
                    dtgBasesFacturas.Rows[intRowIndexBases].Cells["BaseMasCuota"].Value = string.Format("{0:n}", dcmCalculoBaseMasIVA);
                    dtgBasesFacturas.Rows[intRowIndexBases].Cells["Recargo"].Value = string.Format("{0:n}", dcmRecargo);
                    dtgBasesFacturas.Rows[intRowIndexBases].Cells["CuotaRecargo"].Value = string.Format("{0:n}", dcmRecargoCalculo);
                    dtgBasesFacturas.Rows[intRowIndexBases].Cells["Retencion"].Value = string.Format("{0:n}", dcmRetencionCalculo);
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
                    dtgBasesFacturas.Rows.Add(string.Format("{0:n}", oBases.Base), string.Format("{0:n}", oBases.IVA), string.Format("{0:n}", dcmCalculoIVA), string.Format("{0:n}", dcmCalculoBaseMasIVA), string.Format("{0:n}", dcmRecargo), string.Format("{0:n}", dcmRecargoCalculo), "", "");
                }
            }
            EliminarGridBases(oBasesImpuestosDistinct);
            Totalizar();
        }

        private void chkRecargo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridBases();
        }

        private void dtgBasesPresupuestos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgBasesFacturas.IsCurrentCellDirty)
            {
                dtgBasesFacturas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtgBasesPresupuestos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal dcmRetencion = 0;
                decimal dcmRetencionCalculo = 0;
                decimal dcmBase = 0;
                if (dtgBasesFacturas.Rows[e.RowIndex].Cells["BaseTotal"].Value != null)
                {
                    if (dtgBasesFacturas.Rows[e.RowIndex].Cells["BaseTotal"].Value.ToString() != "")
                    {
                        dcmBase = Convert.ToDecimal(dtgBasesFacturas.Rows[e.RowIndex].Cells["BaseTotal"].Value);
                    }
                }
                if (dtgBasesFacturas.Rows[e.RowIndex].Cells["RetencionPercent"].Value != null)
                {
                    if (dtgBasesFacturas.Rows[e.RowIndex].Cells["RetencionPercent"].Value.ToString() != "")
                    {
                        dcmRetencion = Convert.ToDecimal(dtgBasesFacturas.Rows[e.RowIndex].Cells["RetencionPercent"].Value);
                    }
                }
                dcmRetencionCalculo = dcmBase * (dcmRetencion / 100);
                if (e.ColumnIndex == 6)
                {
                    dtgBasesFacturas.Rows[e.RowIndex].Cells["Retencion"].Value = dcmRetencionCalculo.ToString();
                    Totalizar();
                }
            }
            catch
            {
            }
        }

        private void dtgBasesPresupuestos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgBasesFacturas.CurrentCell.ColumnIndex == 6)
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
                for (int i = 0; i < dtgBasesFacturas.CurrentCell.Value.ToString().Length; i++)
                {
                    if (dtgBasesFacturas.CurrentCell.Value.ToString()[i] == ',')
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
            if (dtgArticulosFacturas.Rows.Count == 0)
            {
                Clases.Utilidades.MostrarErrorControl(dtgArticulosFacturas, ErrorValidador, "El campo es obligatorio");
                return false;
            }
            else
            {
                //Se valida que no existan articulos sin cantidades
                foreach (DataGridViewRow dtgFilas in dtgArticulosFacturas.Rows)
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
            if (dtgBasesFacturas.Rows.Count == 0)
            {
                Clases.Utilidades.MostrarErrorControl(dtgBasesFacturas, ErrorValidador, "El campo es obligatorio");
                return false;
            }
            if (oRecibosFacturas.Count() == 0)
            {
                Clases.Utilidades.MostrarErrorControl(txtNumeroPlazos, ErrorValidador, "El campo es obligatorio");
                MessageBox.Show("Debe ingresar el número de plazos y la respectiva fecha de vencimiento", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cmbFormaPago.SelectedValue == null)
            {
                Clases.Utilidades.MostrarErrorControl(cmbFormaPago, ErrorValidador, "El campo es obligatorio");
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
                    var oFactura = SGPADatos.Facturas.FirstOrDefault(a => a.FacturaId.ToString() == txtNumeroFactura.Text && a.EmpresaId == FrmPadre.dcmCodCompania);
                    if(oFactura.Finalizado)
                    {
                        MessageBox.Show("Disculpe, la factura fue finalizada y no puede ser editada", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    oFactura.ClienteId = Convert.ToInt32(txtClienteId.Text);
                    oFactura.EmpresaId = FrmPadre.dcmCodCompania;
                    oFactura.Fecha = dtpFecha.Value;
                    oFactura.FacturaRecargo = chkRecargo.Checked;
                    if (txtPresupuesto.Text != "")
                    {
                        oFactura.PresupuestoId = Convert.ToDecimal(txtPresupuesto.Text);
                    }
                    oFactura.FormaPagoId = Convert.ToDecimal(cmbFormaPago.SelectedValue.ToString());
                    oFactura.Finalizado = bolFacturaFinalizada;
                    SGPADatos.SaveChanges();
                    //Se elimina primero los registros
                    var oFacturasDetalles = SGPADatos.FacturasDetalles.Where(a => a.FacturaId == oFactura.FacturaId);
                    foreach (FacturasDetalles oPresupuestoDetalleFila in oFacturasDetalles)
                    {
                        SGPADatos.FacturasDetalles.Remove(oPresupuestoDetalleFila);
                    }
                    SGPADatos.SaveChanges();
                    var oFacturasBases = SGPADatos.FacturasBases.Where(a => a.FacturaId == oFactura.FacturaId);
                    foreach (FacturasBases oFacturaBaseFila in oFacturasBases)
                    {
                        SGPADatos.FacturasBases.Remove(oFacturaBaseFila);
                    }
                    SGPADatos.SaveChanges();
                    var oRecibosBD = SGPADatos.Recibos.Where(a => a.FacturaId == oFactura.FacturaId);
                    foreach (Recibos oReciboFila in oRecibosBD)
                    {
                        SGPADatos.Recibos.Remove(oReciboFila);
                    }
                    SGPADatos.SaveChanges();
                    //Se guarda el detalle del presupuesto
                    foreach (DataGridViewRow dtgFilas in dtgArticulosFacturas.Rows)
                    {
                        var oFacturaDetalle = new FacturasDetalles();
                        oFacturaDetalle.FacturaId = oFactura.FacturaId;
                        oFacturaDetalle.ArticuloId = Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString());
                        oFacturaDetalle.Cantidad = Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString());
                        oFacturaDetalle.Precio = Convert.ToDecimal(dtgFilas.Cells["Precio"].Value.ToString());
                        if (dtgFilas.Cells["Dcto"].Value != null)
                        {
                            if (dtgFilas.Cells["Dcto"].Value.ToString() != "")
                            {
                                oFacturaDetalle.Descuento = Convert.ToDecimal(dtgFilas.Cells["Dcto"].Value.ToString());
                            }
                        }
                        oFacturaDetalle.IVA = Convert.ToDecimal(dtgFilas.Cells["IVA"].Value.ToString());
                        oFacturaDetalle.Subtotal = Convert.ToDecimal(dtgFilas.Cells["Importe"].Value.ToString());
                        SGPADatos.FacturasDetalles.Add(oFacturaDetalle);
                        SGPADatos.SaveChanges();
                        if (!bolAlbaranes)
                        {
                            Clases.ManejoComprometidos oManejoComprometido = new Clases.ManejoComprometidos();
                            oManejoComprometido.InsertarMovimientoComprometido(Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString()), Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString()), oFactura.FacturaId, "FACTURA");
                        }
                    }
                    //Se guarda las bases del presupuesto
                    foreach (DataGridViewRow dtgFilas in dtgBasesFacturas.Rows)
                    {
                        var oFacturaBases = new FacturasBases();
                        oFacturaBases.FacturaId = oFactura.FacturaId;
                        oFacturaBases.Base = Convert.ToDecimal(dtgFilas.Cells["BaseTotal"].Value.ToString());
                        oFacturaBases.IVA = Convert.ToDecimal(dtgFilas.Cells["IVATotal"].Value.ToString());
                        oFacturaBases.CuotaIVA = Convert.ToDecimal(dtgFilas.Cells["CuotaIVA"].Value.ToString());
                        oFacturaBases.RecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["Recargo"].Value.ToString());
                        oFacturaBases.CuotaRecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["CuotaRecargo"].Value.ToString());
                        if (dtgFilas.Cells["RetencionPercent"].Value != null)
                        {
                            if (dtgFilas.Cells["RetencionPercent"].Value.ToString() != "")
                            {
                                oFacturaBases.Retencion = Convert.ToDecimal(dtgFilas.Cells["RetencionPercent"].Value.ToString());
                            }
                        }
                        if (dtgFilas.Cells["Retencion"].Value != null)
                        {
                            if (dtgFilas.Cells["Retencion"].Value.ToString() != "")
                            {
                                oFacturaBases.CuotaRetencion = Convert.ToDecimal(dtgFilas.Cells["Retencion"].Value.ToString());
                            }
                        }
                        SGPADatos.FacturasBases.Add(oFacturaBases);
                        SGPADatos.SaveChanges();
                    }
                    foreach (Clases.RecibosFactura oRecibo in oRecibosFacturas)
                    {
                        var oReciboBD = new Recibos();
                        oReciboBD.FacturaId = oFactura.FacturaId;
                        oReciboBD.Fecha = oRecibo.Fecha;
                        oReciboBD.Importe = oRecibo.Importe;
                        oReciboBD.PlazoId = oRecibo.PlazoId;
                        oReciboBD.Cobrado = false;
                        SGPADatos.Recibos.Add(oReciboBD);
                    }
                    SGPADatos.SaveChanges();
                    txtNumeroFactura.Text = oFactura.FacturaId.ToString();
                    FinalizarFactura(oFactura.FacturaId);
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
            return bolEditado;
        }
        public bool Guardar()
        {
            try
            {
                bool bolContinuarAlbaranes = true;
                if (ValidarGuardar())
                {
                    if (bolAlbaranes)
                    {
                        DialogResult _Dial = MessageBox.Show("¿La factura será finalizada al provenir de albaranes desea continuar?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (_Dial == DialogResult.Yes)
                        {
                        }
                        else
                        {
                            bolContinuarAlbaranes = false;
                        }
                    }
                    if (bolContinuarAlbaranes)
                    {
                        //Se guarda primero la maestra de la factura
                        var oFactura = new Facturas();
                        oFactura.ClienteId = Convert.ToInt32(txtClienteId.Text);
                        oFactura.EmpresaId = FrmPadre.dcmCodCompania;
                        oFactura.Fecha = dtpFecha.Value;
                        oFactura.Impreso = false;
                        if (txtPresupuesto.Text != "")
                        {
                            oFactura.PresupuestoId = Convert.ToDecimal(txtPresupuesto.Text);
                        }
                        oFactura.FormaPagoId = Convert.ToDecimal(cmbFormaPago.SelectedValue.ToString());
                        oFactura.FacturaRecargo = chkRecargo.Checked;
                        if (bolAlbaranes)
                        {
                            oFactura.Finalizado = true;
                            oFactura.Albaran = true;
                        }
                        else
                        {
                            oFactura.Finalizado = bolFacturaFinalizada;
                            oFactura.Albaran = false;
                        }
                        SGPADatos.Facturas.Add(oFactura);
                        SGPADatos.SaveChanges();
                        //Si la factura proviene de albaranes, estos se modifican
                        if (bolAlbaranes)
                        {
                            foreach (AlbaranesClientes oAlbaranes in listAlbaranesClientes)
                            {
                                var oAlbaran = SGPADatos.AlbaranesClientes.FirstOrDefault(a => a.AlbaranId == oAlbaranes.AlbaranId && a.EmpresaId == oAlbaranes.EmpresaId);
                                oAlbaran.FacturaId = oFactura.FacturaId;
                                oAlbaran.Facturado = true;
                                SGPADatos.SaveChanges();
                            }
                        }
                        
                        //Se guarda el detalle de la factura
                        foreach (DataGridViewRow dtgFilas in dtgArticulosFacturas.Rows)
                        {
                            var oFacturaDetalle = new FacturasDetalles();
                            oFacturaDetalle.FacturaId = oFactura.FacturaId;
                            oFacturaDetalle.ArticuloId = Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString());
                            oFacturaDetalle.Cantidad = Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString());
                            oFacturaDetalle.Precio = Convert.ToDecimal(dtgFilas.Cells["Precio"].Value.ToString());
                            if (dtgFilas.Cells["Dcto"].Value != null)
                            {
                                if (dtgFilas.Cells["Dcto"].Value.ToString() != "")
                                {
                                    oFacturaDetalle.Descuento = Convert.ToDecimal(dtgFilas.Cells["Dcto"].Value.ToString());
                                }
                            }
                            oFacturaDetalle.IVA = Convert.ToDecimal(dtgFilas.Cells["IVA"].Value.ToString());
                            oFacturaDetalle.Subtotal = Convert.ToDecimal(dtgFilas.Cells["Importe"].Value.ToString());
                            SGPADatos.FacturasDetalles.Add(oFacturaDetalle);
                            SGPADatos.SaveChanges();
                            if (!bolAlbaranes)
                            {
                                Clases.ManejoComprometidos oManejoComprometido = new Clases.ManejoComprometidos();
                                oManejoComprometido.InsertarMovimientoComprometido(Convert.ToDecimal(dtgFilas.Cells["ArticuloId"].Value.ToString()), Convert.ToDecimal(dtgFilas.Cells["Cantidad"].Value.ToString()), oFactura.FacturaId, "FACTURA");
                            }
                        }
                        //Se guarda las bases de la factura
                        foreach (DataGridViewRow dtgFilas in dtgBasesFacturas.Rows)
                        {
                            var oFacturaBases = new FacturasBases();
                            oFacturaBases.FacturaId = oFactura.FacturaId;
                            oFacturaBases.Base = Convert.ToDecimal(dtgFilas.Cells["BaseTotal"].Value.ToString());
                            oFacturaBases.IVA = Convert.ToDecimal(dtgFilas.Cells["IVATotal"].Value.ToString());
                            oFacturaBases.CuotaIVA = Convert.ToDecimal(dtgFilas.Cells["CuotaIVA"].Value.ToString());
                            oFacturaBases.RecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["Recargo"].Value.ToString());
                            oFacturaBases.CuotaRecargoEquivalencia = Convert.ToDecimal(dtgFilas.Cells["CuotaRecargo"].Value.ToString());
                            if (dtgFilas.Cells["RetencionPercent"].Value != null)
                            {
                                if (dtgFilas.Cells["RetencionPercent"].Value.ToString() != "")
                                {
                                    oFacturaBases.Retencion = Convert.ToDecimal(dtgFilas.Cells["RetencionPercent"].Value.ToString());
                                }
                            }
                            if (dtgFilas.Cells["Retencion"].Value != null)
                            {
                                if (dtgFilas.Cells["Retencion"].Value.ToString() != "")
                                {
                                    oFacturaBases.CuotaRetencion = Convert.ToDecimal(dtgFilas.Cells["Retencion"].Value.ToString());
                                }
                            }
                            SGPADatos.FacturasBases.Add(oFacturaBases);
                            SGPADatos.SaveChanges();
                        }
                        foreach (Clases.RecibosFactura oRecibo in oRecibosFacturas)
                        {
                            var oReciboBD = new Recibos();
                            oReciboBD.FacturaId = oFactura.FacturaId;
                            oReciboBD.Fecha = oRecibo.Fecha;
                            oReciboBD.Importe = oRecibo.Importe;
                            oReciboBD.PlazoId = oRecibo.PlazoId;
                            oReciboBD.Cobrado = false;
                            SGPADatos.Recibos.Add(oReciboBD);
                        }
                        SGPADatos.SaveChanges();
                        txtNumeroFactura.Text = oFactura.FacturaId.ToString();
                        //Si se copió de un presupuesto debe modificarse el campo facturado en el presupuesto
                        if (txtPresupuesto.Text != "")
                        {
                            var oPresupuesto = SGPADatos.Presupuestos.FirstOrDefault(a => a.PresupuestoId.ToString() == txtPresupuesto.Text && a.EmpresaId == FrmPadre.dcmCodCompania);
                            oPresupuesto.Facturado = true;
                            SGPADatos.SaveChanges();
                        }
                        FinalizarFactura(oFactura.FacturaId);
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
        }
        private void CargarData(decimal dcmFacturaId)
        {
            try
            {
                btnCopiarAlbaranes.Enabled = false;
                var oFactura = SGPADatos.Facturas.FirstOrDefault(a => a.FacturaId == dcmFacturaId);
                if (oFactura != null)
                {
                    bolFacturaFinalizada = oFactura.Finalizado;
                    txtNumeroFactura.Text = oFactura.FacturaId.ToString();
                    txtClienteId.Text = oFactura.ClienteId.ToString();
                    txtNIF.Text = oFactura.Clientes.Identificacion.ToString();
                    dtpFecha.Value = oFactura.Fecha;
                    txtPresupuesto.Text = oFactura.PresupuestoId.ToString();
                    var oRecibosFacturasData = SGPADatos.Recibos.Where(a => a.FacturaId == oFactura.FacturaId).AsNoTracking();
                    txtNumeroPlazos.Text = oRecibosFacturasData.Count().ToString();
                    foreach (Recibos oRecibo in oRecibosFacturasData)
                    {
                        var oReciboFactura = new Clases.RecibosFactura();
                        oReciboFactura.Fecha = oRecibo.Fecha;
                        oReciboFactura.Importe = oRecibo.Importe;
                        oReciboFactura.PlazoId = oRecibo.PlazoId;
                        oRecibosFacturas.Add(oReciboFactura);
                    }
                    txtNombreCliente.Text = oFactura.Clientes.NombreCliente.ToString();
                    var oFormaPago = SGPADatos.FormasPagos.FirstOrDefault(a => a.FormaPagoId == oFactura.FormaPagoId);
                    Clases.Utilidades.AsignarValorCombo(cmbFormaPago, oFormaPago.Descripcion);
                    var oFacturasDetalles = SGPADatos.FacturasDetalles.Where(a => a.FacturaId == oFactura.FacturaId);
                    foreach (FacturasDetalles oFacturaDetalleFila in oFacturasDetalles)
                    {
                        dtgArticulosFacturas.Rows.Add(oFacturaDetalleFila.Articulos.Descripcion.ToString(), oFacturaDetalleFila.ArticuloId.ToString(), oFacturaDetalleFila.Cantidad.ToString(), string.Format("{0:n}", oFacturaDetalleFila.Precio), string.Format("{0:n}", oFacturaDetalleFila.Descuento), string.Format("{0:n}", oFacturaDetalleFila.IVA), string.Format("{0:n}", oFacturaDetalleFila.Subtotal));
                    }
                    var oFacturasBases = SGPADatos.FacturasBases.Where(a => a.FacturaId == oFactura.FacturaId);
                    foreach (FacturasBases oFacturaBaseFila in oFacturasBases)
                    {
                        dtgBasesFacturas.Rows.Add(string.Format("{0:n}", oFacturaBaseFila.Base), string.Format("{0:n}", oFacturaBaseFila.IVA), string.Format("{0:n}", oFacturaBaseFila.CuotaIVA), string.Format("{0:n}", oFacturaBaseFila.Base + oFacturaBaseFila.CuotaIVA), string.Format("{0:n}", oFacturaBaseFila.RecargoEquivalencia), string.Format("{0:n}", oFacturaBaseFila.CuotaRecargoEquivalencia), string.Format("{0:n}", oFacturaBaseFila.Retencion), string.Format("{0:n}", oFacturaBaseFila.CuotaRetencion));
                    }
                    chkRecargo.Checked = (bool)oFactura.FacturaRecargo;
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
                    CargarData(Convert.ToDecimal(dtgConsulta.SelectedRows[0].Cells["FacturaId"].Value.ToString()));
                    btnBuscarPresupuesto.Enabled = false;
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

        private void dtgArticulosPresupuesto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dtgArticulosFacturas.RowCount >= 0)
                {
                    Cursor = Cursors.WaitCursor;
                    if (dtgArticulosFacturas.SelectedRows.Count == 1)
                    {
                        btnEliminarArticulo.Visible = true;
                    }
                    else
                    {
                        btnEliminarArticulo.Visible = false;
                    }
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ou)
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
                    if (dtgArticulosFacturas.SelectedRows.Count == 1)
                    {
                        //decimal dcmArticuloPresupuestoId = Convert.ToDecimal(dtgArticulosPresupuesto.SelectedRows[0].Cells["ArticuloId"].Value.ToString());
                        dtgArticulosFacturas.Rows.RemoveAt(dtgArticulosFacturas.SelectedRows[0].Index);
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
        private void CargarDataPresupuesto(decimal dcmPresupuestoId)
        {
            try
            {
                bool bolInventarioSinExistencia = false;
                var oPresupuesto = SGPADatos.Presupuestos.FirstOrDefault(a => a.PresupuestoId == dcmPresupuestoId);
                if (oPresupuesto != null)
                {
                    txtClienteId.Text = oPresupuesto.ClienteId.ToString();
                    txtNIF.Text = oPresupuesto.Clientes.Identificacion.ToString();
                    txtNombreCliente.Text = oPresupuesto.Clientes.NombreCliente.ToString();
                    var oPresupuestosDetalles = SGPADatos.PresupuestosDetalles.Where(a => a.PresupuestoId == oPresupuesto.PresupuestoId);
                    foreach (PresupuestosDetalles oPresupuestoDetalleFila in oPresupuestosDetalles)
                    {
                        //Se debe validar inventario
                        if (txtNumeroFactura.Text == "")
                        {
                            //Factura nueva                            
                            var oArticulosInventario = SGPADatos.vw_ArticulosConsulta.FirstOrDefault(a => a.ArticuloId == oPresupuestoDetalleFila.ArticuloId && a.EmpresaId == FrmPadre.dcmCodCompania);
                            if (oArticulosInventario != null)
                            {
                                if ((oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida) < oPresupuestoDetalleFila.Cantidad)
                                {
                                    dtgArticulosFacturas.Rows.Add(oPresupuestoDetalleFila.Articulos.Descripcion.ToString(), oPresupuestoDetalleFila.ArticuloId.ToString(), "0", string.Format("{0:n}", oPresupuestoDetalleFila.Precio), string.Format("{0:n}", oPresupuestoDetalleFila.Descuento), string.Format("{0:n}", oPresupuestoDetalleFila.IVA), string.Format("{0:n}", "0,00"));
                                    MessageBox.Show("No puede ingresar mas de " + (oArticulosInventario.Cantidad - oArticulosInventario.CantidadComprometida).ToString() + " Unds del artículo " + oArticulosInventario.Descripcion, FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    dtgArticulosFacturas.Rows.Add(oPresupuestoDetalleFila.Articulos.Descripcion.ToString(), oPresupuestoDetalleFila.ArticuloId.ToString(), oPresupuestoDetalleFila.Cantidad.ToString(), string.Format("{0:n}", oPresupuestoDetalleFila.Precio), string.Format("{0:n}", oPresupuestoDetalleFila.Descuento), string.Format("{0:n}", oPresupuestoDetalleFila.IVA), string.Format("{0:n}", oPresupuestoDetalleFila.Subtotal));
                                }
                            }
                            else
                            {
                                bolInventarioSinExistencia = true;                                
                            }
                        }
                    }
                    var oPresupuestosBases = SGPADatos.PresupuestosBases.Where(a => a.PresupuestoId == oPresupuesto.PresupuestoId);
                    foreach (PresupuestosBases oPresupuestoBaseFila in oPresupuestosBases)
                    {
                        dtgBasesFacturas.Rows.Add(string.Format("{0:n}", oPresupuestoBaseFila.Base), string.Format("{0:n}", oPresupuestoBaseFila.IVA), string.Format("{0:n}", oPresupuestoBaseFila.CuotaIVA), string.Format("{0:n}", oPresupuestoBaseFila.Base + oPresupuestoBaseFila.CuotaIVA), string.Format("{0:n}", oPresupuestoBaseFila.RecargoEquivalencia), string.Format("{0:n}", oPresupuestoBaseFila.CuotaRecargoEquivalencia), string.Format("{0:n}", oPresupuestoBaseFila.Retencion), string.Format("{0:n}", oPresupuestoBaseFila.CuotaRetencion));
                    }
                    chkRecargo.Checked = (bool)oPresupuesto.PresupuestoRecargo;
                    LlenarGridBases();
                    Totalizar();
                    btnBuscarPresupuesto.Enabled = false;
                    if (bolInventarioSinExistencia)
                    {
                        MessageBox.Show("Uno o mas artículos no pudieron ser ingresados por no haber existencia", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
            }
        }
        private void btnBuscarPresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                string strPresupuestoId = "";
                FrmBusquedaPresupuestos frmBusquedaPresupuesto = new FrmBusquedaPresupuestos();
                frmBusquedaPresupuesto.ShowDialog();
                strPresupuestoId = frmBusquedaPresupuesto.strPresupuestoId;
                if (strPresupuestoId.Trim() != "")
                {
                    var oPresupuesto = SGPADatos.Presupuestos.FirstOrDefault(a => a.EmpresaId == FrmPadre.dcmCodCompania && a.PresupuestoId.ToString() == strPresupuestoId);
                    if (oPresupuesto != null)
                    {
                        txtPresupuesto.Text = oPresupuesto.PresupuestoId.ToString();
                        CargarDataPresupuesto(oPresupuesto.PresupuestoId);
                        btnCopiarAlbaranes.Enabled = false;
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

        private void txtNumeroPlazos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnVencimiento_Click(object sender, EventArgs e)
        {
            if (txtNumeroPlazos.Text != "")
            {
                if (txtNumeroPlazos.Text != "0")
                {
                    if (oRecibosFacturas.Count() != Convert.ToInt32(txtNumeroPlazos.Text))
                    {
                        oRecibosFacturas.Clear();
                        decimal dcmImporte = 0;
                        decimal.TryParse(txtTotal.Text, out dcmImporte);
                        if (dcmImporte > 0)
                        {
                            FrmVencimientoPlazos frmVencimientosPlazos = new FrmVencimientoPlazos(dtpFecha.Value.ToString("dd/MM/yyyy"), Convert.ToInt32(txtNumeroPlazos.Text), Convert.ToDecimal(txtTotal.Text), dtpFecha.Value.ToString("dd/MM/yyyy"));
                            frmVencimientosPlazos.ShowDialog();
                            oRecibosFacturas = frmVencimientosPlazos.oRecibosFacturas;
                        }
                        else
                        {
                            MessageBox.Show("El monto del importe debe ser mayor a 0", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        decimal dcmImporte = 0;
                        decimal.TryParse(txtTotal.Text, out dcmImporte);
                        if (dcmImporte > 0)
                        {
                            FrmVencimientoPlazos frmVencimientosPlazos = new FrmVencimientoPlazos(oRecibosFacturas, dtpFecha.Value.ToString("dd/MM/yyyy"));
                            frmVencimientosPlazos.ShowDialog();
                            oRecibosFacturas = frmVencimientosPlazos.oRecibosFacturas;
                        }
                        else
                        {
                            MessageBox.Show("El monto del importe debe ser mayor a 0", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el número de plazos", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el número de plazos", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool bolFacturaFinalizada = false;
        private void FinalizarFactura(decimal dcmFacturaId)
        {
            try
            {
                if (bolFacturaFinalizada)
                {
                    //Se finaliza la factura
                    var oFactura = SGPADatos.Facturas.FirstOrDefault(a => a.FacturaId == dcmFacturaId && a.EmpresaId == FrmPadre.dcmCodCompania);
                    oFactura.Finalizado = bolFacturaFinalizada;
                    var oFacturasDetalles = SGPADatos.FacturasDetalles.Where(a => a.FacturaId == dcmFacturaId);
                    if (!bolAlbaranes)
                    {
                        foreach (FacturasDetalles oFacturaFilas in oFacturasDetalles)
                        {
                            //Se genera el movimiento de inventario en existencias reales
                            Clases.ManejoInventario oManejoInventario = new Clases.ManejoInventario();
                            oManejoInventario.InsertarMovimientoInventario(oFacturaFilas.ArticuloId, oFacturaFilas.Cantidad, oFactura.FacturaId, "FACTURA");
                        }
                    }
                }
            }
            catch
            {
            }
        }
        
        private void btnFinalizarFactura_Click(object sender, EventArgs e)
        {
            DialogResult _Dial = MessageBox.Show("¿Desea finalizar la factura actual, luego no podrá ser modificada?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_Dial == DialogResult.Yes)
            {
                if (txtNumeroFactura.Text == "")
                {
                    //Factura Nueva
                    bolFacturaFinalizada = true;
                    Guardar();
                }
                else
                {
                    //Factura Editada
                    bolFacturaFinalizada = true;
                    Modificar();
                }
            }
        }
        List<AlbaranesClientes> listAlbaranesClientes = new List<AlbaranesClientes>();
        private void btnCopiarAlbaranes_Click(object sender, EventArgs e)
        {
            try
            {
                //Copiar albaranes
                FrmCopiarAlbaranes frmCopiarAlabaranes = new FrmCopiarAlbaranes();
                frmCopiarAlabaranes.ShowDialog();
                if (frmCopiarAlabaranes.listAlbaranesClientes.Count() > 0)
                {
                    listAlbaranesClientes = frmCopiarAlabaranes.listAlbaranesClientes;
                    var oCliente = frmCopiarAlabaranes.listAlbaranesClientes.First().Clientes;
                    txtClienteId.Text = oCliente.ClienteId.ToString();
                    txtNIF.Text = oCliente.Identificacion.ToString();
                    txtNombreCliente.Text = oCliente.NombreCliente.ToString();
                    bolAlbaranes = true;
                    var oArticulos = (from p in frmCopiarAlabaranes.listAlbaranesClientesDetalles select p.ArticuloId).Distinct();
                    foreach (decimal oArticuloId in oArticulos)
                    {
                        var oArticulo = SGPADatos.Articulos.FirstOrDefault(a => a.ArticuloId == oArticuloId && a.EmpresaId == FrmPadre.dcmCodCompania);
                        decimal dcmPrecio = frmCopiarAlabaranes.listAlbaranesClientesDetalles.FirstOrDefault(a => a.ArticuloId == oArticuloId).Precio;
                        decimal dcmDescuento = frmCopiarAlabaranes.listAlbaranesClientesDetalles.FirstOrDefault(a => a.ArticuloId == oArticuloId).Descuento;
                        decimal dcmIVA = frmCopiarAlabaranes.listAlbaranesClientesDetalles.FirstOrDefault(a => a.ArticuloId == oArticuloId).IVA;
                        decimal dcmCantidad = frmCopiarAlabaranes.listAlbaranesClientesDetalles.Where(a => a.ArticuloId == oArticuloId).Sum(a => a.Cantidad);
                        decimal dcmSubtotal = frmCopiarAlabaranes.listAlbaranesClientesDetalles.Where(a => a.ArticuloId == oArticuloId).Sum(a => a.Subtotal);
                        dtgArticulosFacturas.Rows.Add(oArticulo.Descripcion.ToString(), oArticulo.ArticuloId.ToString(), dcmCantidad, string.Format("{0:n}", dcmPrecio), string.Format("{0:n}", dcmDescuento), string.Format("{0:n}", dcmIVA), string.Format("{0:n}", dcmSubtotal));
                    }
                    var oBases = (from p in frmCopiarAlabaranes.listAlbaranesClientesBases select p.IVA).Distinct();
                    foreach (decimal oBase in oBases)
                    {
                        decimal dcmBase = frmCopiarAlabaranes.listAlbaranesClientesBases.Where(a => a.IVA == oBase).Sum(a => a.Base);
                        decimal dcmCuotaIVA = frmCopiarAlabaranes.listAlbaranesClientesBases.Where(a => a.IVA == oBase).Sum(a => a.CuotaIVA);
                        decimal dcmRecargoEquivalencia = frmCopiarAlabaranes.listAlbaranesClientesBases.FirstOrDefault(a => a.IVA == oBase).RecargoEquivalencia;
                        decimal dcmCuotaRecargo = frmCopiarAlabaranes.listAlbaranesClientesBases.Where(a => a.IVA == oBase).Sum(a => a.CuotaRecargoEquivalencia);
                        decimal dcmRetencion = frmCopiarAlabaranes.listAlbaranesClientesBases.FirstOrDefault(a => a.IVA == oBase).Retencion;
                        decimal dcmCuotaRetencion = frmCopiarAlabaranes.listAlbaranesClientesBases.Where(a => a.IVA == oBase).Sum(a => a.CuotaRetencion);
                        dtgBasesFacturas.Rows.Add(string.Format("{0:n}", dcmBase), string.Format("{0:n}", oBase), string.Format("{0:n}", dcmCuotaIVA), string.Format("{0:n}", dcmBase + dcmCuotaIVA), string.Format("{0:n}", dcmRecargoEquivalencia), string.Format("{0:n}", dcmCuotaRecargo), string.Format("{0:n}", dcmRetencion), string.Format("{0:n}", dcmCuotaRetencion));
                    }
                    chkRecargo.Checked = (bool)frmCopiarAlabaranes.listAlbaranesClientes.First().AlbaranesRecargo;
                    LlenarGridBases();
                    Totalizar();
                    btnCopiarAlbaranes.Enabled = false;
                    btnBuscarClientes.Enabled = false;
                    btnFinalizarFactura.Enabled = false;                   
                    btnBuscarPresupuesto.Enabled = false;
                    btnEliminarArticulo.Enabled = false;
                    btnBuscarArticulos.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un albaran para continuar", FrmPadre.strNombreSistema + FrmPadre.strVersionSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
            }
        }
    }
}
