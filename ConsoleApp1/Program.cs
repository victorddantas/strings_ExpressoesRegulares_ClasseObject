using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           // metodoSubstring();
      
        }

        #region Trabalhando com strings
        private static void metodoSubstring()
        {

            //Método substring - possibilita obtermos um trecho de uma string através do índice, criando uma nova string com o trecho 

            string url = "pagina?argumentos";

            Console.WriteLine(url);

            string url2 = url.Substring(6); //criando uma nova string pois uma string é imutável(obtendo o trecho da string a partir do indice 6 incluindo o próprio indice 6).

            Console.WriteLine(url2);

            url += "teste"; //nesse caso será incluio a palavra teste a primeira url, porém na exibição será criada uma nova string temporária, pois a string original permance imutável. 

            Console.WriteLine(url);

            Console.ReadLine();
        }



        #endregion
    }
}
