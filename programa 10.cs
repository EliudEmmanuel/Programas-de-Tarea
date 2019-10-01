using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            Console.Write("Escribe un Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Escribe un Apellido: ");
            apellido = Console.ReadLine();
            //Procesamos el texto para pasarlo a Mayúsculas
            nombre.ToUpper();
            apellido.ToUpper();
            /*Los datos string son inmutables, por tanto
             * al conectarlos con "+", solo creamos copias y consumimos mas memoria
             * por tanto, usaremos un objeto StringBuilder y concatenaremos sin clonar
             * los valores*/
            StringBuilder nombreCompleto = new StringBuilder(nombre);
            nombreCompleto.Append(" ");
            nombreCompleto.Append(apellido);

            //Salida y Finalización
            Console.WriteLine("Nombre Completo: " + nombreCompleto);
            Console.WriteLine("Presione ENTER para finalizar");
            Console.ReadKey();
        }
    }
}