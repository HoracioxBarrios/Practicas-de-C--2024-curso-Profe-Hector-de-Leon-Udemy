

// -------- Declaración de delegados arriba -----------:
OperacionDelegate miOperacionMatematicaDelegate = MisFunciones.Suma;
// Uso:
Console.WriteLine(miOperacionMatematicaDelegate(20, 10));

miOperacionMatematicaDelegate = MisFunciones.Multiplicacion; //Reasignamos
// Uso:
Console.WriteLine(miOperacionMatematicaDelegate(3, 5));





ShowDelegate mostrarDelegate = MisFunciones.ConsoleShow;
mostrarDelegate("Mostramos este Mensaje!!!");

// Podríamos asignar UN METODO QUE YA EXISTE DE ESTA FORMA:
ShowDelegate mostrarDelegate2 = Console.WriteLine;
mostrarDelegate2("Mostramos este Mensaje 2!!!"); // Invocación del Método en el delegado









// --------- Definiciones abajo ---------:
public delegate int OperacionDelegate(int a, int b); // Firma del delegado

public delegate void ShowDelegate(string message);



//Class
public static class MisFunciones
{
    public static int Suma(int x, int y) => x + y; 
    public static int Multiplicacion(int num1, int num2) => num1 * num2;


    public static void ConsoleShow(string mensaje) => Console.WriteLine(mensaje);
}