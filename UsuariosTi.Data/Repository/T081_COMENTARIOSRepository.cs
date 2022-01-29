using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
    public class T081_COMENTARIOSRepository : Repository<T081_COMENTARIOS>, IT081_COMENTARIOSRepository
    {
        private readonly ServicoRegionaisContext db;
        public T081_COMENTARIOSRepository(ServicoRegionaisContext context) : base(context)
        {
            db = context;
        }

      
    }
}

