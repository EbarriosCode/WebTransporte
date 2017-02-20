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
        public virtual DbSet<departamento> departamento { get; set; }        
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

            modelBuilder.Entity<clientes>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<departamento>()
                .Property(e => e.nombreDepartamento)
                .IsUnicode(false);

            modelBuilder.Entity<departamento>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.departamento1)
                .HasForeignKey(e => e.departamento)
                .WillCascadeOnDelete();
        }
    }
}
