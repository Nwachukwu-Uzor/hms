namespace HospitalManagement.Application.Contracts.Caching;

public interface ICacheService
{
    Task SetRecordAsync<T>(string key, T data, TimeSpan? absoluteExpiryTime = null, TimeSpan? unusedExpiryTime = null);
    Task<T> GetRecordAsync<T>(string key);
    Task RemoveRecordAsync(string key);
}
