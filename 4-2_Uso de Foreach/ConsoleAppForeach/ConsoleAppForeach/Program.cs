using System.Collections.Generic;

//Truco: escribiendo List + control + punto , nos saldrá la sugerencia del namespace System.Collection.Generic

namespace ConsoleAppForeach
{
    internal class Program
    {
        /*
            foreach es una estructura de control que permite iterar 
            sobre elementos en una colección o secuencia de elementos, como 
            arrays, listas, diccionarios, etc. Se utiliza para simplificar 
            la iteración sobre estos elementos, ya que elimina la necesidad 
            de manejar índices o punteros explícitamente.
         */
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                10, 3, 5, 22, 12
            };

            //Usamos var, el compilador infiere el tipo de dato a usar, porque estás inicializando un: new List<int>()   a la derecha

            //var esta permitido ser usado solo dentro de un metodo.
            var numeros2 = new List<int>()
            {
               10, 3, 5, 22, 12
            };
            //numeros2.Add("5"); NO SE PUEDE AGREGAR EN TIPO DE DATO DIFERENTE AL DECLARADO






            //Conviene aclarar el tipo correcto a usar var como comodin.
            // Se especifica el tipo int para mayor claridad en el bucle foreach.
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }


            // Utiliza 'var' cuando el tipo de dato es claro a partir del contexto, sea simple o complejo.
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            /*
             Dato:
            Generalmente se utiliza la interfaz IEnumerable (o su genérico IEnumerable<T>) para permitir la 
            iteración sobre una colección de elementos.
            
            *La interfaz IEnumerable proporciona un método GetEnumerator() que devuelve un enumerador 
            que puede utilizarse para recorrer los elementos de la colección.

            Sin embargo, es posible iterar sobre una colección que no implemente directamente la interfaz 
            IEnumerable siempre y cuando tenga un método GetEnumerator() que devuelva un enumerador. 
            Este es el caso de las clases que implementan el patrón de diseño "Enumerator"...
             */







            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Hector", Pais = "Mexico"},
                new Persona() { Nombre = "Roberto", Pais = "Argentinao"},
                new Persona() { Nombre = "Hector", Pais = "España"}
            };



            Show(personas);


            //Eliminar elemento segun el indice
            personas.RemoveAt(0);
            Show(personas);



        }//fin de método Main  



        //declaramos un metodo static ya que main es static dentro de la class Program
        static void Show(List<Persona> personas)
        {
            Console.WriteLine("----- Personas-----");
            foreach(Persona persona in personas)
            {
                Console.WriteLine($"Nombre : {persona.Nombre}, Pais: {persona.Pais}");
            }
        }

            

        
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }

        
    }
}
