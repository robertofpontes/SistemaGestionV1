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
    
    public partial class vw_PresupuestosConsulta
    {
        public System.DateTime Fecha { get; set; }
        public decimal PresupuestoId { get; set; }
        public string Identificacion { get; set; }
        public string NombreCliente { get; set; }
        public Nullable<decimal> Base { get; set; }
        public Nullable<decimal> CuotaIVA { get; set; }
        public Nullable<decimal> CuotaRetencion { get; set; }
        public Nullable<decimal> Total { get; set; }
        public decimal EmpresaId { get; set; }
        public bool Facturado { get; set; }
        public decimal ClienteId { get; set; }
    }
}
