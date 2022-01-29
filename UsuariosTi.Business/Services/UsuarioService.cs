using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosTi.Business.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IVW000_USUARIORepository _repositoryVW000_USUARIO;
        private IT003_PERFIL_USUARIORepository _repositoryT003_PERFIL_USUARIO;


        public UsuarioService(IVW000_USUARIORepository repositoryVW000_USUARIO, IT003_PERFIL_USUARIORepository repositoryT003_PERFIL_USUARIO)
        {
            _repositoryVW000_USUARIO = repositoryVW000_USUARIO;
            _repositoryT003_PERFIL_USUARIO = repositoryT003_PERFIL_USUARIO;
        }

        public Task<List<Claim>> ObterClaims(string matricula)
        {
            var claims = new List<Claim>();
            var usuario = ObterUsuarioPorMatricula(matricula);

            var usuarioAcesso = _repositoryT003_PERFIL_USUARIO.GetOne(x => x.T003_MAT_USUARIO == matricula);
            var perfil = 3;

            if (usuarioAcesso != null)
            {
                perfil = Convert.ToInt32(usuarioAcesso.T003_FK_PERFIL);
            }
                

            if (usuario != null)
            {
                claims = new List<Claim> {
                    new Claim("Nome", usuario.Nome),
                    new Claim("Matricula", usuario.Matricula),
                    new Claim("UnidadeNome", usuario.NomeUnidade),
                    new Claim("UnidadeCodigo", usuario.CodigoUnidade),
                    new Claim("Perfis", perfil.ToString())
                };
            }
            return Task.FromResult(claims);
        }
        
        public UsuarioViewModel ObterUsuarioPorMatricula(string matricula)
        {
            var model = _repositoryVW000_USUARIO.GetOne(x => x.MATRICULA == matricula);
            if (model != null)
            {
                return new UsuarioViewModel
                {
                    Nome = model.NOME,
                    Matricula = model.MATRICULA,
                    NomeUnidade = model.SG_UNID_ADM,
                    CodigoUnidade = model.NU_UNID_ADM.ToString()
                };
            }
            return null;
        }
    }
}
