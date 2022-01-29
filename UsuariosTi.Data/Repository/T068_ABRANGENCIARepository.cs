using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T068_ABRANGENCIARepository : Repository<T068_ABRANGENCIA>, IT068_ABRANGENCIARepository
    {
        public T068_ABRANGENCIARepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
