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
    [Migration("20230325165547_init")]
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
                            DataCreated = new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(8979),
                            Email = "Patient1@gmail.com",
                            Name = "Patient1",
                            PasswordHash = new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 },
                            PasswordSalt = new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 },
                            Role = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            DataCreated = new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9036),
                            Email = "Prescript1@gmail.com",
                            Name = "Prescript1",
                            PasswordHash = new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 },
                            PasswordSalt = new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 },
                            Role = "Prescript"
                        },
                        new
                        {
                            Id = 3,
                            DataCreated = new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9040),
                            Email = "Prescript2@gmail.com",
                            Name = "Prescript2",
                            PasswordHash = new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 },
                            PasswordSalt = new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 },
                            Role = "Prescript"
                        },
                        new
                        {
                            Id = 4,
                            DataCreated = new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9043),
                            Email = "Patient2@gmail.com",
                            Name = "Patient2",
                            PasswordHash = new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 },
                            PasswordSalt = new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 },
                            Role = "Patient"
                        },
                        new
                        {
                            Id = 5,
                            DataCreated = new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9047),
                            Email = "Patient3@gmail.com",
                            Name = "Patient3",
                            PasswordHash = new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 },
                            PasswordSalt = new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 },
                            Role = "Patient"
                        },
                        new
                        {
                            Id = 6,
                            DataCreated = new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9052),
                            Email = "Patient4@gmail.com",
                            Name = "Patient4",
                            PasswordHash = new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 },
                            PasswordSalt = new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 },
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
