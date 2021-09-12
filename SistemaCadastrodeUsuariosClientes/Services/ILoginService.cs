using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Services
{
    public interface ILoginService<TEntity> where TEntity : class
    {
        Task<TEntity> ObterLoginUsuario(string id);
      
    }
}
