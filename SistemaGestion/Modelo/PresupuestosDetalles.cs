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
    
    public partial class PresupuestosDetalles
    {
        public decimal PresupuestoDetalleId { get; set; }
        public decimal PresupuestoId { get; set; }
        public decimal ArticuloId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }
        public decimal Subtotal { get; set; }
    
        public virtual Articulos Articulos { get; set; }
        public virtual Presupuestos Presupuestos { get; set; }
    }
}
