using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;

namespace UsuariosTi.Business.Services
{
    public class CatalogoService : ICatalogoService
    {
        private readonly IT071_CATALOGO_SERVICORepository _t071;

        public CatalogoService(IT071_CATALOGO_SERVICORepository t071)
        {
            _t071 = t071;
        }

        public IEnumerable<T071_CATALOGO_SERVICO> BuscarCatalogo(string catalogo)
        {
            var lista = _t071.GetMany(x => true);

            return lista;
        }
    }
}

