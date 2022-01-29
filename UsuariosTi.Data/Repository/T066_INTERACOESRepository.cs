using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T066_INTERACOESRepository : Repository<T066_INTERACOES>, IT066_INTERACOESRepository
    {
        public T066_INTERACOESRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
