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
    
    public partial class Articulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulos()
        {
            this.LotesArticulos = new HashSet<LotesArticulos>();
            this.MovimientosInventario = new HashSet<MovimientosInventario>();
            this.PresupuestosDetalles = new HashSet<PresupuestosDetalles>();
            this.FacturasDetalles = new HashSet<FacturasDetalles>();
            this.MovimientosInventarioComprometido = new HashSet<MovimientosInventarioComprometido>();
            this.AlbaranesClientesDetalles = new HashSet<AlbaranesClientesDetalles>();
        }
    
        public decimal ArticuloId { get; set; }
        public string Referencia { get; set; }
        public decimal EmpresaId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal ImpuestoId { get; set; }
        public string CodigoBarra { get; set; }
        public Nullable<decimal> UnidadManejoId { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        public virtual Impuestos Impuestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LotesArticulos> LotesArticulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientosInventario> MovimientosInventario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PresupuestosDetalles> PresupuestosDetalles { get; set; }
        public virtual UnidadManejo UnidadManejo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturasDetalles> FacturasDetalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientosInventarioComprometido> MovimientosInventarioComprometido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlbaranesClientesDetalles> AlbaranesClientesDetalles { get; set; }
    }
}
