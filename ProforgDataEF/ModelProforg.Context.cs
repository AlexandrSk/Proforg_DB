﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProforgDataEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBLibraryEntities : DbContext
    {
        public DBLibraryEntities()
            : base("name=DBLibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<groups> groups { get; set; }
        public virtual DbSet<tab_order> tab_order { get; set; }
        public virtual DbSet<tab_students> tab_students { get; set; }
        public virtual DbSet<tab_tickets> tab_tickets { get; set; }
        public virtual DbSet<ticket_type> ticket_type { get; set; }
        public virtual DbSet<LOGIN> LOGIN { get; set; }
    }
}
