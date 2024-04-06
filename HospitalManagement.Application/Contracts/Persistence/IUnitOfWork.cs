namespace HospitalManagement.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    IAppUserRepository AppUserRepository { get; }
    IDepartmentRepository DepartmentRepository { get; }
    IJobRepository JobRepository { get; }
    IPatientRepository PatientRepository { get; }
    IRoleRepository RoleRepository { get; }
    IStaffRepository StaffRepository { get; }
    IPatientRegisterationRequestRepository PatientRegisterationRequestRepository { get; }
    IAppointmentRepository AppointmentRepository { get; }
    IDoctorJobRepository DoctorJobRepository { get; }
    IDoctorRepository DoctorRepository { get; } 
    Task CompleteAsync();
}
