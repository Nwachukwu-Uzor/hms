using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Persistence.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Patient> GetPatientByPatientID(string patientID)
        {
            throw new NotImplementedException();
        }
    }
}
