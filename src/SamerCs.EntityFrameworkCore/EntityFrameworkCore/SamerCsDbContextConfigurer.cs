using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SamerCs.EntityFrameworkCore
{
    public static class SamerCsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SamerCsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SamerCsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
