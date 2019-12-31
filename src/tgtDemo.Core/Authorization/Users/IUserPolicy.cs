using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace tgtDemo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
