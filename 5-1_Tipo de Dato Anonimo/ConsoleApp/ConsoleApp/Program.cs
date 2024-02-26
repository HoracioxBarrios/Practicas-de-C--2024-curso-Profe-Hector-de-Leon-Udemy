namespace ConsoleApp
{
    internal class Program
    {
        /*
             El tipo de dato anónimo es un tipo de dato especial que permite 
            a los desarrolladores crear objetos sin tener que definir explícitamente 
            su tipo. Los tipos de datos anónimos son útiles cuando se necesita 
            encapsular un conjunto de valores relacionados temporalmente, como en 
            consultas LINQ o en situaciones donde la estructura de datos es conocida 
            pero no es necesario definirla formalmente.

            Los tipos de datos anónimos son útiles para situaciones donde necesitas 
            estructuras de datos simples y temporales. Sin embargo, hay algunas 
            limitaciones importantes a tener en cuenta:
            
            1 Inmutabilidad: Los tipos de datos anónimos son inmutables, lo que
            significa que una vez que se crean, no se pueden modificar
            
            2 Alcance limitado: Los tipos de datos anónimos solo pueden ser utilizados 
            dentro del método o contexto donde se definen.

            3 Difícil de mantener: Puede ser difícil de mantener el código que hace un 
            uso extensivo de tipos de datos anónimos, ya que carecen de una definición de 
            tipo explícita.
         

            En resumen, los tipos de datos anónimos son una característica útil de C# para 
            situaciones donde necesitas estructuras de datos simples y temporales sin tener que 
            definir formalmente un tipo de datos. Sin embargo, deben usarse con moderación y 
            se deben considerar otras opciones, como las clases y las estructuras, para 
            estructuras de datos más complejas y reutilizables.
         */
        static void Main(string[] args)
        {
            //TIPO ANONIMO
            var personaje = new
            {
                Name = "Hora",
                Pais = "Arg"
            };// si nos posicionamos sobre vat nos dice que es de tipo anonimo.

            Console.WriteLine($"{personaje.Name} - {personaje.Pais}");

            //Desventaja: el tipo anonimo es inmutable, es read only. NO SE PUEDEN MODIFICAR


            //COLECCION DE TIPOS ANONIMOS
            var beers = new[]
            {
                new {Name = "red", Brand = "Delirum"},
                new {Name = "black", Brand = "Quilmes"}
            };


            Console.WriteLine("Coleccion anonima: ");
            foreach (var beer in beers)
            {
                
                Console.WriteLine($"Cerveza: {beer.Name} - {beer.Brand}");
            }

        }
    }
}
