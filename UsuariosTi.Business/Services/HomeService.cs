using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using UsuariosTi.Business.Interfaces.Services;
using UsuariosTi.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using UsuariosTi.Business.ViewModels.Home;
using UsuariosTi.Business.ViewModels.Home.Corrossel;
using UsuariosTi.Business.ViewModels.Home.QuemSomos;
using UsuariosTi.Business.ViewModels.Home.Numeros;
using UsuariosTi.Business.ViewModels.Home.UltimasAcoes;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;
using UsuariosTi.Business.ViewModels.Home.DicasTi;

namespace UsuariosTi.Business.Services
{
    public class HomeService : IHomeService
    {
        private IHostingEnvironment _hostingEnv;
        private readonly IUser _user;
        private readonly IT047_FERRAMENTARepository _t047;
        private readonly IT052_PRESTADORES_SCPRepository _t052;
        private readonly IVW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository _vw001;
        private readonly IVW002_PERCENTUAL_PROJETOS_ANORepository _vw002;
        private readonly IVW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository _vw003;
        private readonly IVW005_RETRATO_TI_SERVICOS_REGIONAISRepository _vw005;
        private readonly IVW008_PRESTADORES_VITECRepository _vw008;
        private readonly IT071_CATALOGO_SERVICORepository _t071;
        private readonly IT072_PRESTADOR_SIGOCRepository _t072;
        private readonly IVW014_LISTA_PRESTADOR_SIGOCRepository _vw014;
        private readonly IT077_UNIDADES_VINCULORepository _t077;
        private readonly IT078_CIAUS_TEXTORepository _t078;
        private readonly IT079_ULTIMAS_ACOESRepository _t079;
        private readonly IT081_COMENTARIOSRepository _t081;
        public readonly IT065_DICAS_TIRepository _t065;
        public readonly IT082_INTERACOES_ULTIMAS_ACOESRepository _t082;

        //Paulo Novo Site
        private readonly IT029_QUEM_SOMOSRepository _t029;
        private readonly IT073_CARROSSELRepository _t073;
        private readonly IT068_ABRANGENCIARepository _t068;
        private readonly IT074_ACESSO_RAPIDO_SITERepository _t074;
        private readonly IT075_QUEM_SOMOSRepository _t075;
        private readonly IT076_NOSSO_TIMERepository _t076;
        private readonly IReportagensTiService _reportagensTiService;



        public HomeService(IUser user, IHostingEnvironment hostingEnv,
                            IT047_FERRAMENTARepository t047,
                            IVW001_RELATORIO_QTD_EMPREGADOS_CN_GIRepository vw001,
                            IVW002_PERCENTUAL_PROJETOS_ANORepository vw002,
                            IVW003_PERCENTUAL_RESULTADO_DESEMPENHO_CETECRepository vw003,
                            IVW005_RETRATO_TI_SERVICOS_REGIONAISRepository vw005,
                            IVW008_PRESTADORES_VITECRepository vw008,
                            IT052_PRESTADORES_SCPRepository t052,
                            IT071_CATALOGO_SERVICORepository t071,
                            IT072_PRESTADOR_SIGOCRepository t072,
                            IVW014_LISTA_PRESTADOR_SIGOCRepository vw014,
                            IT029_QUEM_SOMOSRepository t029,
                            IT065_DICAS_TIRepository t065,
                            IT068_ABRANGENCIARepository t068,
                            IT073_CARROSSELRepository t073,
                            IT074_ACESSO_RAPIDO_SITERepository t074,
                            IT075_QUEM_SOMOSRepository t075,
                            IT076_NOSSO_TIMERepository t076,
                            IReportagensTiService reportagensTiService,
                            IT077_UNIDADES_VINCULORepository t077,
                            IT078_CIAUS_TEXTORepository t078,
                            IT079_ULTIMAS_ACOESRepository t079,
                            IT081_COMENTARIOSRepository t081,
                            IT082_INTERACOES_ULTIMAS_ACOESRepository t082)
        {
            _hostingEnv = hostingEnv;
            _user = user;
            _t047 = t047;
            _vw008 = vw008;
            _vw001 = vw001;
            _vw002 = vw002;
            _vw003 = vw003;
            _vw005 = vw005;
            _t052 = t052;
            _t068 = t068;
            _t065 = t065;
            _t071 = t071;
            _t072 = t072;
            _vw014 = vw014;

            _t073 = t073;
            _t029 = t029;
            _t074 = t074;
            _t075 = t075;
            _t076 = t076;
            _reportagensTiService = reportagensTiService;
            _t077 = t077;
            _t078 = t078;
            _t079 = t079;
            _t081 = t081;
            _t082 = t082;
        }

        public IndexViewModel PopularIndexModel(string pesquisa)
        {
            var model = new IndexViewModel();
            model.ModelCarrossel = PopularCarrosselViewModel();
            model.ModelQuemSomos = PopularQuemSomosViewModel();
            model.ModelNumeros = PopularNumerosModel();
            model.ModelDicasTi = popularDicasTi(pesquisa);
            model.ModelUltimasAcoes = ListarUltimasAcoes(6);
            return model;
        }

        private CarrosselViewModel PopularCarrosselViewModel()
        {
            var modelCarrossel = new CarrosselViewModel();
            modelCarrossel.ListaT073_CARROSSEL = _t073.GetMany(x => x.IC_ATIVO == true);
            return modelCarrossel;
        }

        private QuemSomosViewModel PopularQuemSomosViewModel()
        {
            var model = new QuemSomosViewModel();
            model.ListaQuemSomos = _t075.GetMany(x => true);
            return model;
        }

        private NumerosViewModel PopularNumerosModel()
        {
            var modelNumeros = new NumerosViewModel();
            var list = _t068.GetMany(x => true);
            var maiorComp = list.Max(x => Convert.ToDateTime("01/" + x.T068_COMPETENCIA).ToString("MM/yyyy"));
            list = list.Where(x => x.T068_COMPETENCIA == maiorComp);

            modelNumeros.ListaAbrangencia = list;
            return modelNumeros;
        }


        public List<T076_NOSSO_TIME> ListarNossoTime()
        {

            var lista = _t076.GetMany(x => true).OrderBy(x => x.T076_GERENCIA).ThenBy(x => x.T076_POSICAO_QUADRO).ToList();
            var listatratada = new List<T076_NOSSO_TIME>();

            foreach (var item in lista)
            {
                var itemtratado = new T076_NOSSO_TIME();
                itemtratado.T076_CARGO = item.T076_CARGO;
                itemtratado.T076_MATRICULA = item.T076_MATRICULA;
                itemtratado.T076_NOME = item.T076_NOME;
                itemtratado.T076_TELEFONE = item.T076_TELEFONE;
                itemtratado.T076_CO_DETALHA_NOSSO_TIME = item.T076_CO_DETALHA_NOSSO_TIME;
                itemtratado.T076_FOTO = UsuariosTi.Business.Extensions.Util.GetPhoto(item.T076_MATRICULA);
                itemtratado.T076_GERENCIA = item.T076_GERENCIA;
                itemtratado.T076_POSICAO_QUADRO = item.T076_POSICAO_QUADRO;
                listatratada.Add(itemtratado);
            }

            return listatratada;


        }

        public ViewModelReportagensTi popularDicasTi(string texto)
        {

            return _reportagensTiService.ListarNoticiasDestaque(texto);

        }

        public T077_UNIDADES_VINCULO GetUnidadeVinculo(int cgc)
        {
            return _t077.GetUnidadeVinculo(cgc);
        }

        public T077_UNIDADES_VINCULO GetUnidade(int cgc)
        {
            return _t077.GetUnidade(cgc);
        }

        public T078_CIAUS_TEXTO GetTexto(string filial)
        {
            return _t078.GetOne(x => x.SG_FILIAL == filial);
        }

        public IEnumerable<T047_FERRAMENTA> ListarFerramentas(int id)
        {
            return _t047.GetMany(x => x.T047_CO_CATEGORIA == id);
        }

        public IEnumerable<T079_ULTIMAS_ACOESViewModel> ListarUltimasAcoes(int quantidade)
        {
            IEnumerable<T079_ULTIMAS_ACOES> dados = Enumerable.Empty<T079_ULTIMAS_ACOES>();

            if (quantidade == 0)
            {
                dados = _t079.GetMany(x => true).OrderByDescending(o => o.Data);
            }
            else
            {
                dados = _t079.GetMany(x => true).OrderByDescending(o => o.Data).Take(quantidade);
            }

            List<T079_ULTIMAS_ACOESViewModel> list = new List<T079_ULTIMAS_ACOESViewModel>();

            foreach (var item in dados)
            {
                var coment = ListarComentarios(item.ID);

                var novo = new T079_ULTIMAS_ACOESViewModel();
                novo.ID = item.ID;
                novo.Titulo = item.Titulo;
                novo.Data = item.Data;
                novo.Caminho = item.Caminho;
                novo.Video = item.Video;
                novo.Resumo = item.Resumo;
                novo.Texto = item.Texto;
                novo.Positivo = item.Positivo;
                novo.Negativo = item.Negativo;
                novo.Visualizacao = item.Visualizacao;
                novo.QuantComentario = coment.Count();
                novo.No_Imagem = item.No_Imagem;
                novo.Matricula = item.Matricula;
                novo.Nome = item.Nome;

                list.Add(novo);
            }

            return list;
        }

        public int? ContadorLike(int id)
        {
            var bLike = VerificaLike(id);

            var dados = _t079.GetOne(x => x.ID == id);

            if (bLike)
            {
                dados.Positivo = dados.Positivo - 1;
            }
            else
            {
                dados.Positivo = dados.Positivo + 1;
            }

            _t079.Update(dados);

            return dados.Positivo;
        }

        private bool VerificaLike(int id)
        {
            bool like = false;

            var dados = _t082.GetOne(x => x.T079_ID == id && x.Matricula == _user.Matricula);
            if (dados == null)
            {
                like = false;

                T082_INTERACOES_ULTIMAS_ACOES iDados = new T082_INTERACOES_ULTIMAS_ACOES();
                iDados.T079_ID = id;
                iDados.Matricula = _user.Matricula;
                iDados.Positivo = true;
                iDados.Negativo = false;
                iDados.Visualizacao = false;
                _t082.Insert(iDados);

            }
            else
            {
                if (dados.Positivo == true)
                {
                    like = true;

                    dados.Positivo = false;
                    _t082.Update(dados);

                }
                else
                {
                    like = false;

                    dados.Positivo = true;
                    _t082.Update(dados);

                }
            }

            return like;
        }

        public int? ContadorDeslike(int id)
        {
            var bDeslike = VerificaDeslike(id);

            var dados = _t079.GetOne(x => x.ID == id);

            if (bDeslike)
            {
                dados.Negativo = dados.Negativo - 1;
            }
            else
            {
                dados.Negativo = dados.Negativo + 1;
            }

            _t079.Update(dados);

            return dados.Negativo;
        }

        private bool VerificaDeslike(int id)
        {
            bool deslike = false;

            var dados = _t082.GetOne(x => x.T079_ID == id && x.Matricula == _user.Matricula);
            if (dados == null)
            {
                deslike = false;

                T082_INTERACOES_ULTIMAS_ACOES iDados = new T082_INTERACOES_ULTIMAS_ACOES();
                iDados.T079_ID = id;
                iDados.Matricula = _user.Matricula;
                iDados.Positivo = false;
                iDados.Negativo = true;
                iDados.Visualizacao = false;
                _t082.Insert(iDados);

            }
            else
            {
                if (dados.Negativo == true)
                {
                    deslike = true;

                    dados.Negativo = false;
                    _t082.Update(dados);

                }
                else
                {
                    deslike = false;

                    dados.Negativo = true;
                    _t082.Update(dados);

                }
            }

            return deslike;
        }

        public T079_ULTIMAS_ACOES ContadorVisualizar(int id)
        {
            var bVisualizacao = VerificaVisualizacao(id);

            var dados = _t079.GetOne(x => x.ID == id);
            if (bVisualizacao == false)
            {
                dados.Visualizacao = dados.Visualizacao + 1;
            }

            _t079.Update(dados);

            return dados;
        }

        private bool? VerificaVisualizacao(int id)
        {
            bool? visualizacao = true;

            var dados = _t082.GetOne(x => x.T079_ID == id && x.Matricula == _user.Matricula);
            if (dados == null)
            {
                visualizacao = false;

                T082_INTERACOES_ULTIMAS_ACOES iDados = new T082_INTERACOES_ULTIMAS_ACOES();
                iDados.T079_ID = id;
                iDados.Matricula = _user.Matricula;
                iDados.Positivo = false;
                iDados.Negativo = false;
                iDados.Visualizacao = true;
                _t082.Insert(iDados);

            }
            else
            {
                visualizacao = dados.Visualizacao;

                if (dados.Visualizacao == false)
                {
                    dados.Visualizacao = true;
                    _t082.Update(dados);

                }
            }

            return visualizacao;
        }

        public IEnumerable<T081_COMENTARIOS> ListarComentarios(int id)
        {
            return _t081.GetMany(x => x.ID_Tipo_Indice == 2 && x.ID_Dica_Acoes == id).OrderByDescending(o => o.ID);
        }


        public IEnumerable<T081_COMENTARIOS> ListarComentariosPorTipo(int id, int tipo)
        {
            return _t081.GetMany(x => x.ID_Tipo_Indice == tipo && x.ID_Dica_Acoes == id).OrderByDescending(o => o.ID);
        }

        public void SalvarComentario(T081_COMENTARIOS model)
        {
            _t081.Insert(model);
        }

        public void SalvarComentarioDicaTi(T081_COMENTARIOS model)
        {
            _t081.Insert(model);
        }
        public IEnumerable<VW005_RETRATO_TI_SERVICOS_REGIONAIS> RelatorioUsuariosTi()
        {
            var list = _vw005.GetMany(x => x.ORDENACAO_DATA >= DateTime.Now.AddDays(-90));
            return list;
        }

        public IEnumerable<VW005_RETRATO_TI_SERVICOS_REGIONAIS> RelatorioUsuariosTiExcel()
        {
            var list = _vw005.GetMany(x => x.ANO == "2021");
            return list;
        }
        public string DataAtualizacao()
        {
            var item = _vw005.GetMany(x => true).OrderByDescending(x => x.ID).Select(x => x.DATA_ATUALIZACAO).FirstOrDefault();
            return item;
        }

        public async void SalvarUltimasAcoes(T079_ULTIMAS_ACOESViewModel Model)
        {

            if (Model.File != null)
            {
                //Salvar o anexo
                var fileName = Path.GetFileName(Model.File.FileName);
                //var fileExtension = Path.GetExtension(fileName);
                //var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                var _filename = ContentDispositionHeaderValue.Parse(Model.File.ContentDisposition).FileName.Trim('"');
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload", Model.File.FileName);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                   await Model.File.CopyToAsync(stream);
                }

                var objfiles = new T079_ULTIMAS_ACOES()
                {
                    Titulo = Model.Titulo,
                    Data = DateTime.Now,
                    Caminho = "../upload/" + fileName,
                    Video = Model.Video,
                    Resumo = Model.Resumo,
                    Texto = Model.Texto,
                    Positivo = 0,
                    Negativo = 0,
                    Visualizacao = 0,
                    No_Imagem = fileName,
                    Matricula = _user.Matricula,
                    Nome = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(_user.Nome.ToLower())
            };

                _t079.Insert(objfiles);
            }
        }

        public async void UpdateUltimasAcoes(T079_ULTIMAS_ACOESViewModel Model)
        {
            var fileName = "";

            if (Model.File != null)
            {
                //Salvar o anexo
                fileName = Path.GetFileName(Model.File.FileName);
                //var fileExtension = Path.GetExtension(fileName);
                //var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                var _filename = ContentDispositionHeaderValue.Parse(Model.File.ContentDisposition).FileName.Trim('"');
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload", Model.File.FileName);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                   await Model.File.CopyToAsync(stream);
                }
            }
            else
            {
                fileName = Model.Caminho;
            }


            var objfiles = new T079_ULTIMAS_ACOES()
            {
                ID = Model.ID,
                Titulo = Model.Titulo,
                Data = DateTime.Now,
                Caminho = "../upload/" + fileName,
                Video = Model.Video,
                Resumo = Model.Resumo,
                Texto = Model.Texto,
                Positivo = Model.Positivo,
                Negativo = Model.Negativo,
                Visualizacao = Model.Visualizacao,
                No_Imagem = Model.No_Imagem,
                Matricula = _user.Matricula,
                Nome = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(_user.Nome.ToLower())
        };

            _t079.Update(objfiles);

        }

        public T079_ULTIMAS_ACOES EditarUltimasAcoes(int id)
        {
            return _t079.GetOne(x => x.ID == id);
        }

        public void DeleteUltimasAcoes(int id)
        {
            _t079.Remove(id);
        }

        public IEnumerable<T065_DICAS_TI> ListarDicasTI()
        {
            return _t065.GetMany(x => true).OrderByDescending(o => o.T065_DT_CADASTRO);
        }

        public void SalvarDicasTI(T065_DICAS_TIViewModel Model)
        {
            if (Model.File != null)
            {
                //Salvar a imagem
                var fileName = Path.GetFileName(Model.File.FileName);
                var fileExtension = Path.GetExtension(fileName);

                //Salvar o anexo
                var fileNameAnexo = "";
                if (Model.FileAnexo != null)
                {
                    fileNameAnexo = Path.GetFileName(Model.FileAnexo.FileName);
                    var fileExtensionAnexo = Path.GetExtension(fileNameAnexo);
                }

                var objfiles = new T065_DICAS_TI()
                {
                    T065_TITULO = Model.T065_TITULO,
                    T065_TEXTO = Model.T065_TEXTO,
                    T065_BREVE_DESCRICAO = "",
                    T065_DT_CADASTRO = DateTime.Now,
                    T065_USER_CADASTRO = "",
                    T065_FLAG_ATIVO = true,
                    T065_POSITIVO = 0,
                    T065_NEGATIVO = 0,
                    T065_VISUALIZACAO = 0,
                    T065_NO_IMAGEM = fileName,
                    T065_MATRICULA = _user.Matricula,
                    T065_NOME = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(_user.Nome.ToLower()),                    
                T065_NO_ANEXO = fileNameAnexo
                };

                using (var target = new MemoryStream())
                {
                    Model.File.CopyTo(target);                    
                    objfiles.T065_IMAG = target.ToArray();
                }

                if (Model.FileAnexo != null)
                {
                    using (var targetAnexo = new MemoryStream())
                    {
                        Model.FileAnexo.CopyTo(targetAnexo);
                        objfiles.T065_ANEXO = targetAnexo.ToArray();
                    }
                }

                _t065.Insert(objfiles);
            }
        }

        public void UpdateDicasTI(T065_DICAS_TIViewModel Model)
        {

            var edit = _t065.GetOne(x => x.T065_ID == Model.T065_ID);
            edit.T065_ID = Model.T065_ID;
            edit.T065_TITULO = Model.T065_TITULO;
            edit.T065_DT_CADASTRO = DateTime.Now;
            edit.T065_TEXTO = Model.T065_TEXTO;
            edit.T065_MATRICULA = _user.Matricula;
            edit.T065_NOME = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(_user.Nome.ToLower());

            if (Model.File != null)
            {
                //Salvar a imagem
                var fileName = Path.GetFileName(Model.File.FileName);
                var fileExtension = Path.GetExtension(fileName);

                using (var target = new MemoryStream())
                {
                    Model.File.CopyTo(target);
                    edit.T065_IMAG = target.ToArray();
                    edit.T065_NO_IMAGEM = fileName;
                }
            }
            
            if (Model.FileAnexo != null)
            {
                //Salvar o anexo
                var fileNameAnexo = Path.GetFileName(Model.FileAnexo.FileName);
                var fileExtension = Path.GetExtension(fileNameAnexo);

                using (var targetAnexo = new MemoryStream())
                {
                    Model.FileAnexo.CopyTo(targetAnexo);
                    edit.T065_ANEXO = targetAnexo.ToArray();
                    edit.T065_NO_ANEXO = fileNameAnexo;
                }
            }

            _t065.Update(edit);

        }

        public void DeleteDicasTI(int id)
        {
            _t065.Remove(id);
        }

        public T065_DICAS_TI EditarDicasTI(int id)
        {
            return _t065.GetOne(x => x.T065_ID == id);
        }

        public IEnumerable<T073_CARROSSEL> ListarCarousel()
        {
            return _t073.GetMany(x => true).OrderBy(o => o.NU_ORDENACAO);
        }

        public void SalvarCarousel(CarrosselViewModel Model)
        {
            if (Model.File != null)
            {
                //Salvar o anexo
                var fileName = Path.GetFileName(Model.File.FileName);
                var fileExtension = Path.GetExtension(fileName);

                var objfiles = new T073_CARROSSEL()
                {
                    NO_IMAGEM = fileName,
                    NU_ORDENACAO = Model.NU_ORDENACAO,
                    IC_ATIVO = Model.IC_ATIVO,
                    TEXTO = Model.TEXTO,
                    BOTAO = Model.BOTAO,
                    TEXTO_BOTAO = Model.TEXTO_BOTAO,
                    TIPO_BOTAO = Model.TIPO_BOTAO,
                    LINK = Model.LINK,
                    Matricula = _user.Matricula,
                    Nome = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(_user.Nome.ToLower())
            };

                using (var target = new MemoryStream())
                {
                    Model.File.CopyTo(target);
                    objfiles.IMAGEM = target.ToArray();
                }

                _t073.Insert(objfiles);
            }
        }

        public void UpdateCarousel(CarrosselViewModel Model)
        {

            var edit = _t073.GetOne(x => x.NU_CARROSSEL == Model.NU_CARROSSEL);
            edit.NU_CARROSSEL = Model.NU_CARROSSEL;
            edit.NU_ORDENACAO = Model.NU_ORDENACAO;
            edit.IC_ATIVO = Model.IC_ATIVO;
            edit.TEXTO = Model.TEXTO;
            edit.BOTAO = Model.BOTAO;
            edit.TEXTO_BOTAO = Model.TEXTO_BOTAO;
            edit.TIPO_BOTAO = Model.TIPO_BOTAO;
            edit.LINK = Model.LINK;
            edit.Matricula = _user.Matricula;
            edit.Nome = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(_user.Nome.ToLower());

            if (Model.File != null)
            {
                //Salvar o anexo
                var fileName = Path.GetFileName(Model.File.FileName);
                var fileExtension = Path.GetExtension(fileName);

                using (var target = new MemoryStream())
                {
                    Model.File.CopyTo(target);
                    edit.IMAGEM = target.ToArray();
                    edit.NO_IMAGEM = fileName;
                }

            }

            _t073.Update(edit);
        }

        public void DeleteCarousel(int id)
        {
            _t073.Remove(id);
        }

        public T073_CARROSSEL EditarCarousel(int id)
        {
            return _t073.GetOne(x => x.NU_CARROSSEL == id);
        }
    }
}
