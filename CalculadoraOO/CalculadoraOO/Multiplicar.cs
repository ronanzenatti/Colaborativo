using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO
{
    class Multiplicar
    {
        public Multiplicar()
        {
            Console.WriteLine("Objeto Multiplicar criado.");
        }

        public Multiplicar(int num1, int num2)
        {
            int total = num1 * num2;
            Console.WriteLine("Resultado da Mult: " + total);
        }

        public void MultEterno()
        { 

            
        }
    }
}
