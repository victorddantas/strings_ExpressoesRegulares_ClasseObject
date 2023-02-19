using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class extratorDeUrl
    {
        public string URL { get;} 
        private readonly string _argumentos; // propriedade que irá gravar os argumentos recebidos 

        public extratorDeUrl (string url)
        {


            //método para verificar se o valor é nulo ou vazio 

            if(string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O valor da URL não pode ser vazia nem nula", nameof(url)); //exceção para valores nulos ou vazios

            }
         
            URL = url;

            int indiceInterrogacao = url.IndexOf(" "); //obtendo o indice do caractere 

            //Método substring - possibilita obtermos um trecho de uma string através do índice, criando uma nova string com o trecho
            //string é uma palavra reservada. A classe String também pode ser utlizada como um tipo, porém o mais comum é se utlizar string

            _argumentos = url.Substring(indiceInterrogacao + 1); //obtendo a string a partir do caractere escolhido (sem incluir o caractere) 

          
            
        }

        public string obterValor(string nomeParametro)
        {
            string normalizandoCaracterEDoArgumento = _argumentos.ToUpper(); //covertendo o valor do argumento em caixa alta 

            string parametro = nomeParametro + "="; //obtendo o nome do parametro passado (moedaOrigem ou moedaDestino) + "="
            int indiceParametro = normalizandoCaracterEDoArgumento.IndexOf(parametro); //obtendo o indice do parâmetro passado (no caso seria a letra "m")

            string resultado = _argumentos.Substring(indiceParametro + parametro.Length); //somando o indice do parêmetro com seu tamanho podemos obter o último caractere do parâmetro passado
                                                                                           //com isso aplicando o método Substring podemos obter o termo após o parâmtro passado (que foi somado a "=") 
            
            int indiceInterrogacao = resultado.IndexOf('&'); //obtendo o indice do caractere "&"
            
            if (indiceInterrogacao == -1) //quando tentamos obter um indice que não exixte o complador retrona como padrão o valor "-1". Para não gerar uma excessão no caso de não
                                          //haver o indice informado (&), ou seja o parâmetro infromado é o último da string, faremos essa verificação.
            {
                return resultado;
            }


            return resultado.Remove(indiceInterrogacao); //removendo qualquer termo colocado após o "&"
        }



    }
}
