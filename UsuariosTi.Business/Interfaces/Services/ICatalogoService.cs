using System;
using System.Collections.Generic;
using System.Text;
using UsuariosTi.Business.Entities;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface ICatalogoService
    {
        IEnumerable<T071_CATALOGO_SERVICO> BuscarCatalogo(string catalogo);
    }
}



