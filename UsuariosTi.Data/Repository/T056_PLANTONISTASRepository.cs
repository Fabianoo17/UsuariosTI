using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T056_PLANTONISTASRepository : Repository<T056_PLANTONISTAS>, IT056_PLANTONISTASRepository
    {
        public T056_PLANTONISTASRepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
