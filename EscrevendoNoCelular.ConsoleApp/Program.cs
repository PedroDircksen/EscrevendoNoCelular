using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConversorDeCaractere conversor = new ConversorDeCaractere();
            //char a = conversor.dois[0];
            Teclado teclado = new Teclado("SEMPRE ACESSO O DOJOPUZZLES");

            Console.WriteLine(teclado.resultado);
            Console.ReadLine();
        }
    }
}
