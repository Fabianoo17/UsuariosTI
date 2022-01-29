using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T029_QUEM_SOMOSRepository : Repository<T029_QUEM_SOMOS>, IT029_QUEM_SOMOSRepository
    {
        public T029_QUEM_SOMOSRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
