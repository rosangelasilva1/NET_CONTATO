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
            contato.Tipo = "Telefone";

            cli.contato = contato;

            Console.WriteLine(cli.contato.DadosContato);
            Console.WriteLine(cli.contato.Tipo);
            Console.ReadLine();
        }
    }
}
