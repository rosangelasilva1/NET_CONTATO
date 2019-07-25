using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato
{
    class Program
    {
        static void Main(string[] args)
        {

            Classes.Cliente cli  = new Classes.Cliente();
            cli.Codigo = Convert.ToInt32("3");
            cli.Nome = "João";
            cli.DataCadastro = new DateTime(2019, 07, 24);

            Classes.Contato contato = new Classes.Contato();
            contato.Codigo = 1;
            contato.DadosContato = "6666-6666";
            contato.Tipo = "Telefone-fixo";

            Classes.Contato contato2 = new Classes.Contato();
            contato2.Codigo = 2;
            contato2.DadosContato = "77777-77777";
            contato2.Tipo = "Celular";

            cli.contatos = new List<Classes.Contato>();
            cli.contatos.Add(contato);
            cli.contatos.Add(contato2);

            Console.ReadLine();
        }
    }
}
