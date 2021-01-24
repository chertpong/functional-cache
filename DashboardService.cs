using System.Threading.Tasks;

namespace FunctionalCache
{
    public class DashboardService : IDashboardService
    {
        public Task<DashboardSetting> FindAsyncByUserId(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DashboardSetting> FindAsyncByUserIdAndEnvironment(string id, string environment)
        {
            throw new System.NotImplementedException();
        }

        public Task<DashboardSetting> FindAsyncByUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<DashboardSetting> CreateSetting(DashboardSetting dashboardSetting, User user)
        {
            throw new System.NotImplementedException();
        }
    }
}