using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Models
{
    public class Login
    {
        [Key]
        public string Usuario { get; set; }
        public string  Senha { get; set; }
    }
}
