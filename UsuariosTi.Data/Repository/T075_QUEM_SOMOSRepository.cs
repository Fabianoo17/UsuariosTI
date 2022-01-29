using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
        public class T075_QUEM_SOMOSRepository : Repository<T075_QUEM_SOMOS>, IT075_QUEM_SOMOSRepository
    {
            public T075_QUEM_SOMOSRepository(ServicoRegionaisContext context) : base(context)
            {

            }
        }
    }

