using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository : Repository<VW001_RELATORIO_QTD_EMPREGADOS_CN_GI>, IVW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository
    {
        public VW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
