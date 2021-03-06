using Microsoft.EntityFrameworkCore;
using SistemaCadastrodeUsuariosClientes.Data;
using SistemaCadastrodeUsuariosClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Repositorys
{
    public class ClienteRepository : ICadastroRepository<Cliente>
    {
        private readonly SistemaContext _context;

        public ClienteRepository(SistemaContext context)
        {
            _context = context;

        }

        public async Task Deletar(string id)
        {
            var entidade = await _context.Cliente.FindAsync(id);
            _context.Remove(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task Editar(Cliente entidade)
        {
            _context.Cliente.Add(entidade);
            _context.Entry(entidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Inserir(Cliente entidade)
        {
            _context.Add(entidade);
            await _context.SaveChangesAsync();

        }

      

        public async Task<List<Cliente>> Visualizar()
        {
            return await _context.Cliente.AsNoTracking().OrderBy(e => e.Cnpj).ToListAsync();
        }

        public async Task<Cliente> VisualizarId(string id)
        {
            return await _context.Cliente.FindAsync(id);
        }
    }
}
