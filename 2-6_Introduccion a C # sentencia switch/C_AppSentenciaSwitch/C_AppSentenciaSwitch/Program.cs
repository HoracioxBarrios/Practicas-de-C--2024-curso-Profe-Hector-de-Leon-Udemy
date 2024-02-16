namespace C_AppSentenciaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 2;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("seleccionaste la opcion 1");
                    break;  // la instrucción break se utiliza para marcar el final del bloque de código asociado a un caso particular
                case 2:
                    Console.WriteLine("seleccionaste la opcion 2");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("seleccionaste la opcion 3, 4, 5");  // se puede agrupar varios casos
                    break;
                default:
                    Console.WriteLine("Opcion invalida!");
                    break;  //especifica el bloque de código que se ejecutará si ninguno de los casos coincide con el valor de la expresión evaluada en el switch.
            }





            /*

             "Con el switch, evaluamos casos según el valor de
            la variable que estamos analizando. Esto significa 
            que podemos comparar el valor de una variable con 
            múltiples opciones y ejecutar un bloque de código 
            específico dependiendo de cuál sea la coincidencia. 
            Es una estructura de control útil para tomar decisiones
            basadas en el valor de una expresión."


















            --------------------------------------------------------------------------------

            *El profesor explica que se puede hacer lo del ejemplo de abajo, aunque en la UTN 
            nos recomiendan no hacer comparaciones en los case.




            NO ESTA PERMITIDO USAR OPERADORES LOGICOS Y DE COMPARACION EN UN SWITCH:
            Chat GPT:
            En C#, el uso de operadores de comparación y operadores lógicos 
            como parte de los casos en un bloque switch no está permitido. Los casos 
            en un switch están diseñados para comparar valores específicos, no para 
            realizar evaluaciones complejas que incluyan operadores de comparación o lógicos.
             */







            // NO SE RECOMIENDA DE NINGUNA MANERA USAR OPERADOR DE COMPARACION U OPERADOR LOGICO EN UN SWITCH.(Mal ejemplo del profesor De Leon)
            int opcion2 = 4;

            switch (opcion2)
            {
                case 1:
                    Console.WriteLine("seleccionaste la opcion 1");
                    break;  
                case 2:
                    Console.WriteLine("seleccionaste la opcion 2");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("seleccionaste la opcion 3, 4, 5");  
                    break;
                case < 0: //operador de comparacion menor que
                case > 100://operador de comparacion mayor que
                    Console.WriteLine("FUERA DE RANGO");
                    break;
                case > 5 and < 10: // usa and y or (no se usa && y || )
                    Console.WriteLine("SELECCIONASTE UNA OPCION ENTRE 6 Y 9");
                    break;
                default:
                    Console.WriteLine("Opcion invalida!");
                    break;  
            }


        }
    }
}
