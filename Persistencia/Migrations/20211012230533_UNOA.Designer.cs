﻿// <auto-generated />
using AgroNuevo.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211012230533_UNOA")]
    partial class UNOA
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.Entidades.CostoProduccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ganancia")
                        .HasColumnType("int");

                    b.Property<int>("Gasto")
                        .HasColumnType("int");

                    b.Property<int>("Inversion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CostoProduccion");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CostoProduccion");
                });

            modelBuilder.Entity("Dominio.Entidades.DatosFinca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cantidadProductoSembrado")
                        .HasColumnType("int");

                    b.Property<int>("lotesDesignados")
                        .HasColumnType("int");

                    b.Property<string>("nombreFinca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DatosFinca");
                });

            modelBuilder.Entity("Dominio.Entidades.Insumos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantidadBodega")
                        .HasColumnType("int");

                    b.Property<int>("cantidadEntrada")
                        .HasColumnType("int");

                    b.Property<int>("cantidadSalida")
                        .HasColumnType("int");

                    b.Property<string>("fechaCompra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precioCompra")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Insumos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Insumos");
                });

            modelBuilder.Entity("Dominio.Entidades.ListaLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListaLogin");
                });

            modelBuilder.Entity("Dominio.Entidades.LoteFinca", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("cantidadPlantas")
                        .HasColumnType("int");

                    b.Property<string>("estadoCultivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroLote")
                        .HasColumnType("int");

                    b.Property<string>("tipoCultivo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoteFinca");
                });

            modelBuilder.Entity("Dominio.Entidades.ManoDeObra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("salario")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("ManoDeObra");
                });

            modelBuilder.Entity("Dominio.Entidades.Registro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("registros");
                });

            modelBuilder.Entity("Dominio.Entidades.Trazabilidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("encargado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaProduccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lugarProduccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trazabilidad");
                });

            modelBuilder.Entity("Dominio.Entidades.Cosecha", b =>
                {
                    b.HasBaseType("Dominio.Entidades.CostoProduccion");

                    b.Property<int>("codigoCosecha")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cosecha");
                });

            modelBuilder.Entity("Dominio.Entidades.Cultivos", b =>
                {
                    b.HasBaseType("Dominio.Entidades.CostoProduccion");

                    b.Property<int>("codigoCarga")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cultivos");
                });

            modelBuilder.Entity("Dominio.Entidades.Tecnico", b =>
                {
                    b.HasBaseType("Dominio.Entidades.CostoProduccion");

                    b.Property<int>("codigoTecnico")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("Dominio.Entidades.Agroquimicos", b =>
                {
                    b.HasBaseType("Dominio.Entidades.Insumos");

                    b.Property<string>("ingredienteActivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroAgroquimico")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Agroquimicos");
                });

            modelBuilder.Entity("Dominio.Entidades.FertilizantesEnmiendas", b =>
                {
                    b.HasBaseType("Dominio.Entidades.Insumos");

                    b.Property<int>("numeroRegistro")
                        .HasColumnType("int");

                    b.Property<string>("responsable")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("FertilizantesEnmiendas");
                });

            modelBuilder.Entity("Dominio.Entidades.Materiales", b =>
                {
                    b.HasBaseType("Dominio.Entidades.Insumos");

                    b.Property<int>("numeroMaterial")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Materiales");
                });
#pragma warning restore 612, 618
        }
    }
}
