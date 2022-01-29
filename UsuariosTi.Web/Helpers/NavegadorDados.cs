using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosTi.Web.Helpers
{
    public class NavegadorDados
    {

        private IHttpContextAccessor _httpContext;
        public NavegadorDados(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public bool ValidarNavegadorFirefox()
        {
            var navegador = _httpContext.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
            return navegador.ToUpper().Contains("FIREFOX");
        }
    }
}
