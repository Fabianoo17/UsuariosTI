using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T067_COMENTARIOSRepository : Repository<T067_COMENTARIOS>, IT067_COMENTARIOSRepository
    {
        public T067_COMENTARIOSRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
