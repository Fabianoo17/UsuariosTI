using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository : Repository<VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETEC>, IVW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository
    {
        public VW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
