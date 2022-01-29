using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T002_PERFILRepository : Repository<T002_PERFIL>, IT002_PERFILRepository
    {
        public T002_PERFILRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
