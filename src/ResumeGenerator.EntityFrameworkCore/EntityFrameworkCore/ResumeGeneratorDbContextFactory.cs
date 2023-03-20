using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ResumeGenerator.Configuration;
using ResumeGenerator.Web;

namespace ResumeGenerator.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ResumeGeneratorDbContextFactory : IDesignTimeDbContextFactory<ResumeGeneratorDbContext>
    {
        public ResumeGeneratorDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ResumeGeneratorDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ResumeGeneratorDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ResumeGeneratorConsts.ConnectionStringName));

            return new ResumeGeneratorDbContext(builder.Options);
        }
    }
}
