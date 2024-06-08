using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HCA.EntityFrameworkCore
{
    public static class HCADbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HCADbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HCADbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
