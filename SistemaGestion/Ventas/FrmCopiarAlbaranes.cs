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

namespace SistemaGestion.Ventas
{
    public partial class FrmCopiarAlbaranes : Form
    {
        SGPAEntities SGPADatos = new SGPAEntities();
        public FrmCopiarAlbaranes()
        {
            InitializeComponent();
            LlenarGrid("");
        }
        public string strProductoId = "";
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LlenarGrid(txtConsulta.Text);
            Cursor = Cursors.Default;
        }
        private void LlenarGrid(string strBusqueda)
        {
            try
            {
                dtgConsulta.AutoGenerateColumns = false;
                dtgConsulta.DataSource = (from albaranes in SGPADatos.vw_AlbaranesClientesConsulta where (albaranes.NombreCliente.Contains(strBusqueda) || albaranes.Identificacion.Contains(strBusqueda) || albaranes.ClienteId.ToString().Contains(strBusqueda)) && albaranes.EmpresaId.ToString() == FrmPadre.strEmpresa && albaranes.Finalizado=="SI" && !albaranes.Facturado select albaranes).ToList();
                dtgConsulta.Columns[0].Width = 80;
            }
            catch
            {
            }
        }

       
        List<decimal> listAlbaranes = new List<decimal>();
        List<AlbaranesClientes> listAlbaranesParaAgregar = new List<AlbaranesClientes>();
        List<AlbaranesClientes> listAlbaranesParaEliminar = new List<AlbaranesClientes>();
        public List<AlbaranesClientes> listAlbaranesClientes = new List<AlbaranesClientes>();
        public List<AlbaranesClientesBases> listAlbaranesClientesBases = new List<AlbaranesClientesBases>();
        public List<AlbaranesClientesDetalles> listAlbaranesClientesDetalles = new List<AlbaranesClientesDetalles>();
        private bool GenerarDatos()
        {
            listAlbaranes = new List<decimal>();
            listAlbaranesParaEliminar = new List<AlbaranesClientes>();
            listAlbaranesParaAgregar = new List<AlbaranesClientes>();
            listAlbaranesClientes = new List<AlbaranesClientes>();
            listAlbaranesClientesBases = new List<AlbaranesClientesBases>();
            listAlbaranesClientesDetalles = new List<AlbaranesClientesDetalles>();
            bool bolValido = true;            
            foreach (DataGridViewRow dtgFila in dtgConsulta.Rows)
            {
                if (Convert.ToBoolean(dtgFila.Cells[Agregar.Name].Value) == true)
                {
                    //Albaranes por copiar
                    decimal dcmAlbaranId = Convert.ToDecimal(dtgFila.Cells["AlbaranId"].Value);
                    listAlbaranes.Add(dcmAlbaranId);                    
                }                
            }
            foreach (decimal dcmAlbaranId in listAlbaranes)
            {
                var oAlbaran = SGPADatos.AlbaranesClientes.FirstOrDefault(a => a.AlbaranId == dcmAlbaranId && a.EmpresaId == FrmPadre.dcmCodCompania);
                listAlbaranesClientes.Add(oAlbaran);
            }
            foreach (decimal dcmAlbaranId in listAlbaranes)
            {
                var oAlbaranDetalle = SGPADatos.AlbaranesClientesDetalles.FirstOrDefault(a => a.AlbaranId == dcmAlbaranId);
                listAlbaranesClientesDetalles.Add(oAlbaranDetalle);
            }
            foreach (decimal dcmAlbaranId in listAlbaranes)
            {
                var oAlbaranBase = SGPADatos.AlbaranesClientesBases.FirstOrDefault(a => a.AlbaranId == dcmAlbaranId);
                listAlbaranesClientesBases.Add(oAlbaranBase);
            }

            //Comienza la validación
            foreach (AlbaranesClientes oAlbaranCliente in listAlbaranesClientes.OrderBy(a=>a.AlbaranId))
            {
                var oAlbaraExiste = listAlbaranesParaAgregar.FirstOrDefault(a=>a.AlbaranId==oAlbaranCliente.AlbaranId && a.EmpresaId==oAlbaranCliente.EmpresaId);
                if(oAlbaraExiste==null)
                {
                    var oAlbaraExisteEliminar = listAlbaranesParaEliminar.FirstOrDefault(a => a.AlbaranId == oAlbaranCliente.AlbaranId && a.EmpresaId == oAlbaranCliente.EmpresaId);
                    if (oAlbaraExisteEliminar == null)
                    {
                        listAlbaranesParaAgregar.Add(oAlbaranCliente);
                    }
                }
                foreach (AlbaranesClientes oAlbaranCliente2 in listAlbaranesClientes.OrderBy(a => a.AlbaranId))
                {
                    if (oAlbaranCliente.ClienteId != oAlbaranCliente2.ClienteId || oAlbaranCliente.AlbaranesRecargo != oAlbaranCliente.AlbaranesRecargo)
                    {
                        oAlbaraExiste = listAlbaranesParaEliminar.FirstOrDefault(a => a.AlbaranId == oAlbaranCliente2.AlbaranId && a.EmpresaId == oAlbaranCliente2.EmpresaId);
                        if (oAlbaraExiste == null)
                        {
                            var oAlbaraExisteAdd = listAlbaranesParaAgregar.FirstOrDefault(a => a.AlbaranId == oAlbaranCliente2.AlbaranId && a.EmpresaId == oAlbaranCliente2.EmpresaId);
                            if (oAlbaraExisteAdd == null)
                            {
                                listAlbaranesParaEliminar.Add(oAlbaranCliente2);
                            }
                        }
                        bolValido = false;
                    }
                }
                foreach (AlbaranesClientesDetalles oAlbaranDetalle in listAlbaranesClientesDetalles.OrderBy(a => a.AlbaranId))
                {
                    foreach (AlbaranesClientesDetalles oAlbaranDetalle2 in listAlbaranesClientesDetalles.OrderBy(a => a.AlbaranId))
                    {
                        if (oAlbaranDetalle.ArticuloId == oAlbaranDetalle2.ArticuloId && (oAlbaranDetalle.Precio != oAlbaranDetalle2.Precio || oAlbaranDetalle.Descuento != oAlbaranDetalle2.Descuento || oAlbaranDetalle.IVA != oAlbaranDetalle2.IVA))
                        {
                            oAlbaraExiste = listAlbaranesParaEliminar.FirstOrDefault(a => a.AlbaranId == oAlbaranDetalle2.AlbaranesClientes.AlbaranId && a.EmpresaId == oAlbaranDetalle2.AlbaranesClientes.EmpresaId);
                            if (oAlbaraExiste == null)
                            {
                                var oAlbaraExisteAdd = listAlbaranesParaAgregar.FirstOrDefault(a => a.AlbaranId == oAlbaranDetalle2.AlbaranesClientes.AlbaranId && a.EmpresaId == oAlbaranDetalle2.AlbaranesClientes.EmpresaId);
                                if (oAlbaraExisteAdd == null)
                                {
                                    listAlbaranesParaEliminar.Add(oAlbaranDetalle2.AlbaranesClientes);
                                }
                            }
                            bolValido = false;
                        }
                    }
                }
                foreach (AlbaranesClientesBases oAlbaranBase in listAlbaranesClientesBases.OrderBy(a => a.AlbaranId))
                {
                    foreach (AlbaranesClientesBases oAlbaranBase2 in listAlbaranesClientesBases.OrderBy(a => a.AlbaranId))
                    {
                        if (oAlbaranBase.IVA == oAlbaranBase2.IVA && (oAlbaranBase.RecargoEquivalencia != oAlbaranBase2.RecargoEquivalencia || oAlbaranBase.Retencion != oAlbaranBase2.Retencion))
                        {
                            oAlbaraExiste = listAlbaranesParaEliminar.FirstOrDefault(a => a.AlbaranId == oAlbaranBase2.AlbaranesClientes.AlbaranId && a.EmpresaId == oAlbaranBase2.AlbaranesClientes.EmpresaId);
                            if (oAlbaraExiste == null)
                            {
                                var oAlbaraExisteAdd = listAlbaranesParaAgregar.FirstOrDefault(a => a.AlbaranId == oAlbaranBase2.AlbaranesClientes.AlbaranId && a.EmpresaId == oAlbaranBase2.AlbaranesClientes.EmpresaId);
                                if (oAlbaraExisteAdd == null)
                                {
                                    listAlbaranesParaEliminar.Add(oAlbaranBase2.AlbaranesClientes);
                                }
                            }
                            bolValido = false;
                        }
                    }
                }
            }            
            return bolValido;
        }
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (GenerarDatos())
                {
                    //Es valido y pasa de una vez los datos al formulario de factura
                    this.Close();
                }
                else
                {
                    //No es valido y se pregunta si desea continuar con los parecidos
                    DialogResult _Dial = MessageBox.Show("Existen diferencias entre los albaranes elegidos, se generará la factura solo con los albaranes que no tengan diferencias, ¿Desea continuar?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (_Dial == DialogResult.Yes)
                    {
                        foreach (AlbaranesClientes oAlbaranIdEl in listAlbaranesParaEliminar)
                        {
                            var oAlbaranCliente = listAlbaranesClientes.FirstOrDefault(a => a.AlbaranId == oAlbaranIdEl.AlbaranId);
                            listAlbaranesClientes.Remove(oAlbaranCliente);
                            listAlbaranesClientesDetalles.RemoveAll(a => a.AlbaranId == oAlbaranIdEl.AlbaranId);
                            listAlbaranesClientesBases.RemoveAll(a => a.AlbaranId == oAlbaranIdEl.AlbaranId);
                        }
                    }
                    else
                    {
                        listAlbaranesClientes.Clear();
                    }
                    this.Close();
                }
            }
            catch
            {
            }
        }
    }
}
