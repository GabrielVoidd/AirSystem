using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem
{
    public class Usuario
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public DateTime nascimento { get; set; }
        public int numero { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string confirmarSenha { get; set; }
    }
}
