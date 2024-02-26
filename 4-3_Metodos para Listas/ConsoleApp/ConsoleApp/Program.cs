using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List + ctr + punto 
            List<int> listNumeros = new List<int>()
            {
                4, 5, 6, 10
            };

            Show(listNumeros);


            //INSERT
            listNumeros.Insert(0, 100); // En el index pasado, inserta un elemento 

            Show(listNumeros);



            //CONTAINS
            bool existeElElemento = listNumeros.Contains(100); //Verifica si el elemento pasado por parametro existe en la lista y devuelve bool

            if (existeElElemento)
            {
                Console.WriteLine("Existe en la Lista");
            }
            else
            {
                Console.WriteLine("No existe en la Lista");
            }




            //INDEXOF
            int posicionDelElemento = listNumeros.IndexOf(10);
            Console.WriteLine($"Posicion del Elemento --> Indice: {posicionDelElemento}");





            //SORT
            listNumeros.Sort();

            Show(listNumeros);// Ordena de menor a Mayor
            /*
                 * Sort() en C# ordena los elementos de una lista en orden ascendente. 
                  Dado que la lista es mutable, es decir, puede cambiar, la llamada a 
                  Sort() modificará la lista original reordenando sus elementos.
             */

            //Ejemplo de Inmutable:
            string name = "horacio";
            name.ToUpper();
            Console.WriteLine(name); // string es inmutable
            //Si quisieramos cambiar tendriamos que crear una variable donde guardar el dato cambiado, ya que en la misma variable no hara ninguncambio.
            string nombreCorregido = name.ToUpper();
            Console.WriteLine(nombreCorregido);


            //ADDRANGE
            List<int> listNumeros2 = new List<int>() { 200, 300, 400 };
            listNumeros.AddRange(listNumeros2); //Agrega a la lista, otra lista o coleccion que implemente la interfaz IEnumerable




        }//fin Main
        public static void Show(List<int> numeros)
        {
            Console.WriteLine("--- Numeros ----");
            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);
            }
        }

        public static void Show2(List<int> numeros)
        {
            foreach (var numero in numeros)// var infiere el tipo de dato
            {
                Console.WriteLine(numero);
            }
        }


    }//fin class Program
}
