using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classes de Metodos de extensão aplicam-se a tipos, não a classes e devem ser declarados fora do namespace
// para ser acessado de qualquer lugar.São declaradas como static e não precisam ser instanciadas.
public static class MetodoExtensao
{

    public static string PrimeiraMaiuscula(this string valor)
    {
       return valor.Substring(0, 1).ToUpper() + valor.Substring(1, valor.Length -1).ToLower();
    }

    public static string PrimeiraMaiuscula(this string valor, bool restoMinusculo)
    {
        if (restoMinusculo)
            return valor.Substring(0, 1).ToUpper() + valor.Substring(1, valor.Length - 1).ToLower();
        else
            return valor.Substring(0, 1).ToUpper() + valor.Substring(1, valor.Length - 1);
    }

}

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

        //A classe Cliente deve herdar da interface IDisposable e implementar o método Dispose
        //Significa que o objeto será destruído, irá para o Gabarge collector,lixo e não existirá mais
        //para ocupar memória.
        public void Dispose() 
        {
            this.Gravar();//Exemplo antes de destruir o objeto, salve os dados
        }

    }
}
