using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T057_ESCALA_PLANTONISTARepository : Repository<T057_ESCALA_PLANTONISTA>, IT057_ESCALA_PLANTONISTARepository
    {
        public T057_ESCALA_PLANTONISTARepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
