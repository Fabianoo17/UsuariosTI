using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW016_RELATORIO_PRESTADORESRepository : Repository<VW016_RELATORIO_PRESTADORES>, IVW016_RELATORIO_PRESTADORESRepository
    {
        public VW016_RELATORIO_PRESTADORESRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
