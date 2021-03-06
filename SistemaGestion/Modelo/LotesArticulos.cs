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
    
    public partial class LotesArticulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LotesArticulos()
        {
            this.FacturasDetallesLotes = new HashSet<FacturasDetallesLotes>();
            this.AlbaranesClientesDetallesLotes = new HashSet<AlbaranesClientesDetallesLotes>();
        }
    
        public decimal LoteArticuloId { get; set; }
        public decimal EmpresaId { get; set; }
        public decimal ArticuloId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal AlbaranId { get; set; }
        public bool PoseeFechaVencimiento { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public decimal CantidadComprometida { get; set; }
    
        public virtual Articulos Articulos { get; set; }
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturasDetallesLotes> FacturasDetallesLotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlbaranesClientesDetallesLotes> AlbaranesClientesDetallesLotes { get; set; }
    }
}
