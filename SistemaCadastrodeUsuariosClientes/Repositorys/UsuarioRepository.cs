using Microsoft.EntityFrameworkCore;
using SistemaCadastrodeUsuariosClientes.Data;
using SistemaCadastrodeUsuariosClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Repositorys
{
    public class UsuarioRepository : ICadastroRepository<Usuario>
    {
        private readonly SistemaContext _context;

        public UsuarioRepository(SistemaContext context)
        {
            _context = context;

        }

        public async Task Deletar(string id)
        {

            var entidade = await _context.Usuario.FindAsync(id);
            _context.Remove(entidade);
            await _context.SaveChangesAsync();
        }

            public async Task Editar(Usuario entidade )
        {
            _context.Usuario.Add(entidade);
            _context.Entry( entidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Inserir(Usuario entidade)
        {
                _context.Add(entidade);
               await _context.SaveChangesAsync();
               
        }

        public async Task<List<Usuario>> Visualizar( )
        {
           
            return await _context.Usuario.AsNoTracking().ToListAsync();


        }




    }
}
