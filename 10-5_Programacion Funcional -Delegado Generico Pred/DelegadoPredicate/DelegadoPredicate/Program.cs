/*DELEGADO GENERICO PREDICATE
 En C#, el delegado genérico Predicate se utiliza comúnmente para representar 
un método que realiza una prueba en un objeto de tipo especificado y devuelve 
un valor booleano que indica si la condición se cumple o no. 
El delegado Predicate está definido en el espacio de nombres System y 
tiene la siguiente firma:

public delegate bool Predicate<in T>(T obj);

 */


#region Predicate
List<string> palabras = new List<string>()
{
    "Cerveza",
    "Patito",
    "Sandia",
    "Hola Mundo",
    "C#"
};



//retorna un bool
Predicate<string> tieneEspacio = (palabra) => palabra.Contains(" "); //con expresion lambda

Predicate<string> tieneEspacioOLetraA = (palabra) =>
{
    return palabra.Contains(" ") || palabra.ToUpper().Contains("A");
};

Console.WriteLine(tieneEspacio("Hola Mundo")); //True

Console.WriteLine(tieneEspacio("Beer"));//False


Console.WriteLine(tieneEspacioOLetraA("Alergia")); //True





//FindAll recibe un predicate de string y devuelve una lista con los match
//List<string> nuevaListaPalabras = palabras.FindAll(tieneEspacioOLetraA);

//Si queremos negar no sirve asi:
//List<string> nuevaListaPalabras = palabras.FindAll(!tieneEspacioOLetraA);
//si noque hay que hacerlo asi:
//List<string> nuevaListaPalabras = palabras.FindAll((w) => !tieneEspacioOLetraA(w));
List<string> nuevaListaPalabras = palabras.FindAll( w => !tieneEspacioOLetraA(w)); // con un solo prametro se puede sin prentesis
foreach (string palabra in nuevaListaPalabras)
{
    Console.WriteLine($"De la nueva Lista: {palabra}");
}
#endregion



//La definicion del delegado es asi dentro de system o parecido.
delegate int Operation(int a, int b);