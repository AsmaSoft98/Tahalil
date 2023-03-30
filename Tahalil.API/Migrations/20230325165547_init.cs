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
                    { 1, new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(8979), "Patient1@gmail.com", "Patient1", new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 }, new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 }, "Admin" },
                    { 2, new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9036), "Prescript1@gmail.com", "Prescript1", new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 }, new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 }, "Prescript" },
                    { 3, new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9040), "Prescript2@gmail.com", "Prescript2", new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 }, new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 }, "Prescript" },
                    { 4, new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9043), "Patient2@gmail.com", "Patient2", new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 }, new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 }, "Patient" },
                    { 5, new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9047), "Patient3@gmail.com", "Patient3", new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 }, new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 }, "Patient" },
                    { 6, new DateTime(2023, 3, 25, 17, 55, 47, 601, DateTimeKind.Local).AddTicks(9052), "Patient4@gmail.com", "Patient4", new byte[] { 229, 45, 74, 177, 140, 182, 237, 101, 183, 235, 27, 151, 151, 58, 127, 237, 225, 116, 154, 57, 91, 238, 15, 12, 110, 106, 120, 134, 237, 55, 56, 45, 209, 215, 137, 226, 134, 155, 243, 53, 221, 1, 131, 122, 215, 50, 44, 164, 44, 137, 219, 103, 100, 6, 73, 154, 180, 103, 216, 216, 35, 167, 222, 229 }, new byte[] { 8, 159, 196, 120, 26, 146, 99, 191, 63, 248, 9, 137, 17, 132, 119, 138, 162, 60, 89, 211, 23, 14, 95, 40, 22, 43, 227, 74, 31, 103, 143, 65, 218, 123, 84, 93, 156, 78, 233, 222, 5, 121, 252, 206, 20, 84, 117, 202, 57, 187, 215, 212, 182, 31, 198, 114, 90, 205, 248, 90, 242, 159, 99, 89, 10, 219, 55, 68, 125, 201, 150, 115, 65, 109, 159, 52, 251, 67, 230, 44, 100, 189, 178, 34, 148, 37, 196, 29, 198, 99, 249, 117, 156, 155, 234, 119, 7, 31, 186, 6, 132, 82, 40, 152, 168, 242, 117, 66, 150, 3, 70, 68, 119, 255, 42, 51, 138, 216, 21, 135, 26, 215, 67, 123, 12, 28, 160, 225 }, "Patient" }
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
