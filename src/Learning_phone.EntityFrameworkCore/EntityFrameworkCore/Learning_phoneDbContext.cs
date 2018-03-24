using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Learning_phone.Authorization.Roles;
using Learning_phone.Authorization.Users;
using Learning_phone.MultiTenancy;

namespace Learning_phone.EntityFrameworkCore
{
    public class Learning_phoneDbContext : AbpZeroDbContext<Tenant, Role, User, Learning_phoneDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Learning_phoneDbContext(DbContextOptions<Learning_phoneDbContext> options)
            : base(options)
        {
        }
    }
}
