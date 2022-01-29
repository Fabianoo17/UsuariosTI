using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW004_LISTA_USUARIO_ACESSORepository : Repository<VW004_LISTA_USUARIO_ACESSO>, IVW004_LISTA_USUARIO_ACESSORepository
    {
        public VW004_LISTA_USUARIO_ACESSORepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
