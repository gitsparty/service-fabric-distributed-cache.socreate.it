﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;

namespace SoCreate.Extensions.Caching.ServiceFabric
{
    public interface IDistributedCacheWithCreate : IDistributedCache
    {
        Task<byte[]> CreateCachedItemAsync(
            string key,
            byte[] value,
            DistributedCacheEntryOptions options);
    }
}
