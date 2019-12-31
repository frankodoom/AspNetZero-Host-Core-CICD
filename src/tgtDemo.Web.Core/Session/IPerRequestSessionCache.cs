using System.Threading.Tasks;
using tgtDemo.Sessions.Dto;

namespace tgtDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
