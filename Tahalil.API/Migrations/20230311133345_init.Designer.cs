﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tahalil.API.Data;

#nullable disable

namespace Tahalil.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230311133345_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tahalil.Models.Anals.Anal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Jour")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Mnt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PrescriptId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("codeAnal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Anal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Jour = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 25000m,
                            PrescriptId = 1,
                            UserId = 4,
                            codeAnal = "2301000001"
                        },
                        new
                        {
                            Id = 2,
                            Jour = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 5000m,
                            PrescriptId = 1,
                            UserId = 4,
                            codeAnal = "2301000002"
                        },
                        new
                        {
                            Id = 3,
                            Jour = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 15000m,
                            PrescriptId = 2,
                            UserId = 4,
                            codeAnal = "2301000003"
                        },
                        new
                        {
                            Id = 4,
                            Jour = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 7500m,
                            PrescriptId = 2,
                            UserId = 5,
                            codeAnal = "2301000004"
                        },
                        new
                        {
                            Id = 5,
                            Jour = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 8000m,
                            PrescriptId = 1,
                            UserId = 6,
                            codeAnal = "2301000005"
                        },
                        new
                        {
                            Id = 6,
                            Jour = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 2500m,
                            PrescriptId = 2,
                            UserId = 4,
                            codeAnal = "2301000006"
                        },
                        new
                        {
                            Id = 7,
                            Jour = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 500m,
                            PrescriptId = 1,
                            UserId = 5,
                            codeAnal = "2301000007"
                        },
                        new
                        {
                            Id = 8,
                            Jour = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 300m,
                            PrescriptId = 2,
                            UserId = 4,
                            codeAnal = "2301000008"
                        },
                        new
                        {
                            Id = 9,
                            Jour = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 1200m,
                            PrescriptId = 2,
                            UserId = 6,
                            codeAnal = "2301000009"
                        },
                        new
                        {
                            Id = 10,
                            Jour = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 1600m,
                            PrescriptId = 2,
                            UserId = 6,
                            codeAnal = "2301000010"
                        },
                        new
                        {
                            Id = 11,
                            Jour = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mnt = 25000m,
                            PrescriptId = 1,
                            UserId = 5,
                            codeAnal = "2301000011"
                        });
                });

            modelBuilder.Entity("Tahalil.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCreated = new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3258),
                            Email = "Patient1@gmail.com",
                            Name = "Patient1",
                            PasswordHash = new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 },
                            PasswordSalt = new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 },
                            Role = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            DataCreated = new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3321),
                            Email = "Prescript1@gmail.com",
                            Name = "Prescript1",
                            PasswordHash = new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 },
                            PasswordSalt = new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 },
                            Role = "Prescript"
                        },
                        new
                        {
                            Id = 3,
                            DataCreated = new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3326),
                            Email = "Prescript2@gmail.com",
                            Name = "Prescript2",
                            PasswordHash = new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 },
                            PasswordSalt = new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 },
                            Role = "Prescript"
                        },
                        new
                        {
                            Id = 4,
                            DataCreated = new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3329),
                            Email = "Patient2@gmail.com",
                            Name = "Patient2",
                            PasswordHash = new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 },
                            PasswordSalt = new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 },
                            Role = "Patient"
                        },
                        new
                        {
                            Id = 5,
                            DataCreated = new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3332),
                            Email = "Patient3@gmail.com",
                            Name = "Patient3",
                            PasswordHash = new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 },
                            PasswordSalt = new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 },
                            Role = "Patient"
                        },
                        new
                        {
                            Id = 6,
                            DataCreated = new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3340),
                            Email = "Patient4@gmail.com",
                            Name = "Patient4",
                            PasswordHash = new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 },
                            PasswordSalt = new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 },
                            Role = "Patient"
                        });
                });

            modelBuilder.Entity("Tahalil.Models.Anals.Anal", b =>
                {
                    b.HasOne("Tahalil.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
