using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables 
            string nombre, apPaterno, apMaterno, Matricula, NombreCurso;
            byte Calificacion1, Calificacion2, Calificacion3, Calificacion4;

            //Solicitar los datos al usuario
            Console.WriteLine("\n APP PARA SABER SI ACREDITASTE EL CURSO");
            Console.WriteLine("Introduce tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("introduce tu apellido paterno:");
            apPaterno= Console.ReadLine();
            Console.WriteLine("introduce tu apellido materno.");
            apMaterno= Console.ReadLine();
            Console.WriteLine("introduce tu matricula:");
            Matricula = Console.ReadLine();
            Console.WriteLine("Introduce el nombre del curso:");
            NombreCurso = Console.ReadLine();
            Console.WriteLine("introduce tu calificacion de la primera unidad 1");
            Calificacion1 = Convert.ToByte(Console.ReadLine());

            //Proceso para saber si acredito o no 
           
            if (Calificacion1 >= 70)
            {
                Console.WriteLine("introduce tu calificacion de la unidad 2");
                Calificacion2= Convert.ToByte(Console.ReadLine());
                if (Calificacion2 >= 70)
                {
                    Console.WriteLine("introduce tu calificacion de la unidad 3");
                    Calificacion3 = Convert.ToByte(Console.ReadLine());
                    if (Calificacion3 >= 70)
                    {
                        Console.WriteLine("introduce tu calificacion de la unidad 4");
                        Calificacion4 = Convert.ToByte(Console.ReadLine());
                        if (Calificacion4 >= 70 )
                        {
                            Console.WriteLine("Acreditaste todas la unidad bro B)");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO acreditaste la Tercera unidad unidad");
                    }
                }
                else
                {
                    Console.WriteLine("NO acreditaste la segunda unidad unidad");
            }
                }
            else
            {
                Console.WriteLine("NO acreditaste la primera unidad");
            }
        } 
    }
}
