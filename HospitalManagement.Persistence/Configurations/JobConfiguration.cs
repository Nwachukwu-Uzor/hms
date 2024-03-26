using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Persistence.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(
            new Job
            {
                Id = Guid.Parse("5a04295f-4886-4bc9-b15e-2aaf303e5fc3"),
                Title = "Physician",
                DepartmentId = Guid.Parse("0169dd27-a25a-46d7-91c5-5c24e0a5fd54")
            }, // EMERGENCY DEPARTMENT
            new Job
            {
                Id = Guid.Parse("1e5f2fc7-eb9e-45c7-93a2-4d017a7a6e7a"),
                Title = "Registered Nurse",
                DepartmentId = Guid.Parse("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
            },// EMERGENCY DEPARTMENT
            new Job
            {
                Id = Guid.Parse("ab14514d-67a2-4d8f-bc38-145c7eb665d8"),
                Title = "Surgeon",
                DepartmentId = Guid.Parse("7b7f70f0-414c-4b25-8602-3e005aeb5869"),
            },// OPERATING ROOMS
            new Job
            {
                Id = Guid.Parse("c6c6b083-9717-4384-bc8b-c6fcf8e56d61"),
                Title = "Anesthesiologist",
                DepartmentId = Guid.Parse("7b7f70f0-414c-4b25-8602-3e005aeb5869")
            }, // OPERATING ROOMS
            new Job { 
                Id = Guid.Parse("5642065b-1d35-4c33-9f05-47fe23b74c4d"), 
                Title = "Radiologic Technologist", 
                DepartmentId = Guid.Parse("5a128d7e-c137-47b1-bd49-2e9733d694ad") 
            }, // RADIOLOGY
            new Job { 
                Id = Guid.Parse("9835fc30-d1a9-4f67-84a1-4930edf7f883"), 
                Title = "Pharmacist", 
                DepartmentId = Guid.Parse("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9")  
            }, // PHARMACY
            new Job { 
                Id = Guid.Parse("9795f052-3023-40b0-9ba4-4e1d1b7f3a23"), 
                Title = "Pediatrician", 
                DepartmentId = Guid.Parse("02b204b2-ee02-4a25-b087-d21e7cb9abf3")
            }, // PEDIATRICS
            new Job { 
                Id = Guid.Parse("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5"), 
                Title = "Psychiatrist", 
                DepartmentId = Guid.Parse("fbd52b17-d1b5-44f2-bdc0-af2d749150bf")
            }, // PSYCHIATRY/PSYCHOLOGY
            new Job { 
                Id = Guid.Parse("026fb0dc-af73-4ff9-99b1-d6226b1c4ed2"), 
                Title = "Physical Therapist", 
                DepartmentId = Guid.Parse("dc06a832-8d7c-42b6-a5c8-177c15dc52ff")
            }, // PHYSICAL THERAPY/REHABILITATION
            new Job { 
                Id = Guid.Parse("1cb98f70-2c59-4962-aae1-d6e3f2f3e145"), 
                Title = "Nutritionist", 
                DepartmentId = Guid.Parse("bf92ad4f-ebae-4e1f-97e4-9f61adba017b") 
            }, // NUTRITION SERVICES
            new Job { 
                Id = Guid.Parse("8f6ddc41-3b65-42b1-85f2-9a9de16e8394"), 
                Title = "Respiratory Therapist", 
                DepartmentId = Guid.Parse("2b23f10a-9319-4862-856f-6fca2c64a5f3"),
            }, // RESPIRATORY THERAPY
            new Job { 
                Id = Guid.Parse("2385e258-05fb-4f06-9768-71a179a1df6d"), 
                Title = "Social Worker", 
                DepartmentId = Guid.Parse("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43") 
            } // SOCIAL SERVICES
           );
        }
    }
}
