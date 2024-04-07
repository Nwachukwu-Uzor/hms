using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Persistence.Migrations
{
    public partial class SetDefaultAppointmentStatusToPending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8727), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8758), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8753), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8765), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8751), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8745), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8755), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8747), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8757), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8749), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8763), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8769), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8762), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8767), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("680521fa-d14a-48be-b36c-76b0f4f7eb2b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9062), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("868edd64-161b-40e3-8ca2-38426fcdb05c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9057), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("a8d434fd-355d-42c0-9c16-3621a7bc2085"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9064), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("e457d0d7-7f7d-4dd1-91b6-57ae307dc9bd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("ed88073f-6b2f-41ee-8ac0-956ef67932c8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9054), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("f71b6604-e5ff-4454-b666-565e833b8f2d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9059), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9232), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9234), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9212), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2385e258-05fb-4f06-9768-71a179a1df6d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5642065b-1d35-4c33-9f05-47fe23b74c4d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9220), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9207), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9230), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9237), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9227), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9835fc30-d1a9-4f67-84a1-4930edf7f883"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9223), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9215), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9217), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9373), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 4, 7, 8, 25, 12, 667, DateTimeKind.Utc).AddTicks(9377) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1274), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1318), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1325), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1305), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1298), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1311), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1301), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1316), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1303), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1323), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1329), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1322), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1327), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1320), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("680521fa-d14a-48be-b36c-76b0f4f7eb2b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1703), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("868edd64-161b-40e3-8ca2-38426fcdb05c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1698), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("a8d434fd-355d-42c0-9c16-3621a7bc2085"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1705), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("e457d0d7-7f7d-4dd1-91b6-57ae307dc9bd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1690), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("ed88073f-6b2f-41ee-8ac0-956ef67932c8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "DoctorJobs",
                keyColumn: "Id",
                keyValue: new Guid("f71b6604-e5ff-4454-b666-565e833b8f2d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1897), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1899), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1876), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2385e258-05fb-4f06-9768-71a179a1df6d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1904), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5642065b-1d35-4c33-9f05-47fe23b74c4d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1885), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1869), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1894), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1902), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9835fc30-d1a9-4f67-84a1-4930edf7f883"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1889), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1880), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1883), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2068), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2061), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 4, 6, 15, 25, 3, 428, DateTimeKind.Utc).AddTicks(2067) });
        }
    }
}
