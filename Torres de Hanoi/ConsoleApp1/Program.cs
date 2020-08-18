using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int contador = 1;


            void Hanoi3(int N, char Orig, char Dest, char Aux) {

                if (N == 1) {
                    Console.WriteLine(contador + ". Movimiento: " + Orig + " -> " + Dest);
                    contador += 1;
                }
                else {

                    Hanoi3(N - 1, Orig, Aux, Dest);
                    Console.WriteLine(contador + ". Movimiento: " + Orig + " -> " + Dest);
                    contador += 1;
                    Hanoi3(N - 1, Aux, Dest, Orig);
                }
            }

            void Hanoi4(int N, char Orig, char Dest, char Aux1, char Aux2)
            {
                int M;

                if (N == 0)
                {
                    // En este caso base no se hace nada
                }
                else if (N == 1)
                {
                    Console.WriteLine(contador + ". Movimiento: " + Orig + " -> " + Dest);
                    contador += 1;
                }
                else
                {
                    M = N / 2;
                    Hanoi4(N - M, Orig, Aux1, Dest, Aux2);
                    Hanoi3(M, Orig, Dest, Aux2);
                    Hanoi4(N - M, Aux1, Dest, Orig, Aux2);
                }
            }

            // Aqui comienza el main....

            Console.WriteLine("Proyecto Matematica Discreta: Torres de Hanoi");
            Console.WriteLine("Este programa representa la cantidad de movimientos de n discos en 4 torres.");
            Console.WriteLine("Para salir escriba -1");

            int n = 0;
            do {
                n = 0;
                contador = 1;
                try
                {
                    Console.Write("Escriba un numero n: ");
                    n = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\n");

                    if (n > 0 && n < 7)
                    {
                        //void Hanoi4(int N, char Orig, char Dest, char Aux1, char Aux2)
                        Hanoi4(n, 'A', 'D', 'B', 'C');
                    }
                    else if (n == 0)
                    {
                        Console.WriteLine("No hay movimientos.");
                    }
                    else if (n == -1)
                    {
                        Console.WriteLine("Adios! :)");
                    }
                    else
                    {
                        Console.WriteLine("Valor fuera del rango. Ingrese un numero entre 0 y 6.");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadKey();
                System.Console.Clear();

            } while (n != -1);
            
        }
    }

  
}
