using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alumno: Jorge Octavio Antunez Paritda - 21211910

            try
            {
                Console.Write("Ingresa un numero: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresa otro numero: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(n1 / n2);
                Console.ReadLine();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            finally
            {
                Console.WriteLine("Codigo finally ejecutado.");
            }

            // Cerrar Programa
            Console.Write("Preciona ENTER para salir. . .");
            Console.ReadKey();
        }
    }
}