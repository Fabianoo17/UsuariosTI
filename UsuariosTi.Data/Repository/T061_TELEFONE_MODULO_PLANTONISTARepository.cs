using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T061_TELEFONE_MODULO_PLANTONISTARepository : Repository<T061_TELEFONE_MODULO_PLANTONISTA>, IT061_TELEFONE_MODULO_PLANTONISTARepository
    {
        public T061_TELEFONE_MODULO_PLANTONISTARepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
