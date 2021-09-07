using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Services
{
    public class ClienteCadastroService :ICadastroService<Cliente>
    {
        private readonly ICadastroRepository<Cliente> _repository;

        public ClienteCadastroService(ICadastroRepository<Cliente> repository)
        {
            _repository = repository;

        }


        public async Task Deletar(string id)
        {
            await _repository.Deletar(id);

        }

        public async Task Editar(Cliente cliente)
        {
            await _repository.Editar(cliente);
        }

        public async Task Inserir(Cliente cliente)
        {
            await _repository.Inserir(cliente);
        }

      

        public async Task<List<Cliente>> Visualizar()
        {
            return await _repository.Visualizar();
        }

        public async Task<Cliente> VisualizarId(string id)
        {
            return await _repository.VisualizarId(id);
        }
    }

}
