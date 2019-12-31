using System.Collections.Generic;
using tgtDemo.Authorization.Users.Dto;
using tgtDemo.Dto;

namespace tgtDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}