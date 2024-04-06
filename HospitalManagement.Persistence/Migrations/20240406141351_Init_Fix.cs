using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Persistence.Migrations
{
    public partial class Init_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Salt = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientRegisterationRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    AccessCode = table.Column<string>(type: "text", nullable: false),
                    ExpiresOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VerificationStatus = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRegisterationRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "DoctorJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    JobId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    JobId = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffID = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Staffs_StaffDetailsId",
                        column: x => x.StaffDetailsId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uuid", nullable: false),
                    AppointmentTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "IsDeleted", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7543), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7546), false, null, "EMERGENCY DEPARTMENT" },
                    { new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7572), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7572), false, null, "PEDIATRICS" },
                    { new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7568), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7568), false, null, "PHARMACY" },
                    { new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7578), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7579), false, null, "RESPIRATORY THERAPY" },
                    { new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7566), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7566), false, null, "RADIOLOGY" },
                    { new Guid("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7561), false, null, "MEDICAL/SURGICAL UNIT" },
                    { new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7569), false, null, "OPERATING ROOMS" },
                    { new Guid("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7562), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7563), false, null, "INTENSIVE CARE UNIT" },
                    { new Guid("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7570), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7571), false, null, "MATERNITY/WOMEN'S HEALTH" },
                    { new Guid("b60d76e9-5cc5-44e7-9336-18e45494ff26"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7564), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7564), false, null, "LABORATORY" },
                    { new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7576), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7576), false, null, "NUTRITION SERVICES" },
                    { new Guid("d5f66dc4-dfad-4be0-90a3-251a97ad9462"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7582), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7582), false, null, "ADMINISTRATION/MANAGEMENT" },
                    { new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7574), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7575), false, null, "PHYSICAL THERAPY/REHABILITATION" },
                    { new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7580), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7581), false, null, "SOCIAL SERVICES" },
                    { new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7573), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7573), false, null, "PSYCHIATRY/PSYCHOLOGY" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "IsDeleted", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8175), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8175), false, null, "PATIENT" },
                    { new Guid("409dfa54-8822-41fc-8f93-f2a31378e436"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8174), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8174), false, null, "STAFF" },
                    { new Guid("5f10c02a-fa84-4936-837d-afa77e5bb238"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8168), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8169), false, null, "ADMIN" },
                    { new Guid("607fbfc9-b509-48b9-acd0-dcfdcda51daa"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8172), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(8172), false, null, "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "DepartmentId", "IsDeleted", "ModifiedBy", "Title" },
                values: new object[,]
                {
                    { new Guid("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7955), new Guid("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"), false, null, "Physical Therapist" },
                    { new Guid("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7956), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7957), new Guid("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"), false, null, "Nutritionist" },
                    { new Guid("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7941), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7941), new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"), false, null, "Registered Nurse" },
                    { new Guid("2385e258-05fb-4f06-9768-71a179a1df6d"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7961), new Guid("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"), false, null, "Social Worker" },
                    { new Guid("5642065b-1d35-4c33-9f05-47fe23b74c4d"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7947), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7948), new Guid("5a128d7e-c137-47b1-bd49-2e9733d694ad"), false, null, "Radiologic Technologist" },
                    { new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7937), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7938), new Guid("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"), false, null, "Physician" },
                    { new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7953), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7953), new Guid("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"), false, null, "Psychiatrist" },
                    { new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7958), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7958), new Guid("2b23f10a-9319-4862-856f-6fca2c64a5f3"), false, null, "Respiratory Therapist" },
                    { new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7951), new Guid("02b204b2-ee02-4a25-b087-d21e7cb9abf3"), false, null, "Pediatrician" },
                    { new Guid("9835fc30-d1a9-4f67-84a1-4930edf7f883"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7949), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7950), new Guid("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"), false, null, "Pharmacist" },
                    { new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7943), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7944), new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"), false, null, "Surgeon" },
                    { new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7945), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7946), new Guid("7b7f70f0-414c-4b25-8602-3e005aeb5869"), false, null, "Anesthesiologist" }
                });

            migrationBuilder.InsertData(
                table: "DoctorJobs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "IsDeleted", "JobId", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("680521fa-d14a-48be-b36c-76b0f4f7eb2b"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7836), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7836), false, new Guid("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"), null },
                    { new Guid("868edd64-161b-40e3-8ca2-38426fcdb05c"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7831), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7832), false, new Guid("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"), null },
                    { new Guid("a8d434fd-355d-42c0-9c16-3621a7bc2085"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7837), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7838), false, new Guid("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"), null },
                    { new Guid("e457d0d7-7f7d-4dd1-91b6-57ae307dc9bd"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7825), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7825), false, new Guid("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"), null },
                    { new Guid("ed88073f-6b2f-41ee-8ac0-956ef67932c8"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7830), false, new Guid("ab14514d-67a2-4d8f-bc38-145c7eb665d8"), null },
                    { new Guid("f71b6604-e5ff-4454-b666-565e833b8f2d"), "ADMIN", new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 4, 6, 14, 13, 51, 382, DateTimeKind.Utc).AddTicks(7834), false, new Guid("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRole_UsersId",
                table: "AppUserRole",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorJobs_JobId",
                table: "DoctorJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_StaffDetailsId",
                table: "Doctors",
                column: "StaffDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_DepartmentId",
                table: "Jobs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AppUserId",
                table: "Patients",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_AppUserId",
                table: "Staffs",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_JobId",
                table: "Staffs",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppUserRole");

            migrationBuilder.DropTable(
                name: "DoctorJobs");

            migrationBuilder.DropTable(
                name: "PatientRegisterationRequests");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
