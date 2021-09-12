using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaCadastrodeUsuariosClientes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
      
    

        public IActionResult Index()
        {
    

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                ViewBag.usuario = HttpContext.User.Identity.Name;

            }
          
            return View();
        }

      
    }
}
