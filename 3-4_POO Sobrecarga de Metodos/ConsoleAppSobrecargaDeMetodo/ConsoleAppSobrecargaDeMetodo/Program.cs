namespace ConsoleAppSobrecargaDeMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase Calculadora
            Math math = new Math();

            // Probamos el método Suma con dos enteros
            Console.WriteLine(math.Sum(5,10));

            // Probamos el método Suma con dos cadenas de texto que representan números
            Console.WriteLine(math.Sum("10","20"));

            // Creamos un array de números enteros
            int[] arrayNumer = new int[] { 10, 20, 20 };

            // Probamos el método Suma con un arreglo de números enteros
            Console.WriteLine(math.Sum(arrayNumer));

        }
    }

    /*SOBRECARGA DE MÉTODOS    
    
    1_ La sobrecarga de métodos en C# permite definir múltiples versiones de un mismo método en 
    una clase, pero con diferentes parámetros. Esto significa que puedes tener métodos con el 
    mismo nombre dentro de una clase, pero que aceptan diferentes tipos de argumentos o un 
    número diferente de argumentos. Esto permite una interfaz más flexible y conveniente para 
    los usuarios de la clase, ya que pueden llamar al mismo método con diferentes tipos de 
    datos según sea necesario.
     

    2_ El retorno no necesariamente debe ser el mismo en los métodos sobrecargados en C#. 
    Puedes tener métodos con el mismo nombre y diferentes tipos de retorno, siempre y 
    cuando la lista de parámetros sea diferente.

    Ver Ejemplo 2 para esto ultimo.
     */




    public class Math
    {
        // Suma dos números enteros.
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // parsea dos string numericos a enteros  los Suma       
        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        /*
        public string Sum(string a  , string b)
        {
            return $"{a} + {b}";
        }
        */



        // Calcula la suma de todos los números en el arreglo.
        public int Sum(int[] arrayMumbers)
        {
            int result = 0;
            int i = 0;

            while(i < arrayMumbers.Length)
            {
                result += arrayMumbers[i];
                i++;
            }
            return result;
        }



    }

    //Ejemplo 2
    /*
     DIFERENTE RETORNO, DIFERENTES CONJUNTOS DE ARGUMENTOS
     
     */
    public class Ejemplo
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public string SumarComoCadena(int a, int b)
        {
            return (a + b).ToString();
        }
    }



    /*
     POLIMORFISMO:
        En C#, la sobrecarga de métodos es un tipo de polimorfismo conocido como 
        polimorfismo de sobrecarga. El polimorfismo, en términos generales, se refiere 
        a la capacidad de los objetos de tomar muchas formas y comportamientos.
        

        La sobrecarga de métodos y la sobrecarga de Operadores en C# es un ejemplo de polimorfismo en tiempo de COMPILACION.
        Esto significa que el compilador decide qué versión del método sobrecargado o del operador sobrecargado se va a 
        utilizar en función de los tipos de los argumentos que se pasan al método o al operador durante la compilación del código.



    En el siguiente tema hay otro ejemplo de otro tipo de Polimorfismo...
     
     
     */
}
