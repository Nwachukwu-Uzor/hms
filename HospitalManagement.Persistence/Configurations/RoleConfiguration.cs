using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.Persistence.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasData(
            new Role
            {
                Id = Guid.Parse("5f10c02a-fa84-4936-837d-afa77e5bb238"),
                Name = "ADMIN",
            },
            new Role
            {
                Id = Guid.Parse("607fbfc9-b509-48b9-acd0-dcfdcda51daa"),
                Name = "SUPERADMIN",
            },
            new Role
            {
                Id = Guid.Parse("409dfa54-8822-41fc-8f93-f2a31378e436"),
                Name = "STAFF",
            }, 
            new Role
            {
                Id = Guid.Parse("0169dd27-a25a-46d7-91c5-5c24e0a5fd54"),
                Name = "PATIENT",
            }
        );
    }
}
