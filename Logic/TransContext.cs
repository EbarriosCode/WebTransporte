namespace Logic
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TransContext : DbContext
    {
        public TransContext()
            : base("name=TransContext")
        {
        }

        public virtual DbSet<clientes> clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<clientes>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.dpi)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.nit)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.telefono)
                .IsUnicode(false);
        }
    }
}
