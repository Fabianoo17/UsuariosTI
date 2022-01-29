using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW012_LISTA_DICASTIRepository : Repository<VW012_LISTA_DICASTI>, IVW012_LISTA_DICASTIRepository
    {
        public VW012_LISTA_DICASTIRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
