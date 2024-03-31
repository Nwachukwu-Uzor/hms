using HospitalManagement.Application.Contracts;
using HospitalManagement.Application.Models.AccessCodeService;
using Microsoft.Extensions.Options;
using System.Text;

namespace HospitalManagement.Infrastructure;

public class AccessCodeService : IAccessCodeService
{
    private readonly int _codeLength;

    private readonly Random random;

    public AccessCodeService(IOptions<AccessCodeSettings> accessCodeOptions)
    {
        random = new Random();
        _codeLength = accessCodeOptions.Value.AccessCodeLength;
    }

    public string GenerateAccessCode()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var codeBuilder = new StringBuilder();

        for (int i = 0; i < _codeLength; i++)
        {
            codeBuilder.Append(chars[random.Next(chars.Length)]);
        }

        return codeBuilder.ToString();
    }
}
