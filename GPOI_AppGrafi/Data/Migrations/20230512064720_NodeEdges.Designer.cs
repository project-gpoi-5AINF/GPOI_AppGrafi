﻿// <auto-generated />
using GPOI_AppGrafi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GPOI_AppGrafi.Data.Migrations
{
    [DbContext(typeof(GPOI_AppGrafiContext))]
    [Migration("20230512064720_NodeEdges")]
    partial class NodeEdges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GPOI_AppGrafi.Models.Edge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NodoOrigineId")
                        .HasColumnType("int");

                    b.Property<int>("NodoTermineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NodoOrigineId");

                    b.HasIndex("NodoTermineId");

                    b.ToTable("Edge");
                });

            modelBuilder.Entity("GPOI_AppGrafi.Models.Node", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Node");
                });

            modelBuilder.Entity("GPOI_AppGrafi.Models.NodeSQL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NodeSQL");
                });

            modelBuilder.Entity("GPOI_AppGrafi.Models.Edge", b =>
                {
                    b.HasOne("GPOI_AppGrafi.Models.Node", "NodoOrigine")
                        .WithMany()
                        .HasForeignKey("NodoOrigineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GPOI_AppGrafi.Models.Node", "NodoTermine")
                        .WithMany()
                        .HasForeignKey("NodoTermineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NodoOrigine");

                    b.Navigation("NodoTermine");
                });
#pragma warning restore 612, 618
        }
    }
}
