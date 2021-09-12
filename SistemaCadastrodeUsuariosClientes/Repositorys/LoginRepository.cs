using SistemaCadastrodeUsuariosClientes.Data;
using SistemaCadastrodeUsuariosClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Repositorys
{
    public class LoginRepository : ILoginRepository<Login>
    {
        private readonly SistemaContext _context;

        public LoginRepository(SistemaContext context)
        {
            _context = context;

        }
        public async Task<Login> ObterLoginUsuario(string id)
        {
            return await _context.Login.FindAsync(id);
        }
    }
}
