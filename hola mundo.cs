
//El using se utiliza para llamar librerias mediante nombres cortos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*En Visual Studio los proyectos se componen de un namespace, la cual 
 * contiene una clase, la cual contiene un metodo en el cual se ejecutara 
 * el codigo*/
namespace Evidencia1_Progra_II
{
    /*Como se puede observar todos los bloques de codigo se delimitan con 
     * llaves {} y que las lineas terminan con ; */
    class Program
    {
        static void Main(string[] args)
        {
            /*El WriteLine se usa para mandar a la pantalla el mensaje o 
             * el texto que se indique en el codigo*/
            Console.WriteLine("Hola Mundo, ¡Ahora en C#!");
            /*El ReadLine se utiliza para pausar el codigo y que no se 
             * cierre o continue automaticamente la ejecucion del codigo. 
             * Esta pausa se finaliza con un ENTER*/
            Console.ReadLine();
        }
    }
}