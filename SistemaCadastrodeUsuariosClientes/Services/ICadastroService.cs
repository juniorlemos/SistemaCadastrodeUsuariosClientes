using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Services
{
   public interface ICadastroService<TEntity> where TEntity : class
    {
        Task Deletar(string id);
        Task Inserir(TEntity objeto);
        Task<TEntity> Visualizar(string chave);
        Task Editar(TEntity objeto);

    }
}
