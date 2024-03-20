using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.Persistence.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasData(
            new Department { Id = Guid.Parse("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"), Name = "EMERGENCY DEPARTMENT" },
            new Department { Id = Guid.Parse("6bfb6b7e-2091-4a82-a7a9-f14df1a92450"), Name = "MEDICAL/SURGICAL UNIT" },
            new Department { Id = Guid.Parse("9bfc8c5c-5906-4a44-96ae-71f17e22e7e1"), Name = "INTENSIVE CARE UNIT" },
            new Department { Id = Guid.Parse("b60d76e9-5cc5-44e7-9336-18e45494ff26"), Name = "LABORATORY" },
            new Department { Id = Guid.Parse("5a128d7e-c137-47b1-bd49-2e9733d694ad"), Name = "RADIOLOGY" },
            new Department { Id = Guid.Parse("1aae1f9e-3a45-4ee6-8b3d-f86b2b73b3f9"), Name = "PHARMACY" },
            new Department { Id = Guid.Parse("7b7f70f0-414c-4b25-8602-3e005aeb5869"), Name = "OPERATING ROOMS" },
            new Department { Id = Guid.Parse("a15b0843-2c4d-4bcb-bc88-028e14e6cb69"), Name = "MATERNITY/WOMEN'S HEALTH" },
            new Department { Id = Guid.Parse("02b204b2-ee02-4a25-b087-d21e7cb9abf3"), Name = "PEDIATRICS" },
            new Department { Id = Guid.Parse("fbd52b17-d1b5-44f2-bdc0-af2d749150bf"), Name = "PSYCHIATRY/PSYCHOLOGY" },
            new Department { Id = Guid.Parse("dc06a832-8d7c-42b6-a5c8-177c15dc52ff"), Name = "PHYSICAL THERAPY/REHABILITATION" },
            new Department { Id = Guid.Parse("bf92ad4f-ebae-4e1f-97e4-9f61adba017b"), Name = "NUTRITION SERVICES" },
            new Department { Id = Guid.Parse("2b23f10a-9319-4862-856f-6fca2c64a5f3"), Name = "RESPIRATORY THERAPY" },
            new Department { Id = Guid.Parse("f9a0b47f-8c2c-43dc-9e19-7d963f7f7d43"), Name = "SOCIAL SERVICES" },
            new Department { Id = Guid.Parse("d5f66dc4-dfad-4be0-90a3-251a97ad9462"), Name = "ADMINISTRATION/MANAGEMENT" }
        );
    }
}
