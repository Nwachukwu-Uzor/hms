using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Persistence.Migrations
{
    public partial class adduserslisttoroleentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_AppUsers_AppUserId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_AppUserId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Roles");

            migrationBuilder.CreateTable(
                name: "AppUserRole",
                columns: table => new
                {
                    RolesId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRole", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AppUserRole_AppUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1870), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1897), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1893), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1902), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1891), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1887), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1894), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1888), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1896), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1890), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1901), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1899), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1903), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1898), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2106), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2104), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2099), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2102), new DateTime(2024, 3, 21, 13, 43, 15, 427, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRole_UsersId",
                table: "AppUserRole",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserRole");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Roles",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6873), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6905), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6900), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6910), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6902), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6896), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6909), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6913), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6907), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6912), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6906), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7239), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7234), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7237), new DateTime(2024, 3, 21, 10, 38, 11, 696, DateTimeKind.Utc).AddTicks(7238) });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_AppUserId",
                table: "Roles",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_AppUsers_AppUserId",
                table: "Roles",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }
    }
}
