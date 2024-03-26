using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Contracts.Persistence
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
       Task<Patient> GetPatientByPatientID(string patientID);
        Task<Patient> GetPatientByAppUserID(Guid appUserId);
    }
}
