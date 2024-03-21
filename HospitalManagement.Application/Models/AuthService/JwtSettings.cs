﻿namespace HospitalManagement.Application.Models.AuthService;

public class JwtSettings
{
    public string Key { get; set; }
    public string Issuer { get; set; }
    public int ExpiresIn { get; set; }
    public string Audience { get; set; }
}
