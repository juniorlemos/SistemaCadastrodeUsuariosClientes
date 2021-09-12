using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SistemaCadastrodeUsuariosClientes.Services
{
    public class LoginService :ILoginService<Login>
    {
        private readonly ILoginRepository<Login> _repository;

        public LoginService(ILoginRepository<Login> repository)
        {
            _repository = repository;

        }

      

        public async Task<Login> ObterLoginUsuario(string id)
        {
            return await _repository.ObterLoginUsuario(id);
        }
    }
}
