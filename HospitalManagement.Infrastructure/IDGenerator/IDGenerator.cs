using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Models.IDGenerator;
using Microsoft.Extensions.Options;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace HospitalManagement.Infrastructure.IDGenerator;

public class IDGenerator : IIDGenerator
{
    private readonly IDSettings _idSettings;
    const string VALID_CHARS = "1234567890";
    private readonly IStaffRepository _staffRepository;
    private readonly IPatientRepository _patientRepository;

    public IDGenerator(
        IOptions<IDSettings> idOptions,
        IStaffRepository staffRepository,
        IPatientRepository patientRepository
    )
    {
        _idSettings = idOptions.Value;
        _staffRepository = staffRepository;
        _patientRepository = patientRepository;
    }

    private string GenerateRandomString(int length)
    {
        byte[] data = new byte[length];

        // Use RandomNumberGenerator to generate random bytes
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(data);
        }

        // Create a StringBuilder to store the resulting string
        StringBuilder resultBuilder = new StringBuilder(length);

        // Map the random bytes to characters in the character set
        for (int i = 0; i < length; i++)
        {
            resultBuilder.Append(VALID_CHARS[data[i] % VALID_CHARS.Length]);
        }

        return resultBuilder.ToString();
    }

    public async Task<string> GeneratePatientIDNumber()
    {

        var patientId = $"{_idSettings.PatientIDPrefix}{GenerateRandomString(_idSettings.IDLength)}";
        while ((await _patientRepository.GetPatientByPatientID(patientId)) != null)
        {
            patientId = $"{_idSettings.PatientIDPrefix}{GenerateRandomString(_idSettings.IDLength)}";
        }
        return patientId;
    }

    public async Task<string> GenerateStaffIDNumber()
    {
        var staffId = $"{_idSettings.StaffIDPrefix}{GenerateRandomString(_idSettings.IDLength)}";
        while ((await _staffRepository.GetStaffByStaffID(staffId)) != null)
        {
            staffId = $"{_idSettings.StaffIDPrefix}{GenerateRandomString(_idSettings.IDLength)}";
        }
        return staffId;
    }
}
