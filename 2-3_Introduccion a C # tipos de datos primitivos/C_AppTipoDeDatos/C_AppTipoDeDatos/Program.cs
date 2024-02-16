namespace C_AppTipoDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // >>>>>>>>>>>>>>>>>>>>>>>>>>> Tipos de datos primitivos: <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


            //ENTERO
            int numeroEntero = 12; // Entero es aquel numero que no tiene parte decimal.
                                   //el subrayado verde indica que es una variable que no se esta utulizando.

            // (((( NO se puede guardar en la variable otro tipo de dato distinto al declarado.))))






            // DECIMALES >>>>>> FLOAT, DOUBLE, DECIMAL

            float numeroFlotante = 1.0f;
            /*float: Este tipo de datos representa números decimales de PRECISION SIMPLE. Se debe agregar 
             el sufijo f al final del número para indicar que es un literal de tipo float.*/



            double numeroDoble = 1.0;
            /*double: Este tipo de datos representa números decimales de precisión doble. Es el tipo de datos 
              predeterminado para valores decimales en C#.
              
             La precisión double permite representar una gama más amplia de valores decimales con mayor exactitud 
            que float. Sin embargo, es importante tener en cuenta que la precisión double no significa que los 
            cálculos sean exactos en todo momento
             */


            decimal precioProducto = 19.99m;
            // decimal precioProducto2 = 19.98; el compilador no imfiere que el tipo sea decimal sin el sufijo m por esto da error!


            /*decimal es más preciso que float y double, especialmente para cálculos que involucran división y multiplicación de números decimales.
            
            
            El tipo de dato decimal en C# es un tipo numérico que se utiliza para representar números decimales con una precisión muy alta. 
            A diferencia de float y double, que utilizan representaciones en punto flotante binario, decimal utiliza una representación 
            en punto flotante decimal. Esto significa que decimal puede representar números decimales con una precisión exacta.

            características:

            *Precisión exacta: decimal es más preciso que float y double, especialmente para cálculos que involucran división y 
            multiplicación de números decimales.

            *Rango más limitado: Aunque decimal ofrece una precisión alta, tiene un rango más limitado en comparación con double. 
            

            Uso común en aplicaciones financieras: Debido a su precisión exacta, el tipo de dato decimal es comúnmente utilizado 
            en aplicaciones financieras donde la precisión decimal es crucial, como cálculos de moneda, impuestos, presupuestos, etc.

            Declaración: Para declarar una variable de tipo decimal, se utiliza la palabra clave decimal, seguida del nombre de 
            la variable y, opcionalmente, su valor inicial.
             
            */







            //CARACTER O CADENA DE CARACTERES: CHAR O  STRING

            char letra = 'a'; // para representar un caracter se debe encerrar con comilla simple - UN CARACTER PUEDE SER UNA LETRA, O NUMERO, ETC


            string palabra = "palabra _@54545dfdf'?/%5555sss sd"; // Se usa comillas dobles





            //BOOLEAN TRUE O FALSE (verdadero o falso)
            bool bolean = true;
            bool bolean2 = false;


            




        }
    }
}
