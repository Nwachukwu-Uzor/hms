using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.Persistence.Configurations;

public class DoctorJobConfiguration : IEntityTypeConfiguration<DoctorJob>
{
    public void Configure(EntityTypeBuilder<DoctorJob> builder)
    {

        builder.HasData(
            new DoctorJob
            {
                Id = Guid.Parse("e457d0d7-7f7d-4dd1-91b6-57ae307dc9bd"),
                JobId = Guid.Parse("5a04295f-4886-4bc9-b15e-2aaf303e5fc3")
            },
            new DoctorJob
            {
                Id = Guid.Parse("ed88073f-6b2f-41ee-8ac0-956ef67932c8"),
                JobId = Guid.Parse("ab14514d-67a2-4d8f-bc38-145c7eb665d8")
            },
            new DoctorJob
            {
                Id = Guid.Parse("868edd64-161b-40e3-8ca2-38426fcdb05c"),
                JobId = Guid.Parse("9795f052-3023-40b0-9ba4-4e1d1b7f3a23")
            },
            new DoctorJob
            {
                Id = Guid.Parse("f71b6604-e5ff-4454-b666-565e833b8f2d"),
                JobId = Guid.Parse("8e0d7ed5-15b7-4c63-8694-7e2f6e1614d5")
            },
            new DoctorJob
            {
                Id = Guid.Parse("680521fa-d14a-48be-b36c-76b0f4f7eb2b"),
                JobId = Guid.Parse("8f6ddc41-3b65-42b1-85f2-9a9de16e8394")
            },
            new DoctorJob
            {
                Id = Guid.Parse("a8d434fd-355d-42c0-9c16-3621a7bc2085"),
                JobId = Guid.Parse("c6c6b083-9717-4384-bc8b-c6fcf8e56d61")
            }
        );
    }
}
