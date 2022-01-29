using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
    public class T078_CIAUS_TEXTORepository : Repository<T078_CIAUS_TEXTO>, IT078_CIAUS_TEXTORepository
    {
        private readonly ServicoRegionaisContext db;
        public T078_CIAUS_TEXTORepository(ServicoRegionaisContext context) : base(context)
        {
            db = context;
        }

      
    }
}

