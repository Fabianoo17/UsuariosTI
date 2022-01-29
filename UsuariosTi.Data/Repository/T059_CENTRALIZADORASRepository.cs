using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T059_CENTRALIZADORASRepository : Repository<T059_CENTRALIZADORAS>, IT059_CENTRALIZADORASRepository
    {
        public T059_CENTRALIZADORASRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
