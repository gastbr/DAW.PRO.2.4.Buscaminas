using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.PRO._2._4.Buscaminas
{
    internal class Celda
    {
        bool hayMina;
        int minasAlrededor;

        public Celda()
        {
            hayMina = false;

        }

        public void colocaMina()
        {
            hayMina = true;
        }

        public void dibuja()
        {
            if (hayMina)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else {
                Console.WriteLine(minasAlrededor);
            }
        }

    }
}
