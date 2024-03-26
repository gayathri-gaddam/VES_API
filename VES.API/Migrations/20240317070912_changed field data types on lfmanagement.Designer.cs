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
    [Migration("20240317070912_changed field data types on lfmanagement")]
    partial class changedfielddatatypesonlfmanagement
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VES.API.Models.Domain.LFManagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("ApprovedAmount")
                        .HasColumnType("float");

                    b.Property<string>("Creditmethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeclinedReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpDatetoCredit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImpactAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("LateFeeAmount")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostingDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivedDate")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<double?>("TotalAmountDue")
                        .HasColumnType("float");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaiverStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LFManagement");

                    b.HasData(
                        new
                        {
                            Id = 277997,
                            AccountNo = "3210131953456",
                            ApprovedAmount = 2.1000000000000001,
                            Creditmethod = "",
                            DeclinedReason = "",
                            DueDate = "45289",
                            ExpDatetoCredit = "",
                            ImpactAmount = "OverDue",
                            InvoiceDate = "45271",
                            InvoiceSource = "",
                            LateFeeAmount = 111900.0,
                            Name = "Arch Asset Management LLC",
                            PostingDate = "12/18/2023",
                            ReceivedDate = "45278.5985417477",
                            Remarks = "",
                            RequestStatus = "Auto Closed",
                            RequestedBy = "",
                            RootCause1 = "",
                            RootCause2 = "",
                            SiteName = "Austin Woods",
                            TotalAmountDue = 919000.0,
                            VendorName = "Dominion Energy South Carolina",
                            WaiverStatus = "Auto Closed"
                        });
                });

            modelBuilder.Entity("VES.API.Models.Domain.Notice", b =>
                {
                    b.Property<int>("entryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("entryId"));

                    b.Property<string>("accountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("autoApp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("changeReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("impactAmount")
                        .HasColumnType("real");

                    b.Property<string>("impactDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noticeActionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noticeDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("noticeId")
                        .HasColumnType("int");

                    b.Property<string>("noticePbMatchId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pmc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resolutionStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("siteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("unitNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uploadDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userRc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("watchList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("entryId");

                    b.ToTable("Notices");

                    b.HasData(
                        new
                        {
                            entryId = 89957,
                            accountNo = "4777230908",
                            autoApp = "",
                            changeReason = "",
                            impactAmount = 0.01f,
                            impactDate = "12/18/2023",
                            noticeActionId = "Late Notice_5959Estuary4777230908Gas South_002B_010000",
                            noticeDate = "11/28/2023",
                            noticeId = 5959,
                            noticePbMatchId = "5959Estuary4777230908Gas South_010000",
                            platform = "VES",
                            pmc = "Federal Capital Partners",
                            postingDate = "12/9/2023",
                            remarks = "",
                            resolutionStatus = "",
                            siteName = "Estuary",
                            type = "Late Notice",
                            unitNo = "002B",
                            uploadDate = "12/11/2023",
                            userRc = "",
                            vendorName = "Gas South",
                            watchList = ""
                        },
                        new
                        {
                            entryId = 89978,
                            accountNo = "2222305563",
                            autoApp = "",
                            changeReason = "",
                            impactAmount = 32.89f,
                            impactDate = "12/14/2023",
                            noticeActionId = "Late Notice_97909Rosewood Apartments #10110 (26876)2222305563Idaho Power_H102_020100",
                            noticeDate = "12/4/2023",
                            noticeId = 97909,
                            noticePbMatchId = "97909Rosewood Apartments #10110 (26876)2222305563Idaho Power_020100",
                            platform = "VES",
                            pmc = "Greystar Management Services LP",
                            postingDate = "12/10/2023",
                            remarks = "",
                            resolutionStatus = "",
                            siteName = "Rosewood Apartments #10110 (26876)",
                            type = "Late Notice",
                            unitNo = "H102",
                            uploadDate = "12/11/2023",
                            userRc = "",
                            vendorName = "Idaho Power",
                            watchList = ""
                        });
                });

            modelBuilder.Entity("VES.API.Models.Domain.PastDue", b =>
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

                    b.ToTable("PastDues");

                    b.HasData(
                        new
                        {
                            EntryId = 5896,
                            AccountNo = "",
                            CurrentCharges = "",
                            HascontBFs = "",
                            InvoiceDate = "",
                            InvoiceID = 1,
                            LfAmount = "",
                            Notes = "",
                            PMC = "A",
                            PostingDate = "",
                            PrimaryRc = "",
                            PriorBalance = "",
                            Priority = "",
                            Rc1 = "",
                            Rc2 = "",
                            SiteName = "",
                            TemplateAmount = "",
                            Type = "",
                            VendorName = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}