﻿namespace HospitalManagement.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    IAppUserRepository AppUserRepository { get; }
    IDepartmentRepository DepartmentRepository { get; }
    IJobRepository JobRepository { get; }
    IPatientRepository PatientRepository { get; }
    IRoleRepository RoleRepository { get; }
    IStaffRepository StaffRepository { get; }
    Task CompleteAsync();
}
