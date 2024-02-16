namespace C_App_while_doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Estructura de control iterativa While

            /*
             
             En C#, while es una estructura de control de bucle que permite ejecutar repetidamente 
            un bloque de código mientras se cumpla una condición especificada. La sintaxis básica de 
            while en C# es la siguiente:

          
            while (condición)
            {
                // Bloque de código a ejecutar mientras la condición sea verdadera
            }
             */

            int contador = 0;

            while(contador < 10)
            {
                //Console.WriteLine("iteracion numero "+ contador); // forma basica de concatenar cadena
                Console.WriteLine($"iteracion numero contador {contador}" ); // Mejor usamos interpolacion de cadenas y mostramos el valor de contador en cada iteracion


                //contador = contador + 1; // abajo la forma de resumir este incremento
                contador++;    // si no incrementamos el contador, nunca se va a dejar de cumplir la condicion y esto seria un BUCLE INFINITO
            }
            // se repite 10 veces







            //Ejemplo de como romper el bucle en base a una condicion

            int contador2 = 0;

            while (contador2 < 100)
            {
                if (contador2 == 10)
                {
                    break;// corta la iteracion del bucle mas proximo
                }
                Console.WriteLine($"iteracion de numero contador 2 { contador2}");
                contador2++;
            
            }





            //Ejemplo recorriendo un Array usando while y un indice inicializado en 0
                        
            string[] amigos = new string[6]       
            {
                "Panchi",
                "Paco",
                "Ana",
                "Ruben",
                "Lilia",
                "Luis"
            };


            int index = 0;


            while (index < amigos.Length)//El bucle while se ejecuta mientras index sea menor que la longitud del array amigos.
            {
                Console.WriteLine($"los amigos que estan en el array son {amigos[index]}");// muestra el amigo en la posicion 0, luego el de la posicion 1 , etc
                index++; // incremento
            }














            //Ejemplo de Do While (la diferencia radica en que va a iterar al menos la primera vez) y luego verifica si la condicion del while se cumple para continuar iterando

            string[] amigos2 = new string[6]
{
                "Panchi2",
                "Paco2",
                "Ana2",
                "Ruben2",
                "Lilia2",
                "Luis2"
};


            int index2 = 0;

            do
            {
                Console.WriteLine($"los amigos que estan en el array 2 son {amigos2[index2]}");// muestra el amigo en la posicion 0, luego el de la posicion 1 , etc
                index2++; // incremento
            }
            while (index2 < amigos2.Length);//El bucle while se ejecuta mientras index sea menor que la longitud del array amigos.




        }
    }
}
