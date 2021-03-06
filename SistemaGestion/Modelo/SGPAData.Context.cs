﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SGPAEntities : DbContext
    {
        public SGPAEntities()
            : base("name=SGPAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<FormasPagos> FormasPagos { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Retenciones> Retenciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<SistemaConfiguracion> SistemaConfiguracion { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Impuestos> Impuestos { get; set; }
        public virtual DbSet<AlbaranesClientes> AlbaranesClientes { get; set; }
        public virtual DbSet<AlbaranesClientesBases> AlbaranesClientesBases { get; set; }
        public virtual DbSet<LotesArticulos> LotesArticulos { get; set; }
        public virtual DbSet<MovimientosInventario> MovimientosInventario { get; set; }
        public virtual DbSet<Presupuestos> Presupuestos { get; set; }
        public virtual DbSet<PresupuestosBases> PresupuestosBases { get; set; }
        public virtual DbSet<PresupuestosDetalles> PresupuestosDetalles { get; set; }
        public virtual DbSet<UnidadManejo> UnidadManejo { get; set; }
        public virtual DbSet<vw_PresupuestosConsulta> vw_PresupuestosConsulta { get; set; }
        public virtual DbSet<vw_ArticulosConsulta> vw_ArticulosConsulta { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<FacturasBases> FacturasBases { get; set; }
        public virtual DbSet<FacturasDetalles> FacturasDetalles { get; set; }
        public virtual DbSet<Recibos> Recibos { get; set; }
        public virtual DbSet<vw_FacturasConsulta> vw_FacturasConsulta { get; set; }
        public virtual DbSet<AlbaranesClientesDetalles> AlbaranesClientesDetalles { get; set; }
        public virtual DbSet<MovimientosInventarioComprometido> MovimientosInventarioComprometido { get; set; }
        public virtual DbSet<vw_AlbaranesClientesConsulta> vw_AlbaranesClientesConsulta { get; set; }
        public virtual DbSet<FacturasDetallesLotes> FacturasDetallesLotes { get; set; }
        public virtual DbSet<AlbaranesClientesDetallesLotes> AlbaranesClientesDetallesLotes { get; set; }
    }
}
