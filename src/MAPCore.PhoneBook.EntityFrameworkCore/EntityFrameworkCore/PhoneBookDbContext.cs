using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MAPCore.PhoneBook.Authorization.Roles;
using MAPCore.PhoneBook.Authorization.Users;
using MAPCore.PhoneBook.MultiTenancy;

namespace MAPCore.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}
