using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;

namespace UsuariosTi.Data.Repository
{
    public class T077_UNIDADES_VINCULORepository : Repository<T077_UNIDADES_VINCULO>, IT077_UNIDADES_VINCULORepository
    {
        private readonly ServicoRegionaisContext db;
        public T077_UNIDADES_VINCULORepository(ServicoRegionaisContext context) : base(context)
        {
            db = context;
        }

        public T077_UNIDADES_VINCULO GetUnidade(int cgc)
        {
            return db.T077_UNIDADES_VINCULO.Where(x => x.T077_CGC_FILIAL == cgc).Take(1).FirstOrDefault();
        }

        public T077_UNIDADES_VINCULO GetUnidadeVinculo(int cgc)
        {
            return db.T077_UNIDADES_VINCULO.Where(x => x.T077_CGC_UNIDADE == cgc).Take(1).FirstOrDefault();
        }
    }
}

