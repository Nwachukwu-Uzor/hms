using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Persistence.Migrations
{
    public partial class AddVerificationStatusToPatientRegisterationRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VerificationStatus",
                table: "PatientRegisterationRequests",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4746), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4768), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4776), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4765), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4761), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4769), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4763), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4764), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4775), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4774), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4982), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4985), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4969), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2385e258-05fb-4f06-9768-71a179a1df6d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4988), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5642065b-1d35-4c33-9f05-47fe23b74c4d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4975), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4965), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4981), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4987), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9835fc30-d1a9-4f67-84a1-4930edf7f883"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4971), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4973), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5090), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5089), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5085), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5088), new DateTime(2024, 4, 1, 8, 32, 3, 439, DateTimeKind.Utc).AddTicks(5088) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerificationStatus",
                table: "PatientRegisterationRequests");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9501), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9527), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9523), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9532), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9522), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9516), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9525), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9518), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9526), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9519), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9531), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9534), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9529), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9533), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9528), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9752), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9736), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2385e258-05fb-4f06-9768-71a179a1df6d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9755), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5642065b-1d35-4c33-9f05-47fe23b74c4d"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9743), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9733), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9748), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9753), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9746), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9835fc30-d1a9-4f67-84a1-4930edf7f883"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9744), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9739), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9741), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9865), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9863), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 4, 1, 6, 44, 16, 695, DateTimeKind.Utc).AddTicks(9861) });
        }
    }
}
