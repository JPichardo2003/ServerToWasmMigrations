﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Migraciones.Server.DAL;

#nullable disable

namespace Migraciones.Server.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Migraciones.Shared.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rnc")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Migraciones.Shared.Models.Prioridades", b =>
                {
                    b.Property<int>("PrioridadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DiasCompromiso")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrioridadId");

                    b.ToTable("Prioridades");
                });

            modelBuilder.Entity("Migraciones.Shared.Models.Tickets", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("PrioridadId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SolicitadoPor")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PrioridadId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Migraciones.Shared.Models.Tickets", b =>
                {
                    b.HasOne("Migraciones.Shared.Models.Clientes", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Migraciones.Shared.Models.Prioridades", null)
                        .WithMany("Tickets")
                        .HasForeignKey("PrioridadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Migraciones.Shared.Models.Clientes", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Migraciones.Shared.Models.Prioridades", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
