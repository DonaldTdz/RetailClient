using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HC.RetailClient.EntityFrameworkCore
{
    public static class RetailClientDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RetailClientDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RetailClientDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
