using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
    public class T082_INTERACOES_ULTIMAS_ACOESRepository : Repository<T082_INTERACOES_ULTIMAS_ACOES>, IT082_INTERACOES_ULTIMAS_ACOESRepository
    {
        private readonly ServicoRegionaisContext db;
        public T082_INTERACOES_ULTIMAS_ACOESRepository(ServicoRegionaisContext context) : base(context)
        {
            db = context;
        }

      
    }
}

