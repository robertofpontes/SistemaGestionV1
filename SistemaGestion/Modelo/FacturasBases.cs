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
    
    public partial class FacturasBases
    {
        public decimal FacturaBaseId { get; set; }
        public decimal FacturaId { get; set; }
        public decimal Base { get; set; }
        public decimal IVA { get; set; }
        public decimal CuotaIVA { get; set; }
        public decimal RecargoEquivalencia { get; set; }
        public decimal CuotaRecargoEquivalencia { get; set; }
        public decimal Retencion { get; set; }
        public decimal CuotaRetencion { get; set; }
    
        public virtual Facturas Facturas { get; set; }
    }
}
