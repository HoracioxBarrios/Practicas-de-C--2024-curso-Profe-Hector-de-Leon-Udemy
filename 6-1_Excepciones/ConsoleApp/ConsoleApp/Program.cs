using System.IO; //NOS VA A AYUDAR A LEER ARCHIVOS DE TEXTO

namespace ConsoleApp
{
    internal class Program
    {
        /*
        Las excepciones se utilizan para manejar situaciones excepcionales de manera controlada, 
        permitiendo al programa responder adecuadamente a los problemas y evitar que se produzcan 
        fallos inesperados o la terminación abrupta del programa. En lugar de simplemente detener 
        la ejecución del programa, las excepciones pueden ser capturadas, analizadas y manejadas 
        apropiadamente mediante el uso de bloques try-catch, donde el código dentro del bloque try 
        intenta realizar una operación y el bloque catch captura y maneja cualquier excepción que 
        pueda ocurrir durante la ejecución del código dentro del bloque try. Esto ayuda a mantener 
        la robustez y la estabilidad del software.*/

        /*

        Algunas aclaraciones y ampliaciones:

        * Acceso a Base de Datos caída o sin conexión: Cuando un programa intenta 
        acceder a una base de datos que está caída o sin conexión, puede lanzar 
        una excepción que el código debe manejar apropiadamente para informar al 
        usuario o realizar acciones alternativas.

        * Acceso a un archivo que no existe: Si un programa intenta acceder a un 
        archivo que no existe en el sistema de archivos, puede generar una excepción
        que necesita ser manejada para evitar que el programa falle inesperadamente.

        * Servicio caído: Similar al acceso a la base de datos, si un servicio al que 
        el programa intenta acceder está caído o no está disponible, esto puede 
        desencadenar una excepción que debe ser manejada.

        * Lectura de un dato que no está en el tipo de dato esperado: Si un programa 
        intenta leer un dato que no está en el formato o tipo de dato esperado, 
        puede lanzar una excepción de tipo de datos incorrecto que necesita ser 
        manejada para evitar errores de ejecución.

        Mala validación: Si una validación no se realiza correctamente o no se 
        cumplen ciertas condiciones esperadas, puede ser necesario lanzar una 
        excepción para indicar que algo inesperado ha ocurrido.
        */
        static void Main(string[] args)
        {
            string content = File.ReadAllText(@"C:\\Users\\Orfhen2022\\Desktop\\Practicas-de-C--2024-curso-Profe-Hector-de-Leon-Udemy\\6-1_Excepciones\\prueba_texto_1.txt");
            Console.WriteLine(content);



            //SI NO EXISTE EL ARCHIVO
            //string content2 = File.ReadAllText(@"C:\\Users\\Orfhen2022\\Desktop\\Practicas-de-C--2024-curso-Profe-Hector-de-Leon-Udemy\\6-1_Excepciones\\prueba_texto_2.txt");
            //Console.WriteLine(content2);

            /*Unhandled exception. System.IO.FileNotFoundException: Could not find file 'C:\Users\Orfhen2022\Desktop\Practicas-de-C--2024-curso-Profe-Hector-de-Leon-Udemy\6-1_Excepciones\prueba_texto_2.txt'.
            File name: 'C:\Users\Orfhen2022\Desktop\Practicas-de-C--2024-curso-Profe-Hector-de-Leon-Udemy\6-1_Excepciones\prueba_texto_2.txt'
                at Microsoft.Win32.SafeHandles.SafeFileHandle.CreateFile(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options)
                at Microsoft.Win32.SafeHandles.SafeFileHandle.Open(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
                at System.IO.Strategies.OSFileStreamStrategy..ctor(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
                at System.IO.Strategies.FileStreamHelpers.ChooseStrategyCore(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
                at System.IO.StreamReader.ValidateArgsAndOpenPath(String path, Encoding encoding, Int32 bufferSize)
                at System.IO.File.ReadAllText(String path, Encoding encoding)
                at ConsoleApp.Program.Main(String[] args) in C:\Users\Orfhen2022\Desktop\Practicas-de-C--2024-curso-Profe-Hector-de-Leon-Udemy\6-1_Excepciones\ConsoleApp\ConsoleApp\Program.cs:line 48*/





            // USO DE EXCEPTION
            try
            {   //ReadAllText tiene su propio manejo de excepciones

                string content3 = File.ReadAllText(@"C:\\Users\\Orfhen2022\\Desktop\\Practicas-de-C--2024-curso-Profe-Hector-de-Leon-Udemy\\6-1_Excepciones\\prueba_texto_3.txt");
                Console.WriteLine(content3);

                //Se puede lanzar excepciones voluntariamente si se desea de esta forma:
                //throw new Exception("Ocurrio algo raro");//al comentar el error de arriba se lanza este en el catch de abajo
            }
            catch (FileNotFoundException ex)// definimos que tipo de excepcion es. o se puede hacer escribindo Excepction en lugar de: FileNotFoundException perocombiene ACLARAR
            {
                Console.WriteLine("El archivo no Existe");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); // sale un mensaje predeterminado (si salta este primero o si muevo este cw al catch de arriba)
            }
            finally // PASE LO QUE PASE SIEMPRE SE VA A EJECUTAR
            {
                Console.WriteLine("ejemplo: Close archivo o cierro la conexion");
            }
            Console.WriteLine("Aqui se sigue ejecutando");
        }
    }
}
