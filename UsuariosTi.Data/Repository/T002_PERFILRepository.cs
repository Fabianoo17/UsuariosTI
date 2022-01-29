using Corretora.Business.Entities;
using Corretora.Business.Interfaces;
using Corretora.Data.Context;
using Corretora.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corretora.Data.Repository
{
    public class T002_PERFILRepository : Repository<T002_PERFIL>, IT002_PERFILRepository
    {
        public T002_PERFILRepository(CorretoraContext context) : base(context)
        {

        }
    }
}
