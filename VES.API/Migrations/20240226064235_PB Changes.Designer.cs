﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VES.API.Data;

#nullable disable

namespace VES.API.Migrations
{
    [DbContext(typeof(VESDbContext))]
    [Migration("20240226064235_PB Changes")]
    partial class PBChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VES.API.Models.Domain.LFMngment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApprovedAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Creditmethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeclinedReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpDatetoCredit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImpactAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("LateFeeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PostingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RootCause1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RootCause2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TotalAmountDue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaiverStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LFMngment");
                });

            modelBuilder.Entity("VES.API.Models.Domain.pastDue", b =>
                {
                    b.Property<int?>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("EntryId"));

                    b.Property<string>("AccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentCharges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HascontBFs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvoiceID")
                        .HasColumnType("int");

                    b.Property<string>("LfAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PMC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostingDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryRc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriorBalance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntryId");

                    b.ToTable("pastDues");
                });
#pragma warning restore 612, 618
        }
    }
}
