using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SamerCs.Configuration;
using SamerCs.Web;

namespace SamerCs.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SamerCsDbContextFactory : IDesignTimeDbContextFactory<SamerCsDbContext>
    {
        public SamerCsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SamerCsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SamerCsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SamerCsConsts.ConnectionStringName));

            return new SamerCsDbContext(builder.Options);
        }
    }
}
