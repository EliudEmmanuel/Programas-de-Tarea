using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENTRADA
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            /* Se declara una variable y convertirlo en integer para luego mostrar
             * "Dato entero: x ¡Muy bien!" o "Dato no es entero. Intentar Nuevamente"
             */

            //se declara la variable
            string valor;
            int entrada = 0;
            //se pide que ingrese algo
            Console.WriteLine("Escribe Algo: ");
            valor = Console.ReadLine();

            //se pone una condicion en donde 
            //si se ingresa un numero entero muestra el siguiente texto
            if (int.TryParse(valor, out entrada))
            {
                Console.WriteLine(string.Format("Dato entero: {0}. ¡Muy Bien!", entrada));

            }
            //pero si se ingresa un numero con decimales o un texto, muestra que es incorrecto
            else
            {
                Console.WriteLine("Dato no es entero. Intentar Nuevamente");
            }
            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}