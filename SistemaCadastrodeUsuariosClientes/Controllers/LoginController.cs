using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Controllers
{
    
    public class LoginController : Controller
    {


        private readonly ILoginService<Login> _service;
        public LoginController(ILoginService<Login> service)
        {
            _service = service;
        }



        [HttpPost]
        public async Task<IActionResult> Login([Bind("Usuario,Senha")]Login dados)
        {
            var login = await _service.ObterLoginUsuario(dados.Usuario);
           


            if (login == null) {
                return Json(new { success = false });
            }

            if (login.Usuario == dados.Usuario && login.Senha==dados.Senha) {
                var userClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,login.Usuario),
                
            };
                var minhaIdentity = new ClaimsIdentity(userClaims, "Usuario");
                var userPrincipal = new ClaimsPrincipal(new[] { minhaIdentity });

               await HttpContext.SignInAsync(userPrincipal);
                
               
                return Json(new { success = true });

            }

             return Json(new { success = false });
        }


        public IActionResult Login()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            
            return Json(new { success = true });
        }
    }

}

