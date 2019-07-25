using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Classes
{
    public class Cliente
    {

        public  int Codigo { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public DateTime DataCadastro { get; set; }
        public Contato contato { get; set; }


    }
}
