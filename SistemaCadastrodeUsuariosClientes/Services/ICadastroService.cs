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
        Task<List<TEntity>> Visualizar();
        Task Editar(TEntity objeto);

        Task<TEntity> VisualizarId(string id);
    }
}
