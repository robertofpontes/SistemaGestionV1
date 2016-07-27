using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Clases
{
    class ManejoInventario
    {
        public void InsertarMovimientoInventario(decimal dcmArticuloId, decimal Cantidad, decimal dcmDocumentoRelacionado, string strTipoDocumentoRelacionado)
        {
            try
            {
                Modelo.SGPAEntities SGPADatos = new Modelo.SGPAEntities();
                if (strTipoDocumentoRelacionado == "FACTURA")
                {
                    var oFacturasDetallesLotes = SGPADatos.FacturasDetallesLotes.Where(a => a.FacturaId == dcmDocumentoRelacionado && a.ArticuloId == dcmArticuloId);
                    if (oFacturasDetallesLotes.Count() > 0)
                    {
                        foreach (Modelo.FacturasDetallesLotes oDetalle in oFacturasDetallesLotes)
                        {
                            var oLoteArticulo = SGPADatos.LotesArticulos.FirstOrDefault(a => a.ArticuloId == dcmArticuloId && a.EmpresaId == FrmPadre.dcmCodCompania && a.LoteArticuloId == oDetalle.LoteArticuloId);
                            var oMovimientoInventario = new Modelo.MovimientosInventario();
                            oMovimientoInventario.ArticuloId = dcmArticuloId;
                            oMovimientoInventario.EmpresaId = FrmPadre.dcmCodCompania;
                            oMovimientoInventario.Cantidad = oDetalle.Cantidad;
                            oMovimientoInventario.LoteArticuloId = oDetalle.LoteArticuloId;
                            oMovimientoInventario.TipoMovimiento = "S";
                            oMovimientoInventario.CantidadAntes = oLoteArticulo.Cantidad;
                            oMovimientoInventario.CantidadDespues = oLoteArticulo.Cantidad - oDetalle.Cantidad;
                            oMovimientoInventario.DocumentoRelacionado = oDetalle.FacturaId;
                            oMovimientoInventario.TipoDocumentoRelacionado = strTipoDocumentoRelacionado;
                            SGPADatos.MovimientosInventario.Add(oMovimientoInventario);                            
                        }
                        SGPADatos.SaveChanges();
                    }
                }
                else if (strTipoDocumentoRelacionado == "ALBARAN")
                {
                    var oAlbaranesDetallesLotes = SGPADatos.AlbaranesClientesDetallesLotes.Where(a => a.AlbaranId == dcmDocumentoRelacionado && a.ArticuloId == dcmArticuloId);
                    if (oAlbaranesDetallesLotes.Count() > 0)
                    {
                        foreach (Modelo.AlbaranesClientesDetallesLotes oDetalle in oAlbaranesDetallesLotes)
                        {
                            var oLoteArticulo = SGPADatos.LotesArticulos.FirstOrDefault(a => a.ArticuloId == dcmArticuloId && a.EmpresaId == FrmPadre.dcmCodCompania && a.LoteArticuloId == oDetalle.LoteArticuloId);
                            var oMovimientoInventario = new Modelo.MovimientosInventario();
                            oMovimientoInventario.ArticuloId = dcmArticuloId;
                            oMovimientoInventario.EmpresaId = FrmPadre.dcmCodCompania;
                            oMovimientoInventario.Cantidad = oDetalle.Cantidad;
                            oMovimientoInventario.LoteArticuloId = oDetalle.LoteArticuloId;
                            oMovimientoInventario.TipoMovimiento = "S";
                            oMovimientoInventario.CantidadAntes = oLoteArticulo.Cantidad;
                            oMovimientoInventario.CantidadDespues = oLoteArticulo.Cantidad - oDetalle.Cantidad;
                            oMovimientoInventario.DocumentoRelacionado = oDetalle.AlbaranId;
                            oMovimientoInventario.TipoDocumentoRelacionado = strTipoDocumentoRelacionado;
                            SGPADatos.MovimientosInventario.Add(oMovimientoInventario);
                        }
                        SGPADatos.SaveChanges();
                    }
                }
            }
            catch
            {
            }
        }        
    }
}
