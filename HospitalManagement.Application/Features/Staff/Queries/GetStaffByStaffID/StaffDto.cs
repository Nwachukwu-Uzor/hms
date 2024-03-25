﻿using HospitalManagement.Application.Features.AppUser.Commands.LoginAdminUser;
using HospitalManagement.Application.Features.Department.Queries.GetAllDepartmentsQuery;

namespace HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;

public class StaffDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public AppUserDto AppUser { get; set; }
    public DepartmentDto Department { get; set; }
    // public Job Job { get; set; }
    public string StaffID { get; set; }
}