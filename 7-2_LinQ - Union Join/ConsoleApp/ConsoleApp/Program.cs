using System.Collections.Generic; // para usar  las List
using System.Linq; // para Usar LinQ

namespace ConsoleApp
{
    internal class Program
    {
        //LinQ

        /*
        LINQ (Language Integrated Query) en C# es una característica que permite
        escribir consultas directamente dentro del código C# para interactuar 
        con colecciones de datos, bases de datos, servicios web y otros orígenes 
        de datos.

        LINQ proporciona una sintaxis similar a SQL para escribir consultas, 
        lo que facilita la manipulación y el filtrado de datos de manera 
        declarativa y legible. Esto permite a los desarrolladores realizar 
        operaciones como filtrado, ordenamiento, agrupamiento y proyección 
        sobre conjuntos de datos de una manera intuitiva y eficiente.
         */

        //----------------------------------------------------------------------

        //Join (Union)
        /*
         
        En C# LINQ, la operación Join es similar a la operación INNER JOIN en SQL. 
        Permite combinar dos colecciones basadas en una condición 
        de igualdad entre las propiedades de los elementos de ambas colecciones.
         */
        static void Main(string[] args)
        {
            //Tenemos que tener dos Listas:
            List<Cerveza> listCervezas = new List<Cerveza>()
            {
                new Cerveza()
                {
                    Nombre = "Corona", Pais = "Mexico"
                },
                new Cerveza()
                {
                    Nombre = "Delirium", Pais = "Belgica"
                },
                new Cerveza()
                {
                    Nombre = "Erdinger", Pais = "Alemania"
                }            
            };

            List<Pais> listPaises = new List<Pais>()
            {
                new Pais()
                {
                    Nombre = "Mexico", Continente = "America"
                },
                new Pais()
                {
                    Nombre = "Belgica", Continente = "Europa"
                },
                new Pais()
                {
                    Nombre = "Alemania", Continente = "Europa"
                }
            };

            var cervezasConContinentes = from cerveza in listCervezas
                                         join pais in listPaises
                                         on cerveza.Pais equals pais.Nombre // hasta aca se unen, y podemos crear una nueva coleccion (en este caso de tipo anonimo)
                                         select new
                                         {
                                             Nombre = cerveza.Nombre,
                                             Pais = cerveza.Pais,
                                             Continente = pais.Continente
                                         };
            //cervezasConContinentes termina siendo una nueva coleccion de tipo IEnumerable<T> anonimo

            foreach (var cerveza in cervezasConContinentes)
            {
                Console.WriteLine($"Nombre: {cerveza.Nombre}, Pais: {cerveza.Pais}, Continente: {cerveza.Continente}");
            }

        }//fin Main


    }//fin Program


    public class Cerveza
    {
        public string Nombre { get; set; } 
        public string Pais { get; set; } // dato a tener en comun

    }

    public class Pais
    {
        public string Nombre { get; set; } // dato a tener en comun, si son el mismo pais lo vamos a unir
        public string Continente { get; set; }

    }


}//fin mamespace
