using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace tgtDemo.Authorization.Users.Dto
{
    public interface IGetUsersInput : ISortedResultRequest
    {
        string Filter { get; set; }

        string Permission { get; set; }

        int? Role { get; set; }

        bool OnlyLockedUsers { get; set; }
    }
}