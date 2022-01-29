using Microsoft.AspNetCore.Mvc;
using Corretora.App.Controllers;
using Corretora.Business.Interfaces;
using Corretora.Business.Interfaces.Services;

namespace Corretora.Web.Controllers
{
    public class HomeController : MainController
    {

        private readonly IUser _user;
        private readonly IHomeService _homeService;

        public HomeController(IUser user,
                              IHomeService homeService) : base(user)
        {
            _user = user;
            _homeService = homeService;
        }

        public IActionResult Index(string pesquisa)
        {
            return View();
        }

    }
}