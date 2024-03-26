using HospitalManagement.Application.Features.AppUser.Commands.LoginAdminUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.Patient.DTOs;

public class PatientDto
{
    public Guid Id { get; set; }
    public string PatientID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Genotype { get; set; }
    public string BloodGroup { get; set; }
    public string PhoneNumber { get; set; }
    public string Country { get; set; }
    public AppUserDto AppUser { get; set; }
}
