using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.Patient;

public class CreatePatientPasswordCommand : IRequest<Guid>
{
    public Guid PatientRegisterationRequestId { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
