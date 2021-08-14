using Microsoft.AspNetCore.Mvc;
using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ICadastroService<Usuario> _service;

        public UsuariosController(ICadastroService<Usuario> service)
        {
            _service = service;     
        }

        public IActionResult Index()
        {
            return View();
        }


       [HttpGet]
        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Inserir([Bind("NomeCompleto,Apelido,Email,TelefoneDeContato")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                
                await _service.Inserir(usuario);
           
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }




    }
}
