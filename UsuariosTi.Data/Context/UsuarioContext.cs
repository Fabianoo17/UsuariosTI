using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Corretora.Business.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Corretora.Data.Context
{
    public class UsuarioContext : DbContext
    {
        public DbSet<VW000_USUARIOS> VW000_USUARIOS { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
                .Build();
            var connection = configuration.GetConnectionString("CorretoraConnection");
            optionsBuilder.UseSqlServer(connection);

            base.OnConfiguring(optionsBuilder);
        }


    }


}
