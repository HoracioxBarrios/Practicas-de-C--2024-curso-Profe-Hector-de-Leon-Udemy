using System.Collections.Generic; // Para trabajar con List <Generics>
using System.Linq; // proporciona las funcionalidades principales de LINQ (Language Integrated Query) para consultar y manipular colecciones de datos en .NET.

namespace ConsoleApp
{
    internal class Program
    {

        /*
        LINQ (Language Integrated Query) en C# es una característica que permite escribir consultas 
        directamente dentro del código C# para interactuar con colecciones de datos, bases de datos, 
        servicios web y otros orígenes de datos.

        LINQ proporciona una sintaxis similar a SQL para escribir consultas, lo que facilita la 
        manipulación y el filtrado de datos de manera declarativa y legible. Esto permite a los 
        desarrolladores realizar operaciones como filtrado, ordenamiento, agrupamiento y proyección 
        sobre conjuntos de datos de una manera intuitiva y eficiente.
         
         
         */
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer()
                {
                    Name = "Quilmes", Country = "Argentina"
                },
                new Beer()
                {
                    Name = "Brahma", Country = "Brazil"
                },
                new Beer()
                {
                    Name = "Corona", Country = "Mexico"
                }           
            
            };

            foreach (var beer in beers)
            {
                Console.WriteLine(beer);// al mostrar asi el objeto se hace uso del método ToString sobreescrito en la class Beer
            }

            Console.WriteLine("------------- Select ---------------");
            //SELECT Ejemplo 1

            var beersName = from b in beers 
                            select new
                            {
                                Name = b.Name, // Selecciona el nombre de la cerveza.
                                Letters = b.Name.Length, // Calcula la longitud del nombre de la cerveza.
                                Fijo = 1 // Asigna un valor fijo. de ejemplo que podemos poner cualquier tipo de dato dentro
                            };      // CREA UNA SECUENCIA DE OBJETOS DE TIPO ANONIMO

            /*
            Este código utiliza LINQ para generar una SECUENCIA DE OBJETOS anónimos a partir 
            de una lista de cervezas. Es fundamental destacar que la diferencia entre una 
            colección de tipo anónimo que implementa IEnumerable y la secuencia de objetos 
            anónimos reside en la definición de IEnumerable como una interfaz que permite la 
            iteración, mientras que la secuencia de objetos anónimos representa simplemente un 
            conjunto ordenado de resultados producidos por la consulta LINQ. Esta secuencia, 
            en particular, contiene objetos anónimos que capturan propiedades específicas de 
            las cervezas, proporcionando así una estructura organizada de información a partir 
            de la lista de cervezas.             
             */

            foreach (var beer in beersName)
            {
                Console.WriteLine($"{beer.Name} - {beer.Letters} - {beer.Fijo}");
            }





            // SELECT Ejemplo 2
            // Si queremos seleccionar todo, podemos hacerlo de esta manera.
           

            var beersName2 = from b in beers
                             select b; // La expresión 'select b' devuelve una nueva colección de tipo IEnumerable que contiene todos los elementos de la lista de cervezas 'beers'.

            //Como nos devolvio una coleccion de tipo IEnumerable, no disponemos de metodos para List

            foreach (var beer in beersName2)
            {
                Console.WriteLine(beer);
            }



            // creamos una coleccion que tiene solo nombres en base a una List de Cervezas
            var coleccionSoloNombreBeer = from b in beers
                                          select b.Name;


            foreach(var beer in coleccionSoloNombreBeer)
            {
                Console.WriteLine(beer);
            }







            Console.WriteLine("------------- Buscar o Filtrar ---------------");

            var beersMexico = from b in beers // quiero de mi coleccion, representada por 'b'
                              where b.Country == "Mexico"
                              || b.Country == "Argentina"// el pais que coincida con 'Mexico' .((( Se puede usar || o && para la condicion )))
                              select b;// regresamelo tal cual como es el objeto. es  decir una coleccion de tipo IEnumerable <Beer>

            foreach (var beer in beersMexico)
            {
                Console.WriteLine(beer);
            }






            Console.WriteLine("------------- Ordenar ---------------");

            var coleccionOrdenadaAscendent = from b in beers
                                    orderby b.Country 
                                    select b;

            //Nos crea una coleccion de tipo IOrderedEnumerable ASCENDENTE

            foreach(var beer in coleccionOrdenadaAscendent)
            {
                Console.WriteLine(beer);
            }






            var coleccionOrdenadaDescendent = from b in beers
                                    orderby b.Country descending
                                    select b;

            //Nos crea una coleccion de tipo IOrderedEnumerable DESCENDENTE

            foreach (var beer in coleccionOrdenadaDescendent)
            {
                Console.WriteLine(beer);
            }

            //IOederedEnumerable tiene sus propios metodos


        }



    }

    public class Beer
    {
        public string Name { set; get; }
        public string Country { set; get; }

        public override string ToString()
        {
            return $"Nombre: {Name}, Pais: {Country}";
        }
    }
}
