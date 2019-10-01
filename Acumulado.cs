using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumulado
{
    class Program
    {
        static void Main(string[] args)
        {
            string Numeros;
            int numero;
            int acumulado = 0;
            Console.WriteLine("capture los enteros a acumular: ");
            Console.WriteLine("dejar vacio y dar INTRO para salir");
            Console.WriteLine("");

            while (true)
            {
                Console.Write("Dame un Número que sea entero: ");
                Numeros = Console.ReadLine();
                if (Numeros =="")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(Numeros, out numero))
                    {
                        acumulado += numero;
                        Console.WriteLine(String.Format("Monto acumulado: {0}", acumulado));
                    }
                    else
                    {
                        Console.WriteLine("El dato proporcionado no es un Número entero");
                        Console.WriteLine("Intentelo de Nuevo");
                    }
                }
                
            }
        
            Console.WriteLine("");
            Console.WriteLine("Presione INTRO para continuar");
            Console.ReadKey();
            
        }
    }
}
