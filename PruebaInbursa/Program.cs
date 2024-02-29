using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInbursa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int montoInicial = 13000;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                montoInicial -= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(montoInicial);
            Console.ReadKey();
            int n = int.Parse(Console.ReadLine());

            int elemento1 = 0;
            int elemento2 = 1;
            int sucesion = 0;

            for (int i = 0; i < n; i++)
            {

            }
            int N;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out N) || N < 0 || N > 20);
            for (int i = 1; i <= N; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.ReadKey();
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }

            int registros = int.Parse(Console.ReadLine());
            int registrosPagina = int.Parse(Console.ReadLine());
            int paginaSeleccionada = int.Parse(Console.ReadLine());
            if (registros <= 0 || registrosPagina <= 0 || paginaSeleccionada <= 0)
            {
                Console.WriteLine("INVALIDA");
            }
            else
            {
                int numeroPaginas = registros / registrosPagina;
                if (registros % registrosPagina != 0)
                    numeroPaginas++;
                if (paginaSeleccionada > numeroPaginas)
                {
                    Console.WriteLine("INVALIDA");
                }
                else
                {
                    int primerRegistro = (paginaSeleccionada - 1) * registrosPagina + 1;
                    int ultimoRegistro = Math.Min(paginaSeleccionada * registrosPagina, registros);
                    Console.Write(primerRegistro);
                    for (int i = primerRegistro + 1; i <= ultimoRegistro; i++)
                    {
                        Console.Write("," + i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
