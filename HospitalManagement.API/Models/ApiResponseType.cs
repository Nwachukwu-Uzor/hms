namespace HospitalManagement.API.Models;

public class ApiResponseType<T>
{
    public T Data { get; set; }
    public bool Status { get; set; }
    public string Message { get; set; } = String.Empty;
}
