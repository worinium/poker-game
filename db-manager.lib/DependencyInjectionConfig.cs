using db_manager.lib.Abstractions;
using db_manager.lib.DataManagers;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using poker_game.domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace db_manager.lib
{
    public static class DependencyInjectionConfig
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            // Configure NHibernate session factory
            var sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User>())
                .ExposeConfiguration(cfg =>
                {
                    // Generate the database schema
                    new SchemaExport(cfg).Create(true, true);
                })
                .BuildSessionFactory();

            // Register session factory and session per request
            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => factory.GetService<ISessionFactory>().OpenSession());

            // Register repositories
            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IRepository<Game>, Repository<Game>>();
            services.AddScoped<IRepository<Hand>, Repository<Hand>>();
            services.AddScoped<IRepository<Player>, Repository<Player>>();
            services.AddScoped<IRepository<Bet>, Repository<Bet>>();
            services.AddScoped<IRepository<Card>, Repository<Card>>();
        }
    }

}
