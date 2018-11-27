using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HC.RetailClient.Authorization.Roles;
using HC.RetailClient.Authorization.Users;
using HC.RetailClient.MultiTenancy;

namespace HC.RetailClient.EntityFrameworkCore
{
    public class RetailClientDbContext : AbpZeroDbContext<Tenant, Role, User, RetailClientDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RetailClientDbContext(DbContextOptions<RetailClientDbContext> options)
            : base(options)
        {
        }
    }
}
