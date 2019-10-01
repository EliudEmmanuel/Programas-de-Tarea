
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Progra_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En C# las variables se declaran mencinando 
             * el tipo de dato que tendra, despues el nombre 
             * de la variable que se va a utilizar y si se sabe 
             * lo que se va a almacenar desde un pricipio se puede 
             * colocar despues de un signo de "="*/
            string numero = "1234";

            //El GetType muestra la representacion string de la variable
            Console.WriteLine(numero.GetType().ToString());

            //Se declara una variable para convertirla en Int y mostrar el tipo en pantalla
            int intNumero = Convert.ToInt32(numero);
            Console.WriteLine(intNumero.GetType().ToString());

            //String.Formate permite hacer macro substituciones
            Console.WriteLine(String.Format("El numero es {0}", intNumero));

            Console.ReadLine();
        }
    }
}
