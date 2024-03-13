/*
    PARADIGMA FUNCIONAL:
    * Funciones de Primer Orden:
    En C#, las funciones de primer orden se refieren a funciones que pueden 
    ser tratadas como cualquier otro tipo de dato. Esto significa que pueden 
    ser pasadas como argumentos a otras funciones, devueltas como resultados 
    de otras funciones y asignadas a variables.

    * Funciones de Orden Superior:
    Las funciones de orden superior en C# son aquellas que toman una o más funciones 
    como argumentos y/o devuelven una función como resultado.
    (En resumen son Funciones que PUEDEN RECIBIR OTRAS FUNCIONES POR PARAMETRO (delegados por parametro.))
 */

//Declarcion y Asignacion del Metodo a la variable Delegada
Operation operationMathDelegate = Functions.Sum;
//USO
Console.WriteLine(operationMathDelegate(10, 20));
//RE ASIGNACION
operationMathDelegate = Functions.Mul;
//USO
Console.WriteLine(operationMathDelegate(3, 5));



//ASIGNACION
Show cw = Console.WriteLine;
//USO
//cw("Mensaje con el metodo ConsoleWriteLine solo");

//Una VARIBLE DELEGADA PUEDE TENER UN METODO ASOCIADO O MAS....
cw += Functions.ConsoleShow; //Se Acumula el nuevo metodo a la variable Delegada

/*
    En esencia, cuando usas el operador += con delegados en C#, estás agregando un 
    método a la lista de métodos que la variable delegada puede invocar. En otras 
    palabras, la variable delegada actúa como una lista de métodos.(NO ES UNA LISTA) 
    La forma de obtener una lista de delegados es por ejemplo:
    Delegate[] invocationList = cw.GetInvocationList();
 */

//Console.WriteLine(cw.GetInvocationList().ToList()); //ARRAY PARSEADO A LIST



//USO
//CONCEPTO DE MULTI DIFUSION (Cuando se ejecuta La variable Delegada (SE EJECUTAN en secuencia TODOS LO METODOS QUE TIENE DENTRO))

//cw("Mensaje Multi difusion con los dos metodos dentro de cw"); //Cuando ejecuta, se le pasa el string por parametro a las dos funciones a las que esta referencia la variable. Y SE EJECUTAN LOS DOS METODOS!



Functions.HacerAlgo("Hora", "Barrios", cw);






//DEFINICION del Tipo ( El metodo debe respetar la estructura del delegado)
public delegate int Operation(int a, int b);
public delegate void Show(string message);





public static class Functions
{
    //FUNCIONES DE PRIMER ORDEN
    public static int Sum(int x, int y) => x + y;

    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ConsoleShow(string m ) => Console.WriteLine(m.ToUpper()); //.upper para diferenciarla

    //FUNCION DE ORDEN SUPERIOR
    public static void HacerAlgo(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola: {name} {lastName}");
        Console.WriteLine("Hago algo al Final"); // se le llama callback,a la ejecucion de algo posterior a cuando la funcion en si ya ha terminado su ejecucion.(se puede hacer que la fn pasada por parametro se ejecute en algun punto) se suele usar con metodos asyncronos
    }
}