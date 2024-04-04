using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public class CompletePatientDetailsCommand : IRequest<PatientDto>
{
    public Guid AppUserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Genotype { get; set; }
    public string BloodGroup { get; set; }
    public string PhoneNumber { get; set; }
    public string Country { get; set; }
}
