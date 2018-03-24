using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Learning_phone.Configuration;
using Learning_phone.Web;

namespace Learning_phone.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Learning_phoneDbContextFactory : IDesignTimeDbContextFactory<Learning_phoneDbContext>
    {
        public Learning_phoneDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Learning_phoneDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Learning_phoneDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Learning_phoneConsts.ConnectionStringName));

            return new Learning_phoneDbContext(builder.Options);
        }
    }
}
