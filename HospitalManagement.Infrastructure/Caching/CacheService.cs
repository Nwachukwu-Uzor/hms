using HospitalManagement.Application.Contracts.Caching;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace HospitalManagement.Infrastructure.Caching;

public class CacheService : ICacheService
{
    private readonly IDistributedCache _cache;
    const int DEFAULT_EXPIRY_TIME = 60;

    public CacheService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public async Task SetRecordAsync<T>(string key, T data, TimeSpan? absoluteExpiryTime = null, TimeSpan? unusedExpiryTime = null)
    {
        var options = new DistributedCacheEntryOptions();
        options.AbsoluteExpirationRelativeToNow = absoluteExpiryTime ?? TimeSpan.FromSeconds(DEFAULT_EXPIRY_TIME);
        options.SlidingExpiration = unusedExpiryTime;
        var jsonData = JsonSerializer.Serialize(data);
        await _cache.SetStringAsync(key, jsonData, options);
    }

    public async Task<T> GetRecordAsync<T>(string key)
    {
        var jsonData = await _cache.GetStringAsync(key);
        if (jsonData == null)
        {
            return default(T);
        }
        var serializedData = JsonSerializer.Deserialize<T>(jsonData);
        return serializedData;
    }

    public async Task RemoveRecordAsync(string key)
    {
        await _cache.RemoveAsync(key);
    }
}
