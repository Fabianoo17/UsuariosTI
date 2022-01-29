using UsuariosTi.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsuariosTi.Business.Interfaces
{
    public interface IVW000_USUARIORepository : IRepository<VW000_USUARIOS>
    {
        IEnumerable<VW000_USUARIOS> PesquisarUsuarios(string nomeOuMatricula);
    }
}
