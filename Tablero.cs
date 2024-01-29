using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAW.PRO._2._4.Buscaminas
{
    internal class Tablero
    {
        int ancho;
        int alto;
        int cantidadMinas;
        Celda[,] celdas;
        public Tablero()
        {
            setTablero();
            celdas = new Celda[ancho, alto];

        }

        public void setTablero()
        {
            Console.WriteLine("Ancho del tablero: ");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Alto del tablero: ");
            alto = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de minas: ");
            cantidadMinas = int.Parse(Console.ReadLine());
        }


        public void colocaMinas()
        {
            // GetLength(0) debería ser igual al ancho y GetLength(1) al alto. Comprobar.

            //Coloca la cantidad de minas en orden.
            for (int i = 0; i < cantidadMinas; i++)
            {
                for (int j = 0; j < celdas.GetLength(0); j++)
                {
                    for (int k = 0; k < celdas.GetLength(1); k++)
                    {
                        celdas[k, k].colocaMina();
                    }
                }
            }

            // Redistribuye las minas
            int aux1;
            int aux2;

            aux1 = Program.rng.Next(celdas.GetLength(0);



        }




    }
}
