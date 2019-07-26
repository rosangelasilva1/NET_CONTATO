using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleContato.Classes
{
    public partial class Cliente
    {

        //public  int Codigo { get; set; }
        //public string Nome { get; set; }
        //public int Tipo { get; set; }
        //public DateTime DataCadastro { get; set; }

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

                    if (value < 0 )
                        throw new ConsoleContato.Excecoes.ValidacaoException("O código deve ser maior  que zero");
                    _codigo = value;
                }
        }


        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set {

                if (value.Length <= 3)
                    throw new ConsoleContato.Excecoes.ValidacaoException("O nome deve ter mais que 3 caracteres");
                _nome = value;

            }
        }

        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }


        private DateTime _dataCadastro;

        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

    }   
}
