﻿// <auto-generated />
using System;
using Jellyfin.Plugin.MediaAnalyzer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jellyfin.Plugin.MediaAnalyzer.Migrations
{
    [DbContext(typeof(MediaAnalyzerDbContext))]
    [Migration("20240903114429_CreateSegmentMetadata")]
    partial class CreateSegmentMetadata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Jellyfin.Plugin.MediaAnalyzer.SegmentMetadata", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AnalyzerNote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("AnalyzerType")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("PreventAnalyzing")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("SegmentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeriesName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("SegmentMetadata");
                });
#pragma warning restore 612, 618
        }
    }
}
