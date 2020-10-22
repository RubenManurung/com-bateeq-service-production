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
    [Migration("20190611020928_Delete_Column_PreparingId_on_GarmentPreparingItem")]
    partial class Delete_Column_PreparingId_on_GarmentPreparingItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("DesignColor");

                    b.Property<string>("FabricType");

                    b.Property<Guid>("GarmentPreparingId");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<double>("Quantity");

                    b.Property<double>("RemainingQuantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UENItemId");

                    b.Property<int>("UomId");

                    b.HasKey("Identity");

                    b.ToTable("GarmentPreparingItems");
                });

            modelBuilder.Entity("Manufactures.Domain.GarmentPreparings.ReadModels.GarmentPreparingReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article");

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

                    b.Property<DateTimeOffset>("ProcessDate");

                    b.Property<string>("RONo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UENId");

                    b.Property<string>("UENNo");

                    b.Property<int>("UnitId");

                    b.HasKey("Identity");

                    b.ToTable("GarmentPreparings");
                });
#pragma warning restore 612, 618
        }
    }
}
