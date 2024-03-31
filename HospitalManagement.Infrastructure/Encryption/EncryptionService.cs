using HospitalManagement.Application.Contracts;
using HospitalManagement.Application.Models.Encryption;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;

namespace HospitalManagement.Infrastructure;

public class EncryptionService : IEncrytionService
{
    private readonly byte[] _key;
    private readonly byte[] _IV;

    public EncryptionService(IOptions<EncryptionSettings> encrytionOptions)
    {
        var encryptionSettings = encrytionOptions.Value;
        _key = Encoding.UTF8.GetBytes(encryptionSettings.Key);
        _IV = Encoding.UTF8.GetBytes(encryptionSettings.IV);
    }
    public string Decrypt(string cypherText)
    {
        using Aes aesAlg = Aes.Create();
        aesAlg.Key = _key;
        aesAlg.IV = _IV;

        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

        using MemoryStream msDecrypt = new(Convert.FromBase64String(cypherText));
        using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
        using StreamReader srDecrypt = new(csDecrypt);
        return srDecrypt.ReadToEnd();
    }

    public string Encrypt(string plainText)
    {
        using Aes aesAlg = Aes.Create();
        aesAlg.Key = _key;
        aesAlg.IV = _IV;

        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        using MemoryStream msEncrypt = new();
        using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
        using (StreamWriter swEncrypt = new(csEncrypt))
        {
            swEncrypt.Write(plainText);
        }
        return Convert.ToBase64String(msEncrypt.ToArray());
    }
}
