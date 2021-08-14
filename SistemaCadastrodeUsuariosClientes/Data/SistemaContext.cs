using Microsoft.EntityFrameworkCore;
using SistemaCadastrodeUsuariosClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Data
{
    public class SistemaContext:DbContext
    {
        public SistemaContext(DbContextOptions<SistemaContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Login> Login { get; set; }

    }
    }

