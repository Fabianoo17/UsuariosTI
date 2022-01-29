using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T052_PRESTADORES_SCPRepository : Repository<T052_PRESTADORES_SCP>, IT052_PRESTADORES_SCPRepository
    {
        public T052_PRESTADORES_SCPRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
