using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW005_RETRATO_TI_SERVICOS_REGIONAISRepository : Repository<VW005_RETRATO_TI_SERVICOS_REGIONAIS>, IVW005_RETRATO_TI_SERVICOS_REGIONAISRepository
    {
        public VW005_RETRATO_TI_SERVICOS_REGIONAISRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
