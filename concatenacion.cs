using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA DE ITERACIONES FINITAS CON FOR
            string _numero;
            int numero;
            //Convertiremos el dato que pedimos
            // a un int con el comando Convert
            Console.Write("Introduzca un Numero");
            _numero = Console.ReadLine();
            numero = Convert.ToInt32(_numero);

            //Procedemos a crear el ciclo con For, creando una tabla de multiplicaciones

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(
                string.Format("{0} x {1} = {2}",
                numero, i, numero * 1));
            }
            Console.WriteLine("Presione INTRO para terminar");
            Console.ReadKey();
        }
    }
}