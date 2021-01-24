using System;
using System.Threading.Tasks;

namespace FunctionalCache
{
    public class CacheableDashboardService : IDashboardService
    {
        private readonly IDashboardService _dashboardService;
        private readonly Cacheable _cacheable;

        public CacheableDashboardService(IDashboardService dashboardService, Cacheable cacheable)
        {
            _dashboardService = dashboardService;
            _cacheable = cacheable;
        }

        public Task<DashboardSetting> FindAsyncByUserId(string id)
        {
            return _cacheable.FromCacheOrExecute(
                key:id,
                () => _dashboardService.FindAsyncByUserId(id)
            );
        }

        public Task<DashboardSetting> FindAsyncByUserIdAndEnvironment(string id, string environment)
        {
            return _cacheable.FromCacheOrExecute(
                $"{id}_{environment}",
                () => _dashboardService.FindAsyncByUserId(id)
            );
        }

        public Task<DashboardSetting> FindAsyncByUser(User user)
        {
            return _cacheable.FromCacheOrExecute(
                $"some_prefix--{user.Id}",
                () => _dashboardService.FindAsyncByUserId(user.Id)
            );        
        }

        public Task<DashboardSetting> CreateSetting(DashboardSetting dashboardSetting, User user)
        {
            return _cacheable.Cache(
                $"some_prefix--{user.Id}",
                TimeSpan.FromSeconds(60),
                () => _dashboardService.CreateSetting(dashboardSetting, user)
            );
        }
    }
}