using System.Collections.Generic;
using tgtDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace tgtDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
