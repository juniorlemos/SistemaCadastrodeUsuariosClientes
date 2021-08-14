using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastrodeUsuariosClientes.Models
{
    public class Cliente
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        [Key]
        public string Cnpj { get; set; }
        public  string Logradouro{ get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public  string Municipio { get; set; }

        public string CEP  { get; set; }

    }
}
