using System.Threading.Tasks;
using Abp.Dependency;

namespace tgtDemo.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}