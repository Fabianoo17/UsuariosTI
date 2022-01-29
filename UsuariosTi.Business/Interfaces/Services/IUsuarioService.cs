using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Corretora.Business.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<List<Claim>> ObterClaims(string matricula);
    }
}
