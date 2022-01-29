using Microsoft.AspNetCore.Hosting;
using System;
using Corretora.Business.Interfaces;
using Corretora.Business.Interfaces.Services;
using Corretora.Business.ViewModels.Home;

namespace Corretora.Business.Services
{
    public class HomeService : IHomeService
    {
        private IHostingEnvironment _hostingEnv;
        private readonly IUser _user;




        public HomeService(IUser user, IHostingEnvironment hostingEnv
        )
        {
            _hostingEnv = hostingEnv;
            _user = user;



        }

        public IndexViewModel PopularIndexModel(string pesquisa)
        {
            throw new NotImplementedException();
        }
    }
}