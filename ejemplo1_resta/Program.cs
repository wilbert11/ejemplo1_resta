using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1_resta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el primer número");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero1 - numero2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
    }
}
