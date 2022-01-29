using System.Collections.Generic;
using System.Security.Claims;

namespace UsuariosTi.Business.Interfaces
{
    public interface IUser
    {
        string Nome { get; }
        string Matricula { get; }
        string UnidadeNome { get; }
        string UnidadeCodigo { get; }
        //bool IsFuncionarioCaixa { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
