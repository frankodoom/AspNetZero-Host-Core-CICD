using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using tgtDemo.Configuration;
using tgtDemo.Web;

namespace tgtDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class tgtDemoDbContextFactory : IDesignTimeDbContextFactory<tgtDemoDbContext>
    {
        public tgtDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<tgtDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            tgtDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(tgtDemoConsts.ConnectionStringName));

            return new tgtDemoDbContext(builder.Options);
        }
    }
}