using System.Threading.Tasks;
using Abp.Application.Services;
using tgtDemo.MultiTenancy.Payments.Dto;
using tgtDemo.MultiTenancy.Payments.PayPal.Dto;

namespace tgtDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalPaymentId, string paypalPayerId);

        PayPalConfigurationDto GetConfiguration();

        Task CancelPayment(CancelPaymentDto input);
    }
}
