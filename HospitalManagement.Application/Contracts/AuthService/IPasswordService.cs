using HospitalManagement.Application.Models.AuthService;

namespace HospitalManagement.Application.Contracts.AuthService;

public interface IPasswordService
{
    byte[] GenerateSalt();
    HashOutput HashPassword(string password);
    bool ComparePassword(string password, string passwordHash, string salt);
    string GenerateRandomPassword();
}
