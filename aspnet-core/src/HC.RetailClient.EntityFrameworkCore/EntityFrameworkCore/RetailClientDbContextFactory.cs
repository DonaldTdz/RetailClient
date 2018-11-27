using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HC.RetailClient.Configuration;
using HC.RetailClient.Web;

namespace HC.RetailClient.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RetailClientDbContextFactory : IDesignTimeDbContextFactory<RetailClientDbContext>
    {
        public RetailClientDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RetailClientDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RetailClientDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RetailClientConsts.ConnectionStringName));

            return new RetailClientDbContext(builder.Options);
        }
    }
}
