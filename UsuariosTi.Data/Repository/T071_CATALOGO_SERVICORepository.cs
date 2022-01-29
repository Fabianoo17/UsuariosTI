using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace UsuariosTi.Data.Repository
{
    public class T071_CATALOGO_SERVICORepository : Repository<T071_CATALOGO_SERVICO>, IT071_CATALOGO_SERVICORepository
    {
        public T071_CATALOGO_SERVICORepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}

