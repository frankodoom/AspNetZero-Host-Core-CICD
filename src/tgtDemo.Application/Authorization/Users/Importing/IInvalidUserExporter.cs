using System.Collections.Generic;
using tgtDemo.Authorization.Users.Importing.Dto;
using tgtDemo.Dto;

namespace tgtDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
