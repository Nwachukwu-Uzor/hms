using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Persistence.Migrations
{
    public partial class seedjobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Departments_DepartmentId",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Staffs",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_DepartmentId",
                table: "Staffs",
                newName: "IX_Staffs_JobId");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3343), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3368), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3363), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3374), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3362), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3357), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3359), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3366), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3360), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3377), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3370), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3376), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3369), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DepartmentId", "IsDeleted", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3660), new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"), false, null, "Physical Therapist" },
                    { new Guid("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3662), new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"), false, null, "Nutritionist" },
                    { new Guid("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3645), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3645), new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"), false, null, "Registered Nurse" },
                    { new Guid("2385e258-05fb-4f06-9768-71a179a1df6d"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3665), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3666), new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"), false, null, "Social Worker" },
                    { new Guid("5642065b-1d35-4c33-9f05-47fe23b74c4d"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3651), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3652), new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"), false, null, "Radiologic Technologist" },
                    { new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3640), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3641), new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"), false, null, "Physician" },
                    { new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3657), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3658), new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"), false, null, "Psychiatrist" },
                    { new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3664), new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"), false, null, "Respiratory Therapist" },
                    { new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3656), new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"), false, null, "Pediatrician" },
                    { new Guid("9835fc30-d1a9-4f67-84a1-4930edf7f883"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3654), new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"), false, null, "Pharmacist" },
                    { new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3648), new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"), false, null, "Surgeon" },
                    { new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"), "ADMIN", new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3649), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3650), new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"), false, null, "Anesthesiologist" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3788), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3785), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3784), new DateTime(2024, 3, 26, 9, 57, 47, 286, DateTimeKind.Utc).AddTicks(3784) });

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Jobs_JobId",
                table: "Staffs",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Jobs_JobId",
                table: "Staffs");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2385e258-05fb-4f06-9768-71a179a1df6d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5642065b-1d35-4c33-9f05-47fe23b74c4d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9835fc30-d1a9-4f67-84a1-4930edf7f883"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"));

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Staffs",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_JobId",
                table: "Staffs",
                newName: "IX_Staffs_DepartmentId");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1019), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1015), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1025), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1013), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1017), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1012), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1027), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1022), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1021), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1471), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 3, 26, 9, 14, 54, 730, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Departments_DepartmentId",
                table: "Staffs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
