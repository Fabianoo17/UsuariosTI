using Corretora.Business.Entities;
using Corretora.Business.Interfaces;
using Corretora.Data.Context;
using Corretora.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corretora.Data.Repository
{
    public class T003_PERFIL_USUARIORepository : Repository<T003_PERFIL_USUARIO>, IT003_PERFIL_USUARIORepository
    {
        public T003_PERFIL_USUARIORepository(CorretoraContext context) : base(context)
        {

        }
    }
}
