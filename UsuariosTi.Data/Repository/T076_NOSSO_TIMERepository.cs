using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
        public class T076_NOSSO_TIMERepository : Repository<T076_NOSSO_TIME>, IT076_NOSSO_TIMERepository
    {
            public T076_NOSSO_TIMERepository(ServicoRegionaisContext context) : base(context)
            {

            }
        }
    }

