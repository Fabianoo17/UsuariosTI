using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Data.Context;
using UsuariosTi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Data.Repository
{
    public class VW011_LISTA_COORDENACAO_PLANTONISTARepository : Repository<VW011_LISTA_COORDENACAO_PLANTONISTA>, IVW011_LISTA_COORDENACAO_PLANTONISTASRepository
    {
        public VW011_LISTA_COORDENACAO_PLANTONISTARepository(ServicoRegionaisContext context) : base(context)
        {

        }
    }
}
