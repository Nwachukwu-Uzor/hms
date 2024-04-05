namespace HospitalManagement.Application.Models.Persistence;

public record PaginatedData<T>(List<T> Data, int PageSize, int TotalRecords, int CurrentPage) where T : class
{
    public decimal TotalPages => Math.Ceiling((decimal)TotalRecords / PageSize);
}
