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
    
    public partial class Proveedores
    {
        public decimal ProveedorId { get; set; }
        public decimal EmpresaId { get; set; }
        public string NombreProveedor { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public decimal MunicipioId { get; set; }
        public string CodigoPostal { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string NumeroCuenta { get; set; }
        public string Iban { get; set; }
        public string Swift { get; set; }
        public string NombreBanco { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        public virtual Municipios Municipios { get; set; }
    }
}
