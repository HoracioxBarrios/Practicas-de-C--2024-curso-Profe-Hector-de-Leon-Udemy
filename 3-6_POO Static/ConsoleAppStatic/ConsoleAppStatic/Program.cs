
/*
 * using System;
 En .net 8 no es necesario agregar la directiva using system???

 No, no es necesario agregar la directiva using System en .NET 8. A partir de .NET 8, 
la directiva using System se agrega automáticamente a todos los archivos C#. Esto significa
que ya no es necesario escribirla explícitamente. 
 */
using System.Diagnostics;
using static ConsoleAppStatic.Persona;

namespace ConsoleAppStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase Persona y le asignamos valores a sus propiedades.
            Persona elise = new Persona()
            {
                Nombre = "Elise",
                Edad = 30
            };  // con esto se le pude asignar las propiedades automaticamente.


            //Otra instancia de la clase Persona
            Persona lucas = new Persona()
            {
                Nombre = "Lucas",
                Edad = 25
            };








            //No utilizamos una instancia u objeto!
            Console.WriteLine(Persona.Count);
            // Imprimimos el valor de la propiedad 'Count' directamente desde la clase Persona.
            // Al ser estática, la propiedad 'Count' pertenece a la clase en sí y no requiere una instancia de objeto para acceder a ella.


            //persona.Count;
            // Si intentamos acceder a la propiedad 'Count' desde una instancia de objeto, como, obtendríamos un error.
            // 'Count' pertenece al tipo de datos Persona y se accede a través de la clase en lugar de una instancia de objeto.


            //Los metodos Static debemos invocarlos con su Clase. No se puede usar desde una instancia de objeto.
            Console.WriteLine(Persona.GetCount());






            Utilidades.NombreEmpresa = "Mercado Libre";
            Utilidades.MensajeBienvenida("Horacio");

        }
    }

    public class Persona
    {
        // Propiedades auto-implementadas para Nombre y Edad.
        public string Nombre { get; set; }
        public int Edad { get; set; }


        // PROPIEDAD STATIC
        //Count para realizar un seguimiento del número de instancias de la clase Persona.
        public static int Count = 0; // Count es una propiedad de la clase Persona en sí misma, y no de las instancias individuales de Persona.




        //Constructor - Al crearse una instancia de esta clase se incrementa el contador.
        public Persona()
        {
            Count++;
        }

        // METODO STATIC
        public static string GetCount()
        {
            return $"Esta Clase se ha utilizado {Count} veces"; // usamos interpolacion de cadenas o String interpolation
        }



        //CLASE STATIC

        /*
           Una clase es un tipo de dato que define la estructura y el comportamiento de los 
           objetos en un programa.
        
           Cuando se declara algo como estático dentro de una clase, pertenece al tipo de 
           la clase en sí misma y no a las instancias individuales de la clase.
         


         * Una propiedad puede ser estática:
           lo que significa que pertenece al tipo de la clase 
           y no a las instancias específicas de la clase.
         
         * Un método puede ser estático: 
           lo que indica que puede ser invocado directamente desde 
           la clase y no requiere una instancia de la clase para ser utilizado.
         
         * Una clase puede ser estática:
           En este caso, todos los miembros de la clase deben ser 
           estáticos. Las clases estáticas no se pueden instanciar y se utilizan principalmente 
           para agrupar métodos estaticos y propiedades estaticas relacionados que no dependen 
           del estado de ningún objeto en particular.
         */

        public static class Utilidades //CLASE ESTATICA
        {
            // Propiedad estática para almacenar el nombre de la empresa
            public static string NombreEmpresa { get; set; } // PROPIEDAD ESTATICA

            // Método estático para imprimir un mensaje de bienvenida
            public static void MensajeBienvenida(string nombre) // METODO ESTATICO
            {
                Console.WriteLine($"Bienvenido/a a {NombreEmpresa}, {nombre}!");

            }
        }


        //otro ejemplo:
        //La Clase Math de C# es una clase static que tiene metodos static.
    }
}
