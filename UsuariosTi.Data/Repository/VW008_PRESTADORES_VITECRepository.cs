using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW008_PRESTADORES_VITECRepository : Repository<VW008_PRESTADORES_VITEC>, IVW008_PRESTADORES_VITECRepository
    {
        public VW008_PRESTADORES_VITECRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
