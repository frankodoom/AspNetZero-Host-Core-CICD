using System.Threading.Tasks;
using Abp.Application.Services;
using tgtDemo.Editions.Dto;
using tgtDemo.MultiTenancy.Dto;

namespace tgtDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}