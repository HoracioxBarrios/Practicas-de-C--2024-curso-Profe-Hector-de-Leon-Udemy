/*
    En C#, un delegado genérico Func es una clase predefinida que 
    encapsula un método que devuelve un valor y puede aceptar de 1 
    hasta 16 parámetros de entrada genéricos. La sintaxis básica 
    de un delegado Func es la siguiente:
    
    FIRMA DEL DELEGADO
                // Declarar un delegado Func<int, bool> que representa un método que toma un entero y devuelve un booleano.
    Func<int, bool> esParDelegado = EsPar;
     
                // Llamar al delegado con un entero y mostrar el resultado.
    int numero = 6;
    bool resultado = esParDelegado(numero);
    
    Console.WriteLine($"¿Es {numero} un número par?: {resultado}"); //True




               // Método que corresponde a la firma requerida por el delegado Func<int, bool>.
    static bool EsPar(int num)
    {
        return num % 2 == 0;
    }
 */

#region Func
//EJEMPLO QUE NO RECIBE ARGUMENTOS (si o si debe retornar algo)
//Func debe regresar algo (debe tener un tipo de retorno)
Func<int> numberRamdom = () => new Random().Next(0, 100); //retorn int


Console.WriteLine(numberRamdom());


//EJEMPLO QUE RECIBE ARGUMENTOS (si o si debe retornar algo)
int numeroLimit = 1000;
// Func<Recibe, Retorna>
/*Func<int, int> numberRamdonLimit = (limit) => new Random().Next(0, limit);*/ //en una linea no usar return

Func<int, int> numberRamdonLimit = (limit) =>
{
    return new Random().Next(0, limit);
};//en multilinea con {} hay que usar la palabra return

Console.WriteLine(numberRamdonLimit(numeroLimit));
#endregion