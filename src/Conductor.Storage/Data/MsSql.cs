using Conductor.Storage.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;
using System.Data.SqlClient;

namespace Conductor.Storage.Data
{
    /// <inherit/>
    public class MsSql : IDatabaseType
    {
        /// <inherit/>
        public IServiceCollection EnableDatabase(IServiceCollection services, ConnectionSettings connectionOptions)
        {
            return services;
        }

        /// <inherit/>
        public DbConnectionStringBuilder GetConnectionBuilder(string connectionString)
        {
            return new SqlConnectionStringBuilder(connectionString);
        }

        /// <inherit/>
        public DbContextOptionsBuilder GetContextBuilder(DbContextOptionsBuilder optionsBuilder, ConnectionSettings connectionOptions, string connectionString)
        {
            return optionsBuilder.UseSqlServer(connectionString, b => EntityFrameworkConfiguration.GetMigrationInformation(b));
        }

        /// <inherit/>
        public DbContextOptionsBuilder<TContext> SetConnectionString<TContext>(DbContextOptionsBuilder<TContext> contextOptionsBuilder, string connectionString) where TContext : DbContext
        {
            return contextOptionsBuilder.UseSqlServer(connectionString);
        }
    }
}
