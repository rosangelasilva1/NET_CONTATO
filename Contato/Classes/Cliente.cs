using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Classes
{
    public partial class Cliente
    {

        //public  int Codigo { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public DateTime DataCadastro { get; set; }

        //Cria uma lista de contatos
        public List<Contato> contatos { get; set; }

        //Para criar uma propriedade com métodos get e set para serem acessados através de variáveis privadas
        //Você pode criar através do snippet propful <TAB> <TAB>
        //É muito utilizada para fazer valodações. Exemplo:
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }

            set {

                    if (_codigo < 0 )
                    {
                    _codigo = 0; 
                    }
                    _codigo = value;
                }
        }




    }   
}
