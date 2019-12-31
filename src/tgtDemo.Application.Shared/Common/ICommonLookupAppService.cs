using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tgtDemo.Common.Dto;
using tgtDemo.Editions.Dto;

namespace tgtDemo.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}