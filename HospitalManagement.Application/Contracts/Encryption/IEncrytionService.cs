namespace HospitalManagement.Application.Contracts;

public interface IEncrytionService
{
    string Encrypt(string plainText);
    string Decrypt(string cypherText);
}

