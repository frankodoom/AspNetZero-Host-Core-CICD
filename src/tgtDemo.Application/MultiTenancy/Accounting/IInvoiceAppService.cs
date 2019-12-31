using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using tgtDemo.MultiTenancy.Accounting.Dto;

namespace tgtDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
