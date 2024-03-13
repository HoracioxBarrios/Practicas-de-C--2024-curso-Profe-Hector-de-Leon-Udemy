/*EXPRESIONES LAMBDA
    Las expresiones lambda son funciones anónimas que se pueden usar 
    para crear métodos de manera concisa y sin necesidad de declarar 
    un método formalmente. 
    Permiten definir funciones en línea que pueden ser pasadas como 
    argumentos a métodos o almacenadas en variables.

    Una expresión lambda generalmente se escribe con la sintaxis =>, 
    donde el lado izquierdo especifica los parámetros de entrada (si los hay),
    y el lado derecho especifica la operación o el valor de retorno. Por ejemplo:

    Func<int, int> square = x => x * x;

 */

#region Action
using System.Threading.Channels;

string saludo = "Hola";
Action<string> showMessage = Console.WriteLine;//se asigna un metodo que tiene nombre a la variable

//Ejemplo Multilinea con {}
Action<string, string> showSaludo = (a, b) =>
{
    Console.WriteLine($"{saludo} {a}, {b}");         //se puede acceder a elementos externos en este ejemplo a la var saludo

};//se asigna un metodo que no tiene nombre que usa Console.Wline
showSaludo("Horacio", "Barrios");




//Ejemplo sin las llaves
Action<string, string, string> showSaludo2 = (a, b, c) => Console.WriteLine($"{a}, {b}, {c}");
showSaludo2("Buenas", "Noches", "Pepe");


//Ejemplo 3
MiFuntions.ShowSaludoSuperior("Horacio", "Barrios", a =>  Console.WriteLine($"Soy una expresion Lambda" + a));
#endregion




public static class MiFuntions
{


    //Funcion de orden superior ejemplo

    public static void ShowSaludoSuperior(string name, string lastName, Action<string> fn)
    {
        fn($"Buenas: {name}, {lastName}");
    }
}