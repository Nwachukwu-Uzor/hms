using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Logging;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace HospitalManagement.Infrastructure.Caching;

public class CacheService : ICacheService
{
    private readonly IDistributedCache _cache;
    private readonly IAppLogger<CacheService> _logger;
    const int DEFAULT_EXPIRY_TIME = 60;

    public CacheService(IDistributedCache cache, IAppLogger<CacheService> logger)
    {
        _cache = cache;
        _logger = logger;
    }

    public async Task SetRecordAsync<T>(string key, T data, TimeSpan? absoluteExpiryTime = null, TimeSpan? unusedExpiryTime = null)
    {
        try
        {
            var options = new DistributedCacheEntryOptions();
            options.AbsoluteExpirationRelativeToNow = absoluteExpiryTime ?? TimeSpan.FromSeconds(DEFAULT_EXPIRY_TIME);
            options.SlidingExpiration = unusedExpiryTime;
            var jsonData = JsonSerializer.Serialize(data);
            await _cache.SetStringAsync(key, jsonData, options);

        }
        catch (Exception ex)
        {
            _logger.LogWarning($"Attempt to set cache record for key {key} failed", ex);
        }
    }

    public async Task<T> GetRecordAsync<T>(string key)
    {
        try
        {
            var jsonData = await _cache.GetStringAsync(key);
            if (jsonData == null)
            {
                return default(T);
            }
            var serializedData = JsonSerializer.Deserialize<T>(jsonData);
            return serializedData;

        }
        catch (Exception ex)
        {
            _logger.LogWarning($"Attempt to get cache record for key {key} failed", ex);
            return default(T);
        }
    }

    public async Task RemoveRecordAsync(string key)
    {
        try
        {
            await _cache.RemoveAsync(key);

        }
        catch (Exception ex)
        {
            _logger.LogWarning($"Attempt to clear cache record for key {key} failed", ex);
        }
    }
}
