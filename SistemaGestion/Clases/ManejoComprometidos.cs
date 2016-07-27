using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Clases
{
    class ManejoComprometidos
    {
        public void InsertarMovimientoComprometido(decimal dcmArticuloId, decimal Cantidad,decimal dcmDocumentoRelacionado, string strTipoDocumentoRelacionado)
        {
            try
            {
                Modelo.SGPAEntities SGPADatos = new Modelo.SGPAEntities();
                while (Cantidad > 0)
                {
                    var oLoteArticulo = SGPADatos.LotesArticulos.OrderBy(a => a.LoteArticuloId).FirstOrDefault(a => a.ArticuloId == dcmArticuloId && a.EmpresaId == FrmPadre.dcmCodCompania && (a.Cantidad-a.CantidadComprometida)>0);
                    decimal CantidadMaximaLote = (oLoteArticulo.Cantidad - oLoteArticulo.CantidadComprometida);
                    if (CantidadMaximaLote >= Cantidad)
                    {
                        //Si hay suficiente inventario en el lote actual
                        var oMovimientoComprometido = new Modelo.MovimientosInventarioComprometido();
                        oMovimientoComprometido.ArticuloId = dcmArticuloId;
                        oMovimientoComprometido.EmpresaId = FrmPadre.dcmCodCompania;
                        oMovimientoComprometido.LoteArticuloId = oLoteArticulo.LoteArticuloId;
                        oMovimientoComprometido.Cantidad = Cantidad;
                        oMovimientoComprometido.CantidadAntes = oLoteArticulo.CantidadComprometida;
                        oMovimientoComprometido.CantidadDespues = oLoteArticulo.CantidadComprometida+ Cantidad;
                        oMovimientoComprometido.TipoMovimiento = "E";
                        oMovimientoComprometido.TipoDocumentoRelacionado = strTipoDocumentoRelacionado;
                        oMovimientoComprometido.DocumentoRelacionado = dcmDocumentoRelacionado;                        
                        SGPADatos.MovimientosInventarioComprometido.Add(oMovimientoComprometido);
                        if (strTipoDocumentoRelacionado == "FACTURA")
                        {
                            var oFacturaDetalleLote = new Modelo.FacturasDetallesLotes();
                            oFacturaDetalleLote.ArticuloId = dcmArticuloId;
                            oFacturaDetalleLote.Cantidad = Cantidad;
                            oFacturaDetalleLote.FacturaId = dcmDocumentoRelacionado;
                            oFacturaDetalleLote.LoteArticuloId = oLoteArticulo.LoteArticuloId;
                            SGPADatos.FacturasDetallesLotes.Add(oFacturaDetalleLote);
                            SGPADatos.SaveChanges();
                        }
                        else if (strTipoDocumentoRelacionado == "ALBARAN")
                        {
                            var oAlbaranDetalleLote = new Modelo.AlbaranesClientesDetallesLotes();
                            oAlbaranDetalleLote.ArticuloId = dcmArticuloId;
                            oAlbaranDetalleLote.Cantidad = Cantidad;
                            oAlbaranDetalleLote.AlbaranId = dcmDocumentoRelacionado;
                            oAlbaranDetalleLote.LoteArticuloId = oLoteArticulo.LoteArticuloId;
                            SGPADatos.AlbaranesClientesDetallesLotes.Add(oAlbaranDetalleLote);
                            SGPADatos.SaveChanges();
                        }
                        Cantidad = 0;
                    }
                    else
                    {
                        //No hay suficiente inventario en el lote actual
                        var oMovimientoComprometido = new Modelo.MovimientosInventarioComprometido();
                        oMovimientoComprometido.ArticuloId = dcmArticuloId;
                        oMovimientoComprometido.EmpresaId = FrmPadre.dcmCodCompania;
                        oMovimientoComprometido.LoteArticuloId = oLoteArticulo.LoteArticuloId;
                        oMovimientoComprometido.Cantidad = CantidadMaximaLote;
                        oMovimientoComprometido.CantidadAntes = oLoteArticulo.CantidadComprometida;
                        oMovimientoComprometido.CantidadDespues = oLoteArticulo.CantidadComprometida + CantidadMaximaLote;
                        oMovimientoComprometido.TipoMovimiento = "E";
                        oMovimientoComprometido.TipoDocumentoRelacionado = strTipoDocumentoRelacionado;
                        oMovimientoComprometido.DocumentoRelacionado = dcmDocumentoRelacionado;
                        if (strTipoDocumentoRelacionado == "FACTURA")
                        {
                            var oFacturaDetalleLote = new Modelo.FacturasDetallesLotes();
                            oFacturaDetalleLote.ArticuloId = dcmArticuloId;
                            oFacturaDetalleLote.Cantidad = CantidadMaximaLote;
                            oFacturaDetalleLote.FacturaId = dcmDocumentoRelacionado;
                            oFacturaDetalleLote.LoteArticuloId = oLoteArticulo.LoteArticuloId;
                            SGPADatos.FacturasDetallesLotes.Add(oFacturaDetalleLote);
                            SGPADatos.SaveChanges();
                        }
                        else if (strTipoDocumentoRelacionado == "ALBARAN")
                        {
                            var oAlbaranDetalleLote = new Modelo.AlbaranesClientesDetallesLotes();
                            oAlbaranDetalleLote.ArticuloId = dcmArticuloId;
                            oAlbaranDetalleLote.Cantidad = Cantidad;
                            oAlbaranDetalleLote.AlbaranId = dcmDocumentoRelacionado;
                            oAlbaranDetalleLote.LoteArticuloId = oLoteArticulo.LoteArticuloId;
                            SGPADatos.AlbaranesClientesDetallesLotes.Add(oAlbaranDetalleLote);
                            SGPADatos.SaveChanges();
                        }
                        Cantidad = Cantidad - CantidadMaximaLote;
                        SGPADatos.MovimientosInventarioComprometido.Add(oMovimientoComprometido);
                    }                    
                    SGPADatos.SaveChanges();
                    //oMovimientoComprometido.LoteArticuloId
                }
            }
            catch
            {
            }
        }
    }
}
