using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using tgtDemo.Authorization.Users;
using tgtDemo.MultiTenancy;

namespace tgtDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}