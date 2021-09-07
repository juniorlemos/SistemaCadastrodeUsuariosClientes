using Microsoft.AspNetCore.Mvc;
using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ICadastroService<Cliente> _service;

        public ClientesController(ICadastroService<Cliente> service)
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
        public async Task<IActionResult> VisualizarId(string cnpj)
        {

            var res = await _service.VisualizarId(cnpj);


            return Json(res);
        }



        [HttpPost]
        public async Task<IActionResult> Inserir([Bind("RazaoSocial,NomeFantasia,Cnpj,Logradouro,Numero,Bairro,Complemento,Municipio,CEP")] Cliente cliente)
        {

            await _service.Inserir(cliente);

            return Json(new { nome = "ok" });

        }



        [HttpPut]
        public async Task<IActionResult> Atualizar([Bind("RazaoSocial,NomeFantasia,Cnpj,Logradouro,Numero,Bairro,Complemento,Municipio,CEP")] Cliente cliente)
        {

            await _service.Editar(cliente);

            return Json(new { nome = "ok" });

        }


        [HttpDelete]
        public async Task<IActionResult> Deletar(string cnpj)
        {

            await _service.Deletar(cnpj);

            return Json(new { nome = "ok" });
        }

    }
}
