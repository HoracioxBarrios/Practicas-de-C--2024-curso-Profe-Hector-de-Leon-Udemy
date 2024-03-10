// See https://aka.ms/new-console-template for more information //NO USAR INSTRUCCIONES DE NIVEL SUPERIOR (Destildado)




// Introducción a la programación funcional
// DELEGADOS en C#

/*
Al crear un delegado en C#, estamos creando un tipo de dato que representa funciones.
En otras palabras, estamos tipificando las funciones para que los métodos que compartan
la misma firma (misma salida o mismos parámetros) cumplan con este tipo.

Los delegados en C# actúan como punteros seguros a funciones, permitiendo la
implementación de programación funcional en el lenguaje. Son esenciales para
el manejo de eventos, callbacks y programación asincrónica.

Un delegado define la firma de un método al que puede hacer referencia, lo que
permite a otras partes del código invocar el método sin necesidad de conocer
su implementación concreta.

Ejemplo básico de declaración y uso de un delegado en C#:

delegate void MiDelegado(int x, int y);

class Program
{
    static void Main(string[] args)
    {
        // Creación de una instancia del delegado y asociación con un método
        MiDelegado delegado = SumarNumeros;

        // Invocación del método a través del delegado
        delegado(3, 5); // Salida: 8
    }

    // Método que cumple con la firma del delegado
    static void SumarNumeros(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}
*/
/*
     Al crear un delegado en C#, estamos creando un tipo de dato que representa funciones.
     En otras palabras, estamos tipificando las funciones para que los métodos que compartan
     la misma firma (misma salida o mismos parámetros) cumplan con este tipo.
*/



// -------- Declaración de delegados arriba -----------:

OperacionDelegate miOperacionMatematicaDelegate = MisFunciones.Suma; // Declaramos una variable que tendrá este TIPO
// Uso:
Console.WriteLine(miOperacionMatematicaDelegate(20, 10));
// Asignamos otro método que cumpla con la misma firma a la misma variable del Tipo OperacionDelegate
miOperacionMatematicaDelegate = MisFunciones.Multiplicacion;
// Uso:
Console.WriteLine(miOperacionMatematicaDelegate(3, 5));





ShowDelegate mostrarDelegate = MisFunciones.ConsoleShow;
mostrarDelegate("Mostramos este Mensaje!!!");

// Podríamos asignar UN METODO QUE YA EXISTE DE ESTA FORMA:
ShowDelegate mostrarDelegate2 = Console.WriteLine;
mostrarDelegate2("Mostramos este Mensaje 2!!!"); // Invocación del Método en el delegado










// --------- Definiciones abajo ---------:

// Es una práctica común y útil incluir la palabra "Delegate" en el nombre de los delegados en C#. Esto ayuda a clarificar su propósito y a distinguirlos de otros tipos de métodos o clases.
public delegate int OperacionDelegate(int a, int b); // Firma del delegado

public delegate void ShowDelegate(string message);








//Una Class con Metodos
public static class MisFunciones
{
    //public static int Sum(int x, int y)
    //{
    //    return x + y;
    //}
    // Se puede reemplazar por el de abajo:
    public static int Suma(int x, int y) => x + y; // La flecha (=>) en esta expresión lambda indica que se retorna la suma de dos enteros. (Aclaración: La flecha no es un return, ya que si se pasara un Console.WriteLine("Hola"); lo imprimiría simplemente)
    public static int Multiplicacion(int num1, int num2) => num1 * num2;


    public static void ConsoleShow(string mensaje) => Console.WriteLine(mensaje);
}


