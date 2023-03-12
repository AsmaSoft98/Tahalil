using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tahalil.API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DataCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codeAnal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrescriptId = table.Column<int>(type: "int", nullable: false),
                    Jour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mnt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anal_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DataCreated", "Email", "Name", "PasswordHash", "PasswordSalt", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3258), "Patient1@gmail.com", "Patient1", new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 }, new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 }, "Admin" },
                    { 2, new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3321), "Prescript1@gmail.com", "Prescript1", new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 }, new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 }, "Prescript" },
                    { 3, new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3326), "Prescript2@gmail.com", "Prescript2", new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 }, new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 }, "Prescript" },
                    { 4, new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3329), "Patient2@gmail.com", "Patient2", new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 }, new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 }, "Patient" },
                    { 5, new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3332), "Patient3@gmail.com", "Patient3", new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 }, new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 }, "Patient" },
                    { 6, new DateTime(2023, 3, 11, 14, 33, 44, 943, DateTimeKind.Local).AddTicks(3340), "Patient4@gmail.com", "Patient4", new byte[] { 128, 21, 29, 21, 90, 143, 230, 20, 106, 166, 55, 159, 117, 113, 101, 249, 130, 171, 84, 67, 118, 51, 215, 34, 148, 233, 25, 35, 183, 240, 210, 200, 47, 31, 169, 103, 83, 158, 246, 173, 159, 120, 139, 230, 176, 120, 8, 126, 88, 78, 54, 181, 255, 1, 240, 87, 38, 86, 151, 128, 234, 20, 234, 117 }, new byte[] { 170, 28, 87, 150, 92, 53, 157, 74, 121, 72, 60, 165, 25, 186, 33, 191, 199, 238, 198, 114, 57, 12, 134, 235, 184, 247, 253, 7, 101, 187, 164, 165, 50, 196, 246, 90, 175, 254, 171, 137, 14, 61, 42, 93, 209, 161, 254, 154, 17, 5, 201, 91, 198, 20, 195, 113, 80, 110, 183, 223, 251, 200, 18, 254, 77, 21, 254, 124, 187, 186, 149, 176, 72, 225, 87, 64, 116, 179, 24, 199, 205, 203, 87, 193, 252, 219, 198, 126, 14, 137, 145, 202, 158, 168, 128, 200, 128, 28, 196, 201, 192, 110, 34, 95, 165, 34, 35, 180, 68, 95, 122, 23, 116, 209, 198, 100, 218, 80, 245, 14, 37, 39, 127, 205, 57, 254, 226, 196 }, "Patient" }
                });

            migrationBuilder.InsertData(
                table: "Anal",
                columns: new[] { "Id", "Jour", "Mnt", "PrescriptId", "UserId", "codeAnal" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25000m, 1, 4, "2301000001" },
                    { 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 1, 4, "2301000002" },
                    { 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, 2, 4, "2301000003" },
                    { 4, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7500m, 2, 5, "2301000004" },
                    { 5, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000m, 1, 6, "2301000005" },
                    { 6, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500m, 2, 4, "2301000006" },
                    { 7, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, 1, 5, "2301000007" },
                    { 8, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 2, 4, "2301000008" },
                    { 9, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200m, 2, 6, "2301000009" },
                    { 10, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1600m, 2, 6, "2301000010" },
                    { 11, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25000m, 1, 5, "2301000011" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anal_UserId",
                table: "Anal",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anal");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
