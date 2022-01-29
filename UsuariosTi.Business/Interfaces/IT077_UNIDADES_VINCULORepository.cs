using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;

namespace UsuariosTi.Business.Interfaces
{
    public interface IT077_UNIDADES_VINCULORepository : IRepository<T077_UNIDADES_VINCULO>
    {
        T077_UNIDADES_VINCULO GetUnidadeVinculo(int cgc);
        T077_UNIDADES_VINCULO GetUnidade(int cgc);
    }

}
