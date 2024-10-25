using Microsoft.EntityFrameworkCore;
using SistemaCounterTex.Models;
using Microsoft.Win32;

using System;


namespace SistemaCounterTex.Data
{
    public class CounterTexDBContext : DbContext
    {
        public CounterTexDBContext(DbContextOptions<CounterTexDBContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Satelite> Satelites { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<PerfilAdministrador> PerfilAdministradores { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PerfilAdministrador>()
            .HasNoKey();

            modelBuilder.Entity<Satelite>()
            .HasOne(s => s.Usuario)
            .WithMany(u => u.Satelites)
            .HasForeignKey(s => s.IdUsuario);

            modelBuilder.Entity<PerfilAdministrador>()
                .HasOne(p => p.Usuario)
                .WithMany()
                .HasForeignKey(p => p.IdUsuario);

            modelBuilder.Entity<Usuario>(tb =>
            {

                tb.HasKey(col => col.IdUsuario);
                tb.Property(col => col.IdUsuario)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Correo).HasMaxLength(50);
                tb.Property(col => col.Clave).HasMaxLength(50);

            });

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }
    }
}
