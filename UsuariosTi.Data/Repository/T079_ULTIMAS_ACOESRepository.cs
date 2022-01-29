using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
    public class T079_ULTIMAS_ACOESRepository : Repository<T079_ULTIMAS_ACOES>, IT079_ULTIMAS_ACOESRepository
    {
        private readonly ServicoRegionaisContext db;
        public T079_ULTIMAS_ACOESRepository(ServicoRegionaisContext context) : base(context)
        {
            db = context;
        }

      
    }
}

