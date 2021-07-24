using Abp.MultiTenancy;
using MAPCore.PhoneBook.Authorization.Users;

namespace MAPCore.PhoneBook.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
