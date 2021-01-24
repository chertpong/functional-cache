using System.Threading.Tasks;

namespace FunctionalCache
{
    public interface IDashboardService
    {
        Task<DashboardSetting> FindAsyncByUserId(string id);
        
        Task<DashboardSetting> FindAsyncByUserIdAndEnvironment(string id, string environment);

        Task<DashboardSetting> FindAsyncByUser(User user);

        Task<DashboardSetting> CreateSetting(DashboardSetting dashboardSetting, User user);
    }
}