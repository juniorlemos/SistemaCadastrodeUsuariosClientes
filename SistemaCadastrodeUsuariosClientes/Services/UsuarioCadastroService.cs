using SistemaCadastrodeUsuariosClientes.Models;
using SistemaCadastrodeUsuariosClientes.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Services
{
    

    public class UsuarioCadastroService : ICadastroService<Usuario>
    {
        private readonly ICadastroRepository<Usuario> _repository;

        public UsuarioCadastroService(ICadastroRepository<Usuario> repository)
        {
            _repository = repository;
                
        }
        
        
        public async Task Deletar(string id)
        {
           await _repository.Deletar(id);

        }

        public async Task Editar(Usuario usuario)
        {
           await _repository.Editar(usuario);
        }

        public  async Task Inserir(Usuario usuario)
        {
          await  _repository.Inserir(usuario);
        }

        public async Task<List<Usuario>> Visualizar( )
        {
             return await _repository.Visualizar();
                  

        }
    }

}
