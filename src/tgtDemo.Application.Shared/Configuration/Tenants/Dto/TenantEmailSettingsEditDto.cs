using Abp.Auditing;
using tgtDemo.Configuration.Dto;

namespace tgtDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}