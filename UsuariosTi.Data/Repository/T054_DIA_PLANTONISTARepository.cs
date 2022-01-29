using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T054_DIA_PLANTONISTARepository : Repository<T054_DIA_PLANTONISTA>, IT054_DIA_PLANTONISTARepository
    {
        public T054_DIA_PLANTONISTARepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
