﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaCounterTex.Data;

#nullable disable

namespace SistemaCounterTex.Migrations
{
    [DbContext(typeof(CounterTexDBContext))]
    partial class CounterTexDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaCounterTex.Models.PerfilAdministrador", b =>
                {
                    b.Property<int>("IdAdministrador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAdministrador"));

                    b.Property<string>("BotonAyuda")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ChatInterno")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("ConsultarInformacion")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ControlHorarios")
                        .HasColumnType("datetime2");

                    b.Property<int>("ControlPrendas")
                        .HasColumnType("int");

                    b.Property<int>("Ganancias")
                        .HasColumnType("int");

                    b.Property<int>("Gastos")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("MetaPorCorte")
                        .HasColumnType("int");

                    b.Property<string>("NombreAdministrador")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Pagos")
                        .HasColumnType("int");

                    b.Property<int>("ProduccionDiaria")
                        .HasColumnType("int");

                    b.Property<int>("ProduccionMensual")
                        .HasColumnType("int");

                    b.Property<string>("Proveedor")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Registro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdAdministrador");

                    b.HasIndex("IdUsuario")
                        .IsUnique();

                    b.ToTable("PerfilAdministrador", (string)null);
                });

            modelBuilder.Entity("SistemaCounterTex.Models.PerfilEmpleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"));

                    b.Property<string>("BotonAyuda")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CantidadOperacion")
                        .HasColumnType("int");

                    b.Property<string>("ConsultarInformacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ControlHorarios")
                        .HasColumnType("datetime2");

                    b.Property<string>("Estadisticas")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("HoraEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraSalida")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("MetaPorCorte")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ProduccionDiaria")
                        .HasColumnType("int");

                    b.Property<string>("TipoOperacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TipoPrenda")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("ValorOperacion")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("IdEmpleado");

                    b.HasIndex("IdUsuario")
                        .IsUnique();

                    b.ToTable("PerfilEmpleado", (string)null);
                });

            modelBuilder.Entity("SistemaCounterTex.Models.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"));

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CantidadPrendas")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("PrecioPrenda")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<string>("TipoPrenda")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdProveedor");

                    b.ToTable("Proveedor", (string)null);
                });

            modelBuilder.Entity("SistemaCounterTex.Models.Registro", b =>
                {
                    b.Property<int>("IdRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegistro"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConfirmarContraseña")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdRegistro");

                    b.ToTable("Registro", (string)null);
                });

            modelBuilder.Entity("SistemaCounterTex.Models.Satelite", b =>
                {
                    b.Property<int>("SateliteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SateliteId"));

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Ganancias")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("Inventariomaquinas")
                        .HasColumnType("int");

                    b.Property<string>("Operacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PagoOperacion")
                        .HasColumnType("int");

                    b.Property<int>("PagoPrendas")
                        .HasColumnType("int");

                    b.Property<string>("TipoMaquina")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SateliteId");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Satelite", (string)null);
                });

            modelBuilder.Entity("SistemaCounterTex.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("SistemaCounterTex.Models.PerfilAdministrador", b =>
                {
                    b.HasOne("SistemaCounterTex.Models.Usuario", "Usuario")
                        .WithOne()
                        .HasForeignKey("SistemaCounterTex.Models.PerfilAdministrador", "IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaCounterTex.Models.PerfilEmpleado", b =>
                {
                    b.HasOne("SistemaCounterTex.Models.Usuario", "Usuario")
                        .WithOne()
                        .HasForeignKey("SistemaCounterTex.Models.PerfilEmpleado", "IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaCounterTex.Models.Satelite", b =>
                {
                    b.HasOne("SistemaCounterTex.Models.Usuario", "Usuario")
                        .WithMany("Satelites")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SistemaCounterTex.Models.Usuario", b =>
                {
                    b.Navigation("Satelites");
                });
#pragma warning restore 612, 618
        }
    }
}
