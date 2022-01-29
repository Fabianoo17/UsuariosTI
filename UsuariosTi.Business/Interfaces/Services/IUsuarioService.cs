using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UsuariosTi.Business.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<List<Claim>> ObterClaims(string matricula);
    }
}
