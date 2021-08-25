using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Repositorys
{
    public interface ICadastroRepository<TEntity> where TEntity : class
    {
        Task Deletar(string id);
        Task Inserir(TEntity entidade);
        Task Editar(TEntity entidade);
        Task<TEntity> Visualizar(string chave);
        
    }
}
