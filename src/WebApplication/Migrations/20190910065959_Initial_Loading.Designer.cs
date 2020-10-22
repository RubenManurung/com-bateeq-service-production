﻿// <auto-generated />
using System;
using DanLiris.Admin.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DanLiris.Admin.Web.Migrations
{
    [DbContext(typeof(AppStorageContext))]
    [Migration("20190910065959_Initial_Loading")]
    partial class Initial_Loading
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Manufactures.Domain.GarmentAvalProducts.ReadModels.GarmentAvalProductItemReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("APId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("DesignColor")
                        .HasMaxLength(100);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("PreparingId");

                    b.Property<string>("PreparingItemId");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(25);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<double>("Quantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UomId");

                    b.Property<string>("UomUnit")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.HasIndex("APId");

                    b.ToTable("GarmentAvalProductItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentAvalProducts.ReadModels.GarmentAvalProductReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset?>("AvalDate");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("RONo")
                        .HasMaxLength(100);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Identity");

                    b.ToTable("GarmentAvalProducts");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingIns.ReadModels.GarmentCuttingInDetailReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BasicPrice");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<Guid>("CutInItemId");

                    b.Property<double>("CuttingInQuantity");

                    b.Property<int>("CuttingInUomId");

                    b.Property<string>("CuttingInUomUnit")
                        .HasMaxLength(10);

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("DesignColor")
                        .HasMaxLength(25);

                    b.Property<string>("FabricType")
                        .HasMaxLength(25);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<Guid>("PreparingItemId");

                    b.Property<double>("PreparingQuantity");

                    b.Property<int>("PreparingUomId");

                    b.Property<string>("PreparingUomUnit")
                        .HasMaxLength(10);

                    b.Property<string>("ProductCode")
                        .HasMaxLength(25);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<double>("RemainingQuantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Identity");

                    b.HasIndex("CutInItemId");

                    b.ToTable("GarmentCuttingInDetails");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingIns.ReadModels.GarmentCuttingInItemReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<Guid>("CutInId");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<Guid>("PreparingId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UENId");

                    b.Property<string>("UENNo")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.HasIndex("CutInId");

                    b.ToTable("GarmentCuttingInItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingIns.ReadModels.GarmentCuttingInReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .HasMaxLength(50);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("CutInNo")
                        .HasMaxLength(25);

                    b.Property<DateTimeOffset>("CuttingInDate");

                    b.Property<string>("CuttingType")
                        .HasMaxLength(25);

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<double>("FC");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("RONo")
                        .HasMaxLength(25);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UnitCode")
                        .HasMaxLength(25);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.ToTable("GarmentCuttingIns");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingOuts.ReadModels.GarmentCuttingOutDetailReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BasicPrice");

                    b.Property<string>("Color")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<Guid>("CutOutItemId");

                    b.Property<double>("CuttingOutQuantity");

                    b.Property<int>("CuttingOutUomId");

                    b.Property<string>("CuttingOutUomUnit")
                        .HasMaxLength(10);

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<double>("IndirectPrice");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<double>("OTL1");

                    b.Property<double>("OTL2");

                    b.Property<double>("RemainingQuantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SizeId");

                    b.Property<string>("SizeName")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.HasIndex("CutOutItemId");

                    b.ToTable("GarmentCuttingOutDetails");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingOuts.ReadModels.GarmentCuttingOutItemReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<Guid>("CutOutId");

                    b.Property<Guid>("CuttingInDetailId");

                    b.Property<Guid>("CuttingInId");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("DesignColor")
                        .HasMaxLength(100);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(25);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<double>("TotalCuttingOut");

                    b.HasKey("Identity");

                    b.HasIndex("CutOutId");

                    b.ToTable("GarmentCuttingOutItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingOuts.ReadModels.GarmentCuttingOutReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .HasMaxLength(50);

                    b.Property<string>("ComodityCode")
                        .HasMaxLength(25);

                    b.Property<int>("ComodityId");

                    b.Property<string>("ComodityName")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("CutOutNo")
                        .HasMaxLength(25);

                    b.Property<DateTimeOffset>("CuttingOutDate");

                    b.Property<string>("CuttingOutType")
                        .HasMaxLength(25);

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("RONo")
                        .HasMaxLength(25);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UnitCode")
                        .HasMaxLength(25);

                    b.Property<string>("UnitFromCode")
                        .HasMaxLength(25);

                    b.Property<int>("UnitFromId");

                    b.Property<string>("UnitFromName")
                        .HasMaxLength(100);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.ToTable("GarmentCuttingOuts");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentDeliveryReturns.ReadModels.GarmentDeliveryReturnItemReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<Guid>("DRId");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("DesignColor")
                        .HasMaxLength(100);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("PreparingItemId");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(25);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<double>("Quantity");

                    b.Property<string>("RONo")
                        .HasMaxLength(100);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UENItemId");

                    b.Property<int>("UnitDOItemId");

                    b.Property<int>("UomId");

                    b.Property<string>("UomUnit")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.HasIndex("DRId");

                    b.ToTable("GarmentDeliveryReturnItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentDeliveryReturns.ReadModels.GarmentDeliveryReturnReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("DRNo")
                        .HasMaxLength(25);

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<bool>("IsUsed");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("PreparingId");

                    b.Property<string>("RONo")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset?>("ReturnDate");

                    b.Property<string>("ReturnType")
                        .HasMaxLength(25);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("StorageCode")
                        .HasMaxLength(25);

                    b.Property<int>("StorageId");

                    b.Property<string>("StorageName")
                        .HasMaxLength(100);

                    b.Property<int>("UENId");

                    b.Property<string>("UnitCode")
                        .HasMaxLength(25);

                    b.Property<int>("UnitDOId");

                    b.Property<string>("UnitDONo")
                        .HasMaxLength(100);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.ToTable("GarmentDeliveryReturns");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentLoadings.ReadModels.GarmentLoadingItemReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BasicPrice");

                    b.Property<string>("Color")
                        .HasMaxLength(50);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("DesignColor")
                        .HasMaxLength(50);

                    b.Property<Guid>("LoadingId");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(50);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(500);

                    b.Property<double>("Quantity");

                    b.Property<double>("RemainingQuantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("SewingDOItemId");

                    b.Property<int>("SizeId");

                    b.Property<string>("SizeName")
                        .HasMaxLength(50);

                    b.Property<int>("UomId");

                    b.Property<string>("UomUnit")
                        .HasMaxLength(50);

                    b.HasKey("Identity");

                    b.HasIndex("LoadingId");

                    b.ToTable("GarmentLoadingItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentLoadings.ReadModels.GarmentLoadingReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .HasMaxLength(50);

                    b.Property<string>("Comodity")
                        .HasMaxLength(500);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<DateTimeOffset>("LoadingDate");

                    b.Property<string>("LoadingNo")
                        .HasMaxLength(25);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("RONo")
                        .HasMaxLength(25);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("SewingDOId");

                    b.Property<string>("SewingDONo")
                        .HasMaxLength(25);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(25);

                    b.Property<string>("UnitFromCode")
                        .HasMaxLength(25);

                    b.Property<int>("UnitFromId");

                    b.Property<string>("UnitFromName")
                        .HasMaxLength(100);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.ToTable("GarmentLoadings");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentPreparings.ReadModels.GarmentPreparingItemReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BasicPrice");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("DesignColor")
                        .HasMaxLength(100);

                    b.Property<string>("FabricType")
                        .HasMaxLength(100);

                    b.Property<Guid>("GarmentPreparingId");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(25);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<double>("Quantity");

                    b.Property<double>("RemainingQuantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UENItemId");

                    b.Property<int>("UomId");

                    b.Property<string>("UomUnit")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.HasIndex("GarmentPreparingId");

                    b.ToTable("GarmentPreparingItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentPreparings.ReadModels.GarmentPreparingReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .HasMaxLength(500);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<bool>("IsCuttingIn");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<DateTimeOffset?>("ProcessDate");

                    b.Property<string>("RONo")
                        .HasMaxLength(100);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UENId");

                    b.Property<string>("UENNo")
                        .HasMaxLength(100);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(25);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.ToTable("GarmentPreparings");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentSewingDOs.ReadModels.GarmentSewingDOItemReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BasicPrice");

                    b.Property<string>("Color")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<Guid>("CuttingOutDetailId");

                    b.Property<Guid>("CuttingOutItemId");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("DesignColor")
                        .HasMaxLength(100);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(25);

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<double>("RemainingQuantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<Guid>("SewingDOId");

                    b.Property<int>("SizeId");

                    b.Property<string>("SizeName")
                        .HasMaxLength(100);

                    b.Property<int>("UomId");

                    b.Property<string>("UomUnit")
                        .HasMaxLength(10);

                    b.HasKey("Identity");

                    b.HasIndex("SewingDOId");

                    b.ToTable("GarmentSewingDOItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentSewingDOs.ReadModels.GarmentSewingDOReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .HasMaxLength(50);

                    b.Property<string>("ComodityCode")
                        .HasMaxLength(25);

                    b.Property<int>("ComodityId");

                    b.Property<string>("ComodityName")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<Guid>("CuttingOutId");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("RONo")
                        .HasMaxLength(25);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SewingDONo")
                        .HasMaxLength(25);

                    b.Property<DateTimeOffset>("SewingOutDate");

                    b.Property<string>("UnitCode")
                        .HasMaxLength(25);

                    b.Property<string>("UnitFromCode")
                        .HasMaxLength(25);

                    b.Property<int>("UnitFromId");

                    b.Property<string>("UnitFromName")
                        .HasMaxLength(100);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.HasKey("Identity");

                    b.ToTable("GarmentSewingDOs");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentAvalProducts.ReadModels.GarmentAvalProductItemReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentAvalProducts.ReadModels.GarmentAvalProductReadModel", "GarmentAvalProductIdentity")
                        .WithMany("GarmentAvalProductItem")
                        .HasForeignKey("APId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingIns.ReadModels.GarmentCuttingInDetailReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentCuttingIns.ReadModels.GarmentCuttingInItemReadModel", "GarmentCuttingInItem")
                        .WithMany("Details")
                        .HasForeignKey("CutInItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingIns.ReadModels.GarmentCuttingInItemReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentCuttingIns.ReadModels.GarmentCuttingInReadModel", "GarmentCuttingIn")
                        .WithMany("Items")
                        .HasForeignKey("CutInId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingOuts.ReadModels.GarmentCuttingOutDetailReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentCuttingOuts.ReadModels.GarmentCuttingOutItemReadModel", "GarmentCuttingOutItemIdentity")
                        .WithMany("GarmentCuttingOutDetail")
                        .HasForeignKey("CutOutItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentCuttingOuts.ReadModels.GarmentCuttingOutItemReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentCuttingOuts.ReadModels.GarmentCuttingOutReadModel", "GarmentCuttingOutIdentity")
                        .WithMany("GarmentCuttingOutItem")
                        .HasForeignKey("CutOutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentDeliveryReturns.ReadModels.GarmentDeliveryReturnItemReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentDeliveryReturns.ReadModels.GarmentDeliveryReturnReadModel", "GarmentDeliveryReturnIdentity")
                        .WithMany("GarmentDeliveryReturnItem")
                        .HasForeignKey("DRId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentLoadings.ReadModels.GarmentLoadingItemReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentLoadings.ReadModels.GarmentLoadingReadModel", "GarmentLoading")
                        .WithMany("Items")
                        .HasForeignKey("LoadingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentPreparings.ReadModels.GarmentPreparingItemReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentPreparings.ReadModels.GarmentPreparingReadModel", "GarmentPreparingIdentity")
                        .WithMany("GarmentPreparingItem")
                        .HasForeignKey("GarmentPreparingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentSewingDOs.ReadModels.GarmentSewingDOItemReadModel", b =>
                {
                    b.HasOne("Manufactures.Domain.GarmentSewingDOs.ReadModels.GarmentSewingDOReadModel", "GarmentSewingDOIdentity")
                        .WithMany("GarmentSewingDOItem")
                        .HasForeignKey("SewingDOId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
