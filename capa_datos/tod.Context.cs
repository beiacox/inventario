﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capa_datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using capa_entidad;

    public partial class todayEntities2 : DbContext
    {
        public todayEntities2()
            : base("name=todayEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<articulos> articulos { get; set; }
        public virtual DbSet<TPinventario> TPinventario { get; set; }
        public virtual DbSet<transacciones> transacciones { get; set; }
        public virtual DbSet<existenciasXalmacen> existenciasXalmacen { get; set; }
    }
}
