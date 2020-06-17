using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }
        public bool IsAdmin { get; set; }
    }
}
