﻿// <auto-generated />
using System;
using Applications.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace applications_api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200418110155_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Applications.Model.Application", b =>
                {
                    b.Property<Guid>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Form")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("ApplicationId");

                    b.ToTable("Applications");

                    b.HasData(
                        new
                        {
                            ApplicationId = new Guid("b4c4e316-29c3-4ca1-8254-379f12a8c62a"),
                            Created = new DateTime(2020, 4, 18, 13, 1, 54, 126, DateTimeKind.Local).AddTicks(7781),
                            Form = "{\"Name\": \"John Doe\"}",
                            LastUpdated = new DateTime(2020, 4, 18, 13, 1, 54, 126, DateTimeKind.Local).AddTicks(8791)
                        },
                        new
                        {
                            ApplicationId = new Guid("d9d85732-b2b8-4615-af41-781b7d609001"),
                            Created = new DateTime(2020, 4, 18, 13, 1, 54, 127, DateTimeKind.Local).AddTicks(492),
                            Form = "{\"Name\": \"Sue Hunter\"}",
                            LastUpdated = new DateTime(2020, 4, 18, 13, 1, 54, 127, DateTimeKind.Local).AddTicks(526)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
