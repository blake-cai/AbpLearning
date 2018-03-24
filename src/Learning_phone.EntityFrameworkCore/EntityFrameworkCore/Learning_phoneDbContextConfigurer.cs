using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Learning_phone.EntityFrameworkCore
{
    public static class Learning_phoneDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Learning_phoneDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Learning_phoneDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
