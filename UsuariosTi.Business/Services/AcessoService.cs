using Microsoft.AspNetCore.Http;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using System.Collections.Generic;
using System.IO;

namespace UsuariosTi.Business.Services
{
    public class AcessoService : IAcessoService
    {
        private readonly IT002_PERFILRepository _t002;
        private readonly IT003_PERFIL_USUARIORepository _t003;
        private readonly IT039_DESTAQUERepository _t039;
        private readonly IVW000_USUARIORepository _vw000;
        private readonly IVW004_LISTA_USUARIO_ACESSORepository _vw004;

        public AcessoService(IT002_PERFILRepository t002,
            IT003_PERFIL_USUARIORepository t003,
            IT039_DESTAQUERepository t039,
            IVW000_USUARIORepository vw000,
            IVW004_LISTA_USUARIO_ACESSORepository vw004)
        {
            _t002 = t002;
            _t003 = t003;
            _t039 = t039;

            _vw000 = vw000;
            _vw004 = vw004;
        }

        public IEnumerable<T002_PERFIL> ListaPerfis()
        {
            return _t002.GetMany(x => true);
        }

        public VW000_USUARIOS BuscaUsuario(string matricula)
        {
            var item = _vw000.GetOne(x => x.MATRICULA == matricula);
            return item;
        }

        public IEnumerable<VW004_LISTA_USUARIO_ACESSO> ListaUsuariosComAcesso()
        {
            return _vw004.GetMany(x => true);
       
        }

        public void CadastraPerfil(string matricula, int idPerfil)
        {
            T003_PERFIL_USUARIO perfilUsuario = new T003_PERFIL_USUARIO()
            {
                T003_MAT_USUARIO = matricula,
                T003_FK_PERFIL = idPerfil,
                T003_ATIVO = true
            };

            _t003.Insert(perfilUsuario);
        }

        public void DeletarPerfil(int id)
        {
            _t003.Remove(id);
        }
    }
}
