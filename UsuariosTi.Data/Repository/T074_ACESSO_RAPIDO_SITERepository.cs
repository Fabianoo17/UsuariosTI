using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
        public class T074_ACESSO_RAPIDO_SITERepository : Repository<T074_ACESSO_RAPIDO_SITE>, IT074_ACESSO_RAPIDO_SITERepository
        {
            public T074_ACESSO_RAPIDO_SITERepository(ServicoRegionaisContext context) : base(context)
            {

            }
        }
    }

