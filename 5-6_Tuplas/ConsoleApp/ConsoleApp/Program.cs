namespace ConsoleApp
{
    internal class Program
    {
        //Tuplas
        /*
        la tupla en C# en sí misma es semanticamente inmutable, pero los 
        elementos a los que hace referencia pueden ser mutables. Esto 
        significa que, si necesitas que los valores de la tupla sean 
        completamente inmutables, debes asegurarte de que los tipos de 
        datos que contiene la tupla sean inmutables o no modificables.

        A diferencia de la tupla de Python que es completamente inmutable.
         */
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "Lapicera");
            Console.WriteLine($"{product.id} - {product.name}");

            //su el tipo de dato del elemento es mutable se puede cambiar
            product.name = "Lapiz";
            Console.WriteLine($"{product.id} - {product.name}");
            /*
             En este caso, product es una tupla con dos elementos: un 
            entero (int) y un string (string). LA ESTRUCTURA DE LA TUPLA 
            en sí misma NO PUEDE SER MODIFICADA después de su creación, 
            lo que significa que no puedes agregar ni quitar elementos de 
            la tupla.



            Sin embargo, el valor de los elementos de la tupla puede 
            cambiar si el tipo de dato que contienen lo permite. En el 
            caso del string name, aunque el objeto string en sí es inmutable, 
            el contenido al que apunta el objeto string puede cambiar, 
            lo que es diferente de cambiar la referencia del objeto string 
            en la tupla. Es decir, puedes asignar un nuevo valor a name, 
            pero eso no modifica el objeto string original, sino que CREA 
            UNO NUEVO y actualiza la referencia en la tupla.
             */


            //OTRA FORMA DE CREAR UNA TUPLA
            var persona = (1, "Hora");
            Console.WriteLine("Ejemplo 2:");
            Console.WriteLine($"{persona.Item1} - {persona.Item2}");





            // CREAMOS ARRAY DE TUPLAS
            Console.WriteLine("Ejemplo 3:");
            var peoples = new[]
            {
                (1, "Hora", "A"),
                (2, "Fram", "B"),
                (3, "Fer", "C")
            };

            foreach (var person in peoples)
            {
                Console.WriteLine($"{person.Item1} - {person.Item2} - {person.Item3}");
            }





            //OTRA FORMA - PERO CON EL NOMBRE QUE NOS SIRVE PARA SER ACCEDIDO EL ELEMENTO:
            (int id, string name)[] persona2 = new[] 
            {
                (1, "Lucia"),
                (2, "Romi"),
                (3, "Ana")
            };

            foreach (var person in persona2)
            {
                Console.WriteLine($"{person.id} - {person.name}");
            }

            /*UNA DE LAS FORMAS PARA LA QUE SE USAN LAS TUPLAS ES CUANDO
             EN UNA FUNCION NECESITAMOS RETORNAR MAS DE 1 VALOR*/

            var cityInfo = GetLocation();
            Console.WriteLine($"Lat: {cityInfo.latitud}, Long: {cityInfo.longitud},Nombre de la Ciudad: {cityInfo.nombreCiudad}");









            //FORMA DE IGNORAR VALORES - O OBTENER UN VALOR EN CONCRETO DE LA TUPLA QUE REGRESA EL METODO GET
            var (_, Longitud, _) = GetLocation();
            Console.WriteLine(Longitud);

        }//fin Main()


        //METODO que retorna una tupla
        public static (float latitud, float longitud, string nombreCiudad) GetLocation()
        {
            float latitud = 19.121212f;
            float longitud = 10.0f;
            string nombreCoidad = "Buenos Aires";
            return (latitud, longitud, nombreCoidad);

        }
    }//Fin Program
}
