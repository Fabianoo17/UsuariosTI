using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace UsuariosTi.Data.Repository
{
    public class T072_PRESTADOR_SIGOCRepository : Repository<T072_PRESTADOR_SIGOC>, IT072_PRESTADOR_SIGOCRepository
    {
        public T072_PRESTADOR_SIGOCRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}

