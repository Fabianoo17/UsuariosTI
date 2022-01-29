using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW007_CONSOLIDADO_PLANTONISTASRepository : Repository<VW007_CONSOLIDADO_PLANTONISTAS>, IVW007_CONSOLIDADO_PLANTONISTASRepository
    {
        public VW007_CONSOLIDADO_PLANTONISTASRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
