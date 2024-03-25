namespace HospitalManagement.Application.Contracts.IDGenerator;

public interface IIDGenerator
{
    Task<string> GenerateStaffIDNumber();
    Task<string> GeneratePatientIDNumber();
}
