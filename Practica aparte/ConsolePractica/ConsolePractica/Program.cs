using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine(CalcularPotencia(2023, 50));
        System.Console.WriteLine(775149809 * 50);

    }


    static int CalcularPotencia(int numero, int cantidadVeces)
    {
        int resultado = 1; // Inicializa el resultado como 1, ya que es el valor neutro de la multiplicación

        for (int i = 1; i <= cantidadVeces; i++)
        {
            resultado = resultado * numero;
        }
        return resultado;
    }

}


//775149809

//1550299618