﻿using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly AppDbContext _context;
    public IAppUserRepository AppUserRepository { get; }

    public IDepartmentRepository DepartmentRepository { get; }

    public IJobRepository JobRepository { get; }

    public IPatientRepository PatientRepository { get; }

    public IRoleRepository RoleRepository { get; }

    public IStaffRepository StaffRepository { get; }

    public UnitOfWork(
        IAppUserRepository appUserRepository,
        IDepartmentRepository departmentRepository,
        IJobRepository jobRepository,
        IPatientRepository patientRepository,
        IRoleRepository roleRepository,
        IStaffRepository staffRepository
,
        AppDbContext context)
    {
        AppUserRepository = appUserRepository;
        DepartmentRepository = departmentRepository;
        JobRepository = jobRepository;
        PatientRepository = patientRepository;
        RoleRepository = roleRepository;
        StaffRepository = staffRepository;
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
