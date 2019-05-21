using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace curve_api.Data
{
    class CurveContextFactory : IDesignTimeDbContextFactory<CurveDBContext>
    {
        public CurveDBContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<CurveDBContext>();
            var connectionString = configuration.GetConnectionString("CurveDB");

            builder.UseSqlServer(connectionString);

            return new CurveDBContext(builder.Options);
        }
    }
}
