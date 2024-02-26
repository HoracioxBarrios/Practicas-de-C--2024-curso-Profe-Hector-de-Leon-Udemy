using System.Collections.Generic;

namespace ConsoleAppListas
{
    internal class Program
    {
        /*
            una LISTA es una estructura de datos que almacena una colección de elementos del 
            mismo tipo de manera secuencial. Las listas en C# son parte del espacio de nombres 
            System.Collections.Generic y se basan en la clase List<T>, donde T (tipo de dato 
            Generic)representa el tipo de elementos que la lista puede contener.

            Algunas características importantes de las listas en C# incluyen:

            * Dinamismo: Las listas pueden cambiar de tamaño dinámicamente, lo que significa que 
            pueden crecer o disminuir según sea necesario durante la ejecución del programa.

            * Acceso por índice: Los elementos dentro de una lista se pueden acceder mediante un 
            índice numérico. El índice comienza en cero para el primer elemento y continúa 
            secuencialmente hasta el último elemento de la lista.

            * Tipo seguro: Las listas en C# son tipo seguro, lo que significa que al definir una 
            lista, especificas el tipo de elementos que contendrá y la lista solo puede contener 
            elementos de ese tipo.

            * Funcionalidades de colección: Las listas ofrecen una amplia gama de funcionalidades
            para trabajar con colecciones de datos, como agregar elementos, eliminar elementos, 
            buscar elementos, ordenar elementos, etc.
            (metodos para Listas que vemos mas adelante.)
            


            DIFERENCIAS CON ARRAY
            *no reemplazan directamente a los arrays, pero ofrecen una alternativa más flexible y 
            dinámica para trabajar con colecciones de datos. ya que os arrays tienen un tamaño fijo 
            que se establece al momento de su creación.
            
            Los arrays pueden contener cualquier tipo de datos, mientras que las listas 
            están diseñadas para contener elementos de un solo tipo
         */
        static void Main(string[] args)
        {
            //INSTANCIAMOS UNA LIST y aclaramos el tipo T
            List<int> numbers = new List<int>();


            //AGREGAR ELEMENTOS A LA LIST
            numbers.Add(5); 
            numbers.Add(2);

            Console.WriteLine(numbers.Count); // Count es una Propiedad que nos dice cuantos elementos hay en la List

            //Podemos inicializar una List con elementos:
            List<int> numbers2 = new List<int>() 
            {
                10,5, 55, 10, 2 
            };

            Console.WriteLine(numbers2.Count());
            numbers2.Add(20);
            numbers2.Add(100);
            Console.WriteLine(numbers2.Count());

            //PODEMOS LIMPIAR O BORRAR TODO lo de la List !!!
            numbers2.Clear();
            Console.WriteLine(numbers2.Count());


            // EJEMPLO LISTA DE STRING
            List<string> paises = new List<string>() 
            {
                "Mexico", "Argentina", "España"             
            };

            Console.WriteLine(paises.Count());
        }
    }
}
