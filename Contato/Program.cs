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

            //Exemplo de criação de objeto cli2 chamando o construtor codigo
            Classes.Cliente cli2 = new Classes.Cliente(5);

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

            cli.Gravar();//Exemplo de Chamada na classe parcial 

            //Exemplo 1 foreach - Iteração com o objeto cli.contatos 
            foreach (Classes.Contato cont in cli.contatos)
            {
                Console.WriteLine(cont.Codigo);
                Console.WriteLine(cont.DadosContato);
                Console.WriteLine(cont.Tipo);
            }
            //Exemplo 2 foreach -  Busca todos os dados de todos os contatos
            cli.contatos.ForEach(cont => Console.WriteLine(cont.DadosContato));

            //Exemplo 3 foreach - Percorre todo o objeto e "grava" cada registro
            cli.contatos.ForEach(cont => cli.Gravar());


            Console.WriteLine(cli.contatos.FirstOrDefault(x => x.Tipo == "Telefone-fixo"));

            Console.ReadLine();
        }
    }
}
