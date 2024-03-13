// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejemplo de Delegado Action \n");






#region Action

Action<string> showMessage = Console.WriteLine;// agrega cuanto parametro va a recibir asi: Action<string, string, string> showMessage = Console.WriteLine;

showMessage("aca usando el delegado simplemente");//lo podemos usar asi:


// o Lo podemos pasar a otra funcion de orden superior
Funtions.HacerAlgoAction("Hora", "Barrios", showMessage);
#endregion




#region Delegados

public delegate void Show(string message);
public delegate void Show2(string message, string message2);
public delegate void Show3(string message, string message2, string message3);
public delegate void Show4(string message, string message2, string message3, string message4);

#endregion




public class Funtions
{
    
    //FUNCION DE ORDEN SUPERIOR
    public static void HacerAlgo(string name, string LastName, Show fn)
    {
        Console.WriteLine("Hacer algo al principio");
        fn($"Hola {name} {LastName}");
        Console.WriteLine("Hacer algo al final");
    }
    //podemos recibir un Action del mismo modo
    public static void HacerAlgoAction(string name, string LastName, Action<string> fn)
    {
        Console.WriteLine("Hacer algo al principio");
        fn($"Hola {name} {LastName}");
        Console.WriteLine("Hacer algo al final");
    }
}