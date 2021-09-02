using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public async Task<IActionResult> Visualizar()
        {

            var res = await _service.Visualizar();

            

            return Json(res);
        }



        [HttpGet]
        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Inserir([Bind("NomeCompleto,Apelido,Email,TelefoneDeContato")] Usuario usuario)
        {

            await _service.Inserir(usuario);

            return Json(new { nome="deuCerto"} );

        }


        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([Bind("NomeCompleto,Apelido,Email,TelefoneDeContato")] Usuario usuario)
        {

            await _service.Editar(usuario);

            return RedirectToAction(nameof(Inserir));

        }



        [HttpGet]
        public IActionResult Deletar()
        {
            return View();
        }


        [HttpDelete]
        public async Task<IActionResult> Deletar( string email) 
        {
            var teste = email;
            await _service.Deletar(teste);

            return Json(new { nome = "deuCerto" });
        }

    }
}
