using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW014_LISTA_PRESTADOR_SIGOCRepository : Repository<VW014_LISTA_PRESTADOR_SIGOC>, IVW014_LISTA_PRESTADOR_SIGOCRepository
    {
        public VW014_LISTA_PRESTADOR_SIGOCRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
