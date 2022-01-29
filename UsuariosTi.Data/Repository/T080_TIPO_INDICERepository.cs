using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
    public class T080_TIPO_INDICERepository : Repository<T080_TIPO_INDICE>, IT080_TIPO_INDICERepository
    {
        private readonly ServicoRegionaisContext db;
        public T080_TIPO_INDICERepository(ServicoRegionaisContext context) : base(context)
        {
            db = context;
        }

      
    }
}

