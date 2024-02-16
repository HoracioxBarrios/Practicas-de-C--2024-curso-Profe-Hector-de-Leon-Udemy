namespace C_AppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] amigos = new string[7];// Declaración de un array sin valores inicializados



            string[] amigos2 = new string[7]// Declaración de un array con algunos valores inicializados, excepto el último que es null
            {
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Cintia",
                "luis",
                null
            };

            // Imprime los elementos del array amigos2
            Console.WriteLine(amigos2[0]);
            Console.WriteLine(amigos2[1]);
            Console.WriteLine(amigos2[2]);
            Console.WriteLine(amigos2[3]); 
            Console.WriteLine(amigos2[4]);
            Console.WriteLine(amigos2[5]);
            Console.WriteLine(amigos2[6]);// El elemento 7, que es null, no se muestra en el registro

            // Asigna un valor al elemento 7 del array amigos2
            amigos2[6] = "Rafa"; 
            Console.WriteLine(amigos2[6]);




            //Es posible editar o corregir un valor existente
            amigos2[0] = "Lilia";
            Console.WriteLine(amigos2[0]);



            //No es posible agregar un elemento mas al array (NO SE PUEDE SOBREPASAR LA CANTIDAD DE ELEMENTOS DEFINIDO EN EL ARRAY)
            amigos2[7] = "Angel";
            Console.WriteLine(amigos2[7]);
            /*
             ERROR: Unhandled exception. System.IndexOutOfRangeException: Index was outside 
            the bounds of the array.
             */






            /*
            Los elementos dentro de un array están indexados, comenzando desde 0.
            Los índices aumentan secuencialmente según el número de elementos en el arreglo.
            Todos los elementos deben ser del mismo tipo de dato definido (en este caso, un 
            array de strings).





            
            En C#, un array es UNA ESTRUCTURA DE DATOS  que almacena una colección de elementos del MISMO TIPO . 
            Estos elementos se almacenan en posiciones contiguas de memoria y se accede a ellos mediante un índice numérico.

            Los arrays en C# tienen las siguientes características:

            * Tipo de elementos homogéneo: Todos los elementos de un array deben ser del mismo tipo, 
            ya sea tipos primitivos (como int, char, etc.) o tipos de referencia (como clases u otros arrays).

            * Tamaño fijo: Una vez que se declara un array, su tamaño no puede cambiar. Es decir, el número de 
            elementos que puede contener un array se establece en el momento de la creación y no puede ser 
            modificado dinámicamente.

            * Índices basados en cero: Los índices de un array en C# comienzan en cero, lo que significa que 
            el primer elemento se accede con el índice 0, el segundo con el índice 1, y así sucesivamente.

            * Sintaxis de declaración: En C#, puedes declarar un array utilizando la siguiente sintaxis:

            tipo[] nombreArray;
            */



        }
    }
}
