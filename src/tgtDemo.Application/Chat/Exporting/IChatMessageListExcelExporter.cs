using System.Collections.Generic;
using tgtDemo.Chat.Dto;
using tgtDemo.Dto;

namespace tgtDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
