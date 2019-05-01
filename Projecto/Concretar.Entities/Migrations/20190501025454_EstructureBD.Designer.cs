﻿// <auto-generated />
using Concretar.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Concretar.Entities.Migrations
{
    [DbContext(typeof(ConcretarContext))]
    [Migration("20190501025454_EstructureBD")]
    partial class EstructureBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Concretar.Entities.Parametro", b =>
                {
                    b.Property<int>("ParametroId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Clave");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Valor");

                    b.HasKey("ParametroId");

                    b.ToTable("Parametro");
                });

            modelBuilder.Entity("Concretar.Entities.Permiso", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Funcionalidad");

                    b.Property<int>("VistaId");

                    b.HasKey("PermisoId");

                    b.HasIndex("VistaId");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("Concretar.Entities.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Nombre");

                    b.HasKey("RolId");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("Concretar.Entities.RolPermiso", b =>
                {
                    b.Property<int>("RolId");

                    b.Property<int>("PermisoId");

                    b.HasKey("RolId", "PermisoId");

                    b.HasIndex("PermisoId");

                    b.ToTable("RolPermiso");
                });

            modelBuilder.Entity("Concretar.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Contrasena");

                    b.Property<bool>("ContrasenaActualizada");

                    b.Property<string>("Email");

                    b.Property<bool>("Habilitado");

                    b.Property<string>("Nombre");

                    b.Property<DateTime>("TSCreado");

                    b.Property<DateTime?>("TSEliminado");

                    b.Property<DateTime?>("TSModificado");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Concretar.Entities.UsuarioRol", b =>
                {
                    b.Property<int>("RolId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("RolId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioRol");
                });

            modelBuilder.Entity("Concretar.Entities.UsuarioToken", b =>
                {
                    b.Property<int>("UsuarioTokenId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FechaExpiracion");

                    b.Property<string>("Token");

                    b.Property<bool>("Usado");

                    b.Property<int>("UsuarioId");

                    b.HasKey("UsuarioTokenId");

                    b.ToTable("UsuarioToken");
                });

            modelBuilder.Entity("Concretar.Entities.Vista", b =>
                {
                    b.Property<int>("VistaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("VistaId");

                    b.ToTable("Vista");
                });

            modelBuilder.Entity("Concretar.Entities.Permiso", b =>
                {
                    b.HasOne("Concretar.Entities.Vista", "Vista")
                        .WithMany("Permisos")
                        .HasForeignKey("VistaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Concretar.Entities.RolPermiso", b =>
                {
                    b.HasOne("Concretar.Entities.Permiso", "Permiso")
                        .WithMany("RolPermisos")
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Concretar.Entities.Rol", "Rol")
                        .WithMany("RolPermisos")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Concretar.Entities.UsuarioRol", b =>
                {
                    b.HasOne("Concretar.Entities.Rol", "Rol")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Concretar.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
