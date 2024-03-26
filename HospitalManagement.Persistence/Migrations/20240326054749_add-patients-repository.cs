using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Persistence.Migrations
{
    public partial class addpatientsrepository : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PatientID = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Genotype = table.Column<string>(type: "text", nullable: false),
                    BloodGroup = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9006), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9031), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9036), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9026), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9021), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9028), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9023), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9029), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9025), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9034), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9039), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9033), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9037), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9032), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9288), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9287), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9282), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9285), new DateTime(2024, 3, 26, 5, 47, 48, 751, DateTimeKind.Utc).AddTicks(9286) });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AppUserId",
                table: "Patients",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9523), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9558), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9553), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9565), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9551), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9545), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9555), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9548), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9556), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9549), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9563), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9568), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9561), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9567), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9559), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9807), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9805), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9799), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9803), new DateTime(2024, 3, 25, 18, 27, 46, 819, DateTimeKind.Utc).AddTicks(9803) });
        }
    }
}
