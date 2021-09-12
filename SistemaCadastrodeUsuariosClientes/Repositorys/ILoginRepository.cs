using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Repositorys
{
    public interface ILoginRepository <TEntity> where TEntity : class
    {
        Task<TEntity> ObterLoginUsuario(string id);
    }
}
