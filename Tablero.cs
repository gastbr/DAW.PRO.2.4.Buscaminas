using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
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
            for (int i = 0; i < celdas.GetLength(1); i++)
            {
                for (int j = 0; j < celdas.GetLength(0); j++)
                {
                    celdas[j, i] = new Celda();
                }
            }
            colocaMinas();
            calculaMinas();
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
            Celda aux;
            int aux11;
            int aux12;
            int aux21;
            int aux22;

            // GetLength(0) debería ser igual al ancho y GetLength(1) al alto. Comprobar.
            // Coloca la cantidad de minas en orden desde el inicio.

            for (int i = 0; i < alto; i++)
            {
                if (i < cantidadMinas)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        if ((i * 10 + j) < cantidadMinas)
                        {
                            celdas[j, i].colocaMina();
                        }
                    }
                }
            }


            // Redistribuye las minas
            for (int i = 0; i < 1000; i++)
            {
                aux11 = Program.rng.Next(ancho); // celda 1, indice 1 (ancho)
                aux12 = Program.rng.Next(alto); // celda 1, indice 2 (alto)
                aux21 = Program.rng.Next(ancho); // celda 2, indice 1 (ancho)
                aux22 = Program.rng.Next(alto); // celda 2, indice 2 (alto)
                aux = celdas[aux11, aux12];
                celdas[aux11, aux12] = celdas[aux21, aux22];
                celdas[aux21, aux22] = aux;
            }
        }

        public void calculaMinas()
        {
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (celdas[j, i].hayMina == true)
                    {
                        if (i >= 0)
                        {
                            if (i < alto - 1)
                            {
                                celdas[i + 1, j].rodeanMinas();
                            }
                        }
                        if (i <= alto - 1)
                        {
                            if (i > 0)
                            {
                                celdas[i - 1, j].rodeanMinas();
                            }
                        }
                        if (j >= 0)
                        {
                            if (j < ancho - 1)
                            {
                                celdas[i, j + 1].rodeanMinas();
                            }
                        }
                        if (j <= ancho - 1)
                        {
                            if (j > 0)
                            {
                                celdas[i, j - 1].rodeanMinas();
                            }
                        }
                    }
                }
            }
        }
        public void dibujaTablero()
        {
            for (int i = 0; i < celdas.GetLength(1); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < celdas.GetLength(0); j++)
                {
                    celdas[j, i].dibujaCelda();
                }
            }
        }
    }
}
