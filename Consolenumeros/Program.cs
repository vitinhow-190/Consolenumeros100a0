using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolenumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int cont = 100;

            while (cont >= 0)
            {
                Console.WriteLine(cont);

                cont--;// adiciona mais 1 automaticamente
            }

            Console.ReadKey();

        }
    }
}
