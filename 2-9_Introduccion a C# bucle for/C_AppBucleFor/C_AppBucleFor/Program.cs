namespace C_AppBucleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             El bucle for al igual que el bucle while nos sirve para repetir tareas,
             
            Tenemos un ejemplo de como recorrer un array con for,
            del mismo modo que con while declaramos una variable i (index) que empieza 
            en 1 por ejemplo, luego debemos ver la condicion para que itere que es
            mientras i < a 6 (i menor a 6 )por ejemplo, y luego sin olvidarnos 
            del incremento ++ .(para que en algun monento deje de cumplirse la condicion 
            y salga del bucle)

            con for es casi lo mismo, veamos el ejemplo:
             */

            string[] amigos = new string[]
            {
                "Pancho",
                "paco",
                "Ludmila",
                "Pricilla",
                "ruben",
                "Carlos"
            };


            // for tiene 3 espacios
            // define la variable i - condicion - incremento (cada seccion separado de Punto y coma ' ; ')
            for(int i = 0; i < amigos.Length ; i++) // recorre hasta el ultimo elemento del array
            {
                Console.WriteLine(amigos[i]);// mostramos el elemento que esta en el array en la posiccion i en cada iteracion empezando de 0 para adelante.
            }





            // DATO
            //un dato es que asi como hay incremento ++, tambien existe el declemento --








            //ejemplo 2 - Es posible agregar mas condiciones para que el bucle itere, como en este caso

            string[] amigos2 = new string[]
{
                "Pancho2",
                "paco2",
                "Ludmila2",
                "Pricilla2",
                "ruben2",
                "Carlos2"
};

            bool run = true;

            // for tiene 3 espacios
            // define la variable i - condicion - incremento (cada seccion separado de Punto y coma ' ; ')
            for (int i = 0; i < amigos2.Length && run; i++) // recorre hasta el ultimo elemento del array y mientras se cumpla la condicion (con && 'AND' las dos propiociciones deben ser true para que se cumpla la condicion)
            {
                Console.WriteLine(amigos2[i]);
            }

        }
    }
}
