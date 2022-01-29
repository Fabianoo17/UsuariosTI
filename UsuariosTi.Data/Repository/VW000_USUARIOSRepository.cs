using Corretora.Business.Entities;
using Corretora.Business.Interfaces;
using Corretora.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Corretora.Data.Repository
{
    public class VW000_USUARIOSRepository : Repository<VW000_USUARIOS>, IVW000_USUARIORepository
    {
        public VW000_USUARIOSRepository(CorretoraContext context) : base(context)
        {

        }

        public  IEnumerable<VW000_USUARIOS> PesquisarUsuarios(string nomeOuMatricula)
        {
            nomeOuMatricula += "%";
            return  Entities
                .Where(x => (EF.Functions.Like(x.MATRICULA, nomeOuMatricula) || EF.Functions.Like(x.NOME, nomeOuMatricula)))
                .Take(10)
                .ToList();
        }
    }
}
