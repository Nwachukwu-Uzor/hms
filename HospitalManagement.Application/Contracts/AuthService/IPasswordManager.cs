using HospitalManagement.Application.Models.AuthService;

namespace HospitalManagement.Application.Contracts.AuthService;

public interface IPasswordManager
{
    byte[] GenerateSalt();
    HashOutput HashPassword(string password);
    Task<bool> ComparePassword(string password, string passwordHash, string salt);
}
