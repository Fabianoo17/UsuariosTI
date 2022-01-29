using Corretora.Business.ViewModels.Home;

namespace Corretora.Business.Interfaces.Services
{
    public interface IHomeService
    {
        IndexViewModel PopularIndexModel(string pesquisa);

    }
}
