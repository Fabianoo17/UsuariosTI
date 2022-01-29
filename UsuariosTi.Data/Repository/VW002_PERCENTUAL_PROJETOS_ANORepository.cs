using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW002_PERCENTUAL_PROJETOS_ANORepository : Repository<VW002_PERCENTUAL_PROJETOS_ANO>, IVW002_PERCENTUAL_PROJETOS_ANORepository
    {
        public VW002_PERCENTUAL_PROJETOS_ANORepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
