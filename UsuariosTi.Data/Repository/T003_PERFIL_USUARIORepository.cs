using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T003_PERFIL_USUARIORepository : Repository<T003_PERFIL_USUARIO>, IT003_PERFIL_USUARIORepository
    {
        public T003_PERFIL_USUARIORepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
