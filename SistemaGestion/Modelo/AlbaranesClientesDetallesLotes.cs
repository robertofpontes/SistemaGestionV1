//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaGestion.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlbaranesClientesDetallesLotes
    {
        public decimal AlbaranClienteDetalleLoteId { get; set; }
        public decimal AlbaranId { get; set; }
        public decimal ArticuloId { get; set; }
        public decimal LoteArticuloId { get; set; }
        public decimal Cantidad { get; set; }
    
        public virtual AlbaranesClientes AlbaranesClientes { get; set; }
        public virtual LotesArticulos LotesArticulos { get; set; }
    }
}