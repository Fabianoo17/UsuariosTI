using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T065_DICAS_TIRepository : Repository<T065_DICAS_TI>, IT065_DICAS_TIRepository
    {
        public T065_DICAS_TIRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
