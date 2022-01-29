using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class T055_COORDENACAO_PLANTONISTARepository : Repository<T055_COORDENACAO_PLANTONISTA>, IT055_COORDENACAO_PLANTONISTARepository
    {
        public T055_COORDENACAO_PLANTONISTARepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
