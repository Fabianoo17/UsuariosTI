using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
    public class T073_CARROSSELRepository : Repository<T073_CARROSSEL>, IT073_CARROSSELRepository
    {
        public T073_CARROSSELRepository(ServicoRegionaisContext context) : base(context)
        {

        }

    }
}
