using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW013_LISTA_COMENTARIOSRepository : Repository<VW013_LISTA_COMENTARIOS>, IVW013_LISTA_COMENTARIOSRepository
    {
        public VW013_LISTA_COMENTARIOSRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
