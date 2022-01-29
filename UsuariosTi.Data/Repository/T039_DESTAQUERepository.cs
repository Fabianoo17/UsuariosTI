using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T039_DESTAQUERepository : Repository<T039_DESTAQUE>, IT039_DESTAQUERepository
    {
        public T039_DESTAQUERepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
