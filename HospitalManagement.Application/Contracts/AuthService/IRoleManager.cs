namespace HospitalManagement.Application.Contracts.AuthService
{
    public interface IRoleManager
    {
        Task AddUserToRole(Guid userId, Guid roleId);
        Task RemoveUserFromRole(Guid userId, Guid roleId);
    }
}
