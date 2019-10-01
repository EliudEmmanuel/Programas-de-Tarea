using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aleatorio
{
    class Num_Aleatrio_Y_Conversiones
    {
        //se le agrega la F al final del numero para no confundirlo con el double
        static public float n1 = 18F;
        static void Main(string[] args)
        {
            /*se declara una variable con el valor float 
            mostrando el mensaje "La suma de x y y es z"
            un valor float sirve para declarar numeros reales de coma flotante
            se tiene que poner la f porque si no se le agrega se puede confundir con un double
            por ejemplo float x = 31.5f;*/

            //se declara el numero 2 
            float n2 = 0.0F;
            //se da la instruccion que nAle es un numero aleatorio
            Random nAle = new Random();
            //la maquina puede sumar el primer numero con uno aleatorio que son del 1 al 10
            n2 = (float)nAle.Next(1, 11);
            //muestra el resultado
            Console.WriteLine(string.Format(
                "La suma de {0} y {1} es {2}", n1, n2, n1 + n2));
            Console.ReadLine();
        }
    }
}