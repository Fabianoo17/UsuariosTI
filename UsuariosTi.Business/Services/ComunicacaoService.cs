using Microsoft.AspNetCore.Http;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using System.Collections.Generic;
using System.IO;
using UsuariosTi.Business.ViewModels;
using System;

namespace UsuariosTi.Business.Services
{
    public class ComunicacaoService : IComunicacaoService
    {
        private readonly IT039_DESTAQUERepository _t039;
        //private readonly IUser _user;

        public ComunicacaoService(IT039_DESTAQUERepository t039)
        {
            _t039 = t039;
        }

        public IEnumerable<T039_DESTAQUE> CarregaDestaques()
        {
            return _t039.GetMany(x => true);
        }

        public void CadastraDestaques(T039_DESTAQUE destaque)
        {
            var ms = new MemoryStream();

            var nome = destaque.anexo.FileName.ToString();
            using (FileStream file = new FileStream(@"\\Cctdcdadnt0002\informe_usuariosti\"+ nome, FileMode.Create, FileAccess.ReadWrite))
                destaque.anexo.CopyTo(file);

            destaque.anexo.CopyTo(ms);
            var waySave = ms.ToArray(); 

            destaque.T039_NOME_IMAGEM = nome;
            destaque.T039_IMAGEM = waySave;

            _t039.Insert(destaque);
        }

        public void DeletarDestaques(int id)
        {
            _t039.Remove(id);
        }

        public T039_DESTAQUE DetalhaCarregaDestaques(int idDestaque)
        {
            return _t039.GetOne(x => x.T039_DESTAQUE_ID == idDestaque);
        }

        public ViewModelT039_DESTAQUE BuscarDestaquePorId(int idDestaque)
        {
            var t039_destaque = _t039.GetOne(x => x.T039_DESTAQUE_ID == idDestaque);

            ViewModelT039_DESTAQUE model = new ViewModelT039_DESTAQUE()
            {
                T039_DESTAQUE_ID = t039_destaque.T039_DESTAQUE_ID,
                T039_TITULO = t039_destaque.T039_TITULO,
                T039_LINK = t039_destaque.T039_LINK,
                T039_NOME_IMAGEM = t039_destaque.T039_NOME_IMAGEM,
                T039_DESCRICAO = t039_destaque.T039_DESCRICAO,
                T039_DT_INICIO = t039_destaque.T039_DT_INICIO,
                T039_DT_FIM = t039_destaque.T039_DT_FIM,
                T039_IMAGEM = t039_destaque.T039_IMAGEM
            };

            return model;
        }

        public void AlterarDestaque(ViewModelT039_DESTAQUE viewModel)
        {
            var destaque = _t039.GetOne(x => x.T039_DESTAQUE_ID == viewModel.T039_DESTAQUE_ID);
            T039_DESTAQUE model = new T039_DESTAQUE();
            destaque.T039_TITULO = viewModel.T039_TITULO;
            destaque.T039_LINK = viewModel.T039_LINK;
            destaque.T039_DESCRICAO = viewModel.T039_DESCRICAO;
            destaque.T039_DT_INICIO = viewModel.T039_DT_INICIO;
            destaque.T039_DT_FIM = viewModel.T039_DT_FIM;

            if (viewModel.anexo != null)
            {
                var ms = new MemoryStream();
               
                var nome = destaque.anexo.FileName.ToString();
                using (FileStream file = new FileStream(@"\\Cctdcdadnt0002\informe_usuariosti\" + nome, FileMode.Create, FileAccess.ReadWrite))
                    destaque.anexo.CopyTo(file);
               
                destaque.anexo.CopyTo(ms);
                var waySave = ms.ToArray();

                destaque.T039_NOME_IMAGEM = nome;
                destaque.T039_IMAGEM = waySave;
            }

            _t039.Update(destaque);
        }
    }
}
