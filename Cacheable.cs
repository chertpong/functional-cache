using System;
using System.Threading.Tasks;

namespace FunctionalCache
{
    public class Cacheable
    {
        public async Task<T> FromCacheOrExecute<T>(string key, Func<Task<T>> valueFunc)
        {
            // get from cache or execute below
            var result = await valueFunc();
            // caching here
            return result;
        }

        public async Task<T> Cache<T>(string key, TimeSpan expiry, Func<Task<T>> valueFunc)
        {
            // get from cache or execute below
            var result = await valueFunc();
            // caching here
            return result;
        }
    }
}