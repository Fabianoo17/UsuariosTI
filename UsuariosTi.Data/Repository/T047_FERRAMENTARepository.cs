using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T047_FERRAMENTARepository : Repository<T047_FERRAMENTA>, IT047_FERRAMENTARepository
    {
        public T047_FERRAMENTARepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
