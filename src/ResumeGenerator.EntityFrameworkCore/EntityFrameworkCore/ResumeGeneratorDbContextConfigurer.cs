using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ResumeGenerator.EntityFrameworkCore
{
    public static class ResumeGeneratorDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ResumeGeneratorDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ResumeGeneratorDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
