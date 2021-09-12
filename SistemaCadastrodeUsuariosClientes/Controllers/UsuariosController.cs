using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
        public async Task<IActionResult> VisualizarId(string email)
        {
           
            var res = await _service.VisualizarId(email);


            return Json(res);
        }

       

        [HttpPost]
        public async Task<IActionResult> Inserir([Bind("NomeCompleto,Apelido,Email,TelefoneDeContato")] Usuario usuario)
        {

            await _service.Inserir(usuario);

            return Json(new { nome="ok"} );

        }

       

        [HttpPut]
        public async Task<IActionResult> Atualizar([Bind("NomeCompleto,Apelido,Email,TelefoneDeContato")] Usuario usuario)
        {

            await _service.Editar(usuario);

            return Json(new { nome = "ok" });

        }


        [HttpDelete]
        public async Task<IActionResult> Deletar( string email) 
        {
            
            await _service.Deletar(email);

            return Json(new { nome = "ok" });
        }

    }
}
