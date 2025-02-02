﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestTask.DAL.PostgreSQL;

#nullable disable

namespace TestTask.DAL.PostgreSQL.Migrations
{
    [DbContext(typeof(TestTaskDbContext))]
    partial class TestTaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestTask.DAL.PostgreSQL.Models.WeatherArchive", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LocalityTimeZoneId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LocalityTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("WeatherArchives");
                });

            modelBuilder.Entity("TestTask.DAL.PostgreSQL.Models.WeatherRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("AirHumidity")
                        .HasColumnType("double precision");

                    b.Property<double>("AirPressure")
                        .HasColumnType("double precision");

                    b.Property<double>("AirTemperature")
                        .HasColumnType("double precision");

                    b.Property<double?>("Clouds")
                        .HasColumnType("double precision");

                    b.Property<double>("DewPoint")
                        .HasColumnType("double precision");

                    b.Property<double?>("HorizontalVisibility")
                        .HasColumnType("double precision");

                    b.Property<double?>("LowCloudBoundary")
                        .HasColumnType("double precision");

                    b.Property<DateTimeOffset>("MeasurementDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("WeatherArchiveId")
                        .HasColumnType("uuid");

                    b.Property<string>("WeatherPhenomena")
                        .HasColumnType("text");

                    b.Property<string>("WindDirection")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("WindSpeed")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("WeatherArchiveId");

                    b.ToTable("WeatherRecords");
                });

            modelBuilder.Entity("TestTask.DAL.PostgreSQL.Models.WeatherRecord", b =>
                {
                    b.HasOne("TestTask.DAL.PostgreSQL.Models.WeatherArchive", "WeatherArchive")
                        .WithMany("WeatherRecords")
                        .HasForeignKey("WeatherArchiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherArchive");
                });

            modelBuilder.Entity("TestTask.DAL.PostgreSQL.Models.WeatherArchive", b =>
                {
                    b.Navigation("WeatherRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
