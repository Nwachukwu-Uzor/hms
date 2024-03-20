namespace HospitalManagement.Application.Models.Persistence;

public class PaginatedData<T> where T : class
{
    public IReadOnlyList<T> Data { get; set; }
    public int PageSize { get; set; }
    public int PageCount { get; set; }
    public int Page { get; set; }
}
