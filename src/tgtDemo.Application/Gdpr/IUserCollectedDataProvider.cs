using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using tgtDemo.Dto;

namespace tgtDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
