using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.PRO._2._4.Buscaminas
{
    internal class Celda
    {
        public bool hayMina;
        int minasAlrededor;

        public Celda()
        {
            hayMina = false;
        }

        public void colocaMina()
        {
            hayMina = true;
        }

        public void dibujaCelda()
        {
            if (hayMina)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" * ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else {
                Console.Write(" "+minasAlrededor+" ");
            }
        }

        public void rodeanMinas() { 
            minasAlrededor ++;
        }

    }
}
