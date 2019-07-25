using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato.Classes

{
    public partial class Cliente :IDisposable
    {
        public void Gravar() //Exemplo - Quando o programa chega aqui, usamos o objeto this para ter
                            //acesso ao objeto cli, criado na main
        {

        }
                
        //Construtor - Snippet de código para criar construtor = ctor<TAB><TAB>
        //O primeiro construtor não deve ter parâmetro.
        public Cliente()
        {

        }

        public Cliente(int codigo)
        {
            //TODO para criar o procedimento de leitura baseado no prâmetro código
        }

        //A classe Cliente deve herdar da interface IDisposable e implementar o metodo Dispose
        //Significa que o objeto será destruido, irá para o Gabarge collection, lixo, não existirá mais
        //para ocupar memoria.
        public void Dispose() 
        {
            this.Gravar();//Exemplo antes de destruir o objeto, salve os dados
        }

    }
}
