//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pasvlas
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PodgotovkaEntities6 : DbContext
    {
        public PodgotovkaEntities6()
            : base("name=PodgotovkaEntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<patients> patients { get; set; }
        public virtual DbSet<services> services { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
