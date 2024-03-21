using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Models.AuthService;
using Microsoft.Extensions.Options;
using System;
using System.Security.Cryptography;
using System.Text;

namespace HospitalManagement.Infrastructure.AuthService;

public class PasswordService : IPasswordService
{
    private HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
    private readonly PasswordSettings _passwordSettings;

    public PasswordService(IOptions<PasswordSettings> passwordSettings)
    {
        _passwordSettings = passwordSettings.Value;
    }
    public bool ComparePassword(string password, string passwordHash, string salt)
    {
        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(
            password,
            Convert.FromHexString(salt),
            _passwordSettings.IterationsCount,
            hashAlgorithm,
            _passwordSettings.KeySize
       );
        return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(passwordHash));
    }

    public byte[] GenerateSalt()
    {
        var salt = RandomNumberGenerator.GetBytes(_passwordSettings.KeySize);
        return salt;
    }

    public HashOutput HashPassword(string password)
    {
        var salt = GenerateSalt();
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            salt,
            _passwordSettings.IterationsCount,
            hashAlgorithm,
            _passwordSettings.KeySize
       );
        return new HashOutput
        {
            Salt = Convert.ToHexString(salt),
            Hash = Convert.ToHexString(hash)
        };
    }
}
