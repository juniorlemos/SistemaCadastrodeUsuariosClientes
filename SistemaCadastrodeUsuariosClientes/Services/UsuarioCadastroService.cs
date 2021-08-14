﻿using SistemaCadastrodeUsuariosClientes.Models;
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
        
        
        public async Task Deletar(Usuario usuario)
        {
           await _repository.Deletar(usuario);

        }

        public async Task Editar(Usuario usuario)
        {
           await _repository.Editar(usuario);
        }

        public  async Task Inserir(Usuario usuario)
        {
          await  _repository.Inserir(usuario);
        }

        public async Task<Usuario> Visualizar(string chave)
        {
            var usuario =await _repository.Visualizar(chave);
            
            return usuario;

        }
    }

}
