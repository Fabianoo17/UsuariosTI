using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Corretora.Business.Entities;
using System;
using System.IO;

namespace Corretora.Data.Context
{
    public class CorretoraContext : DbContext
    {
        public CorretoraContext(DbContextOptions options): base(options)
        {

        }

        //TABELA 
        public DbSet<T002_PERFIL> T002_PERFIL { get; set; }
        public DbSet<T003_PERFIL_USUARIO> T003_PERFIL_USUARIO { get; set; }



        //VIEWS
        public DbSet<VW000_USUARIOS> VW000_USUARIOS { get; set; }
 
    }
}
