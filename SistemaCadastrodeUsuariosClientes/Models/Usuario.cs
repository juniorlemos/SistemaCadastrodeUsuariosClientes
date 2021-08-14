using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Models
{
    public class Usuario
    {
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }
        [Key]
        public string Email { get; set; }
        public int TelefoneDeContato { get; set; }
    }
}
