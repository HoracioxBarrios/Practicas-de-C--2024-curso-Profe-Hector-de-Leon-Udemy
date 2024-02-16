namespace C_AppSentenciaIf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sentencia If
            //ejemplo 1
            
            bool tenesDinero = true;


            if (tenesDinero)// // Si la variable 'tenesDinero' es verdadera, ejecuta el bloque de código
            {
                Console.WriteLine("Podes comprar");
            }

            //ejemplo 2

            bool tenesDinero2 = true;
            bool mayorDeEdad = true;
            // Verifica si el usuario tiene suficiente dinero y es mayor de edad
            // para comprar cerveza.
            if (tenesDinero2 && mayorDeEdad) // Se ejecuta el código si ambas variables son True; de lo contrario, la condición no se cumple. 
            {
                Console.WriteLine("Podes comprar Cerveza");
            }
            // && se lo llama operador logico AND e Indica que una expresión condicional es verdadera si y solo si ambas condiciones se cumplen (si son verdaderas)

            //ejemplo 3 

            bool tenesDinero3 = true;
            bool mayorDeEdad2 = true;
            // Verifica si el usuario tiene suficiente dinero y es mayor de edad
            // para comprar cerveza.
            if (tenesDinero3 == true && mayorDeEdad2 == true) // Se ejecuta el código si ambas variables son True; de lo contrario, la condición no se cumple.
            {
                Console.WriteLine("Podes comprar Cerveza 2");
            }

            // este ejemplo es casi igual al anterior pero: En cuanto a la funcionalidad, ambos ejemplos son equivalentes. Sin embargo,
            // es preferible evitar redundancias y expresar las condiciones de manera más concisa, como en el primer ejemplo
            // que proporcionaste.




            //ejemplo 4

            bool tenesDinero4 = true;
            bool mayorDeEdad3 = true;
            // Verifica si el usuario tiene suficiente dinero y es mayor de edad
            // para comprar cerveza.
            if (tenesDinero4 == true || mayorDeEdad3 == true) // Se ejecuta el código si ambas variables son True; de lo contrario, la condición no se cumple.
            {
                Console.WriteLine("Podes comprar Cerveza 3");
            }
            // || se lo llama operador logico OR e indica que una expresion condicional es verdaderia si almenos una de las condiciones se cumple












            //ejemplo 5 IF - ELSE IF - ELSE

            string nombre = "Siri";
            int edad = 18;

            if (nombre == "Siri" && edad == 18)
            {
                Console.WriteLine($"Tu nombre es {nombre} y tu edad es {edad}."); // Interpolación de cadenas
            }
            else if (nombre == "Lina" && edad == 25) // se evalua otra condicion
            {
                Console.WriteLine($"Tu nombre es {nombre} y tu edad es {edad}.");
            }
            else
            {
                Console.WriteLine("otra cosa"); // se ejecuta este bloque si ninguna de las anteriores es verdadera
            }


        }
    }
}
