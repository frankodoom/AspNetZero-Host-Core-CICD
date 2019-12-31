using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace tgtDemo.EntityFrameworkCore
{
    public static class tgtDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<tgtDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<tgtDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}