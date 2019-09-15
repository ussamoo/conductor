using System.Data.Common;
using Conductor.Storage.Data;
using Conductor.Storage.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

namespace DeviceManager.Api.Configuration.DatabaseTypes
{
    public class MySql : IDatabaseType
    {
        public IServiceCollection EnableDatabase(IServiceCollection services, ConnectionSettings connectionOptions)
        {
            return services;
        }

        public DbConnectionStringBuilder GetConnectionBuilder(string connectionString)
        {
           return new MySqlConnectionStringBuilder(connectionString);
        }

        public DbContextOptionsBuilder GetContextBuilder(DbContextOptionsBuilder optionsBuilder, ConnectionSettings connectionOptions, string connectionString)
        {
            return optionsBuilder.UseMySql(connectionString, b => EntityFrameworkConfiguration.GetMigrationInformation(b));
        }

        public DbContextOptionsBuilder<TContext> SetConnectionString<TContext>(DbContextOptionsBuilder<TContext> contextOptionsBuilder, string connectionString) where TContext : DbContext
        {
            return contextOptionsBuilder.UseMySql(connectionString);
        }
    }
}
