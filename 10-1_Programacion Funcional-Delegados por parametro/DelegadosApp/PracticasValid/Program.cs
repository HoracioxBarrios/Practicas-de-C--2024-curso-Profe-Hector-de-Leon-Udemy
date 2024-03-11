
//funcionalidad para poder Vilidar: 
//poder pasarle un string y validar con distintos criterios.
//Ejemplo: Juan -> valida(que no tenga numeros) y validar(que el min Lenght sea 3);




//MulticastDelegate fn = Validar.ValidarTodo;


using System.ComponentModel.DataAnnotations;

Validator? soloStringDelegate = Validar.NoNumeros;
soloStringDelegate += Validar.NoSimbolos;

Validator2Items soloLenghtDelegate = Validar.MaxLenght;
Validator2Items soloLenghtDelegate2 = Validar.MinLenght;

string nombre = "Juan";

var res = 
    Validar.ValidarSoloConString(nombre, soloStringDelegate) && 
    Validar.ValidarMaxLen(nombre, 10, soloLenghtDelegate) && 
    Validar.ValidarMinLen(nombre, 3, soloLenghtDelegate2);

Console.WriteLine(res);

public delegate bool Validator(string str);
public delegate bool Validator2Items(string str, int valor);


public delegate bool MultiValiddor(string str, Validator validator);


public static class Validar
{

    public static bool NoNumeros(string str)
    {
        return true;
    }

    public static bool NoSimbolos(string str)
    {
        return true;
    }

    public static bool MinLenght(string str, int minL)
    {
        return true;
    }

    public static bool MaxLenght(string str, int maxL)
    {
        return true;
    }

    public static bool ValidarSoloConString(string str, Validator val)
    {

        return val(str);
    }


    public static bool ValidarMinLen(string str, int min, Validator2Items val)
    {
        //logica para min
        return val(str, min);
    }

    public static bool ValidarMaxLen(string str, int max, Validator2Items val)// solo min o solo max
    {
        //logica pára max
        return val(str, max);
    }



}








