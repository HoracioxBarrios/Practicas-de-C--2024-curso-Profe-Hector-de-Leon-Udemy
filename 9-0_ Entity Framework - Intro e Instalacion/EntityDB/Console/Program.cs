using System;
namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
/*Paso a Paso para Instalar Entity Framework 
 


comando para la consola de paquetes nugets:
        contexto      /    server                 / Db               / User / Pass          / Autenticacion para windows (sino da error ssl de permisos) / el proveeedor sql.
PM> Scaffold-DbContext "Server=Hora\SERVER_PRUEBA;Database=CsharpDB; User=sa; Password=123456;TrustServerCertificate=Yes;" Microsoft.EntityFrameworkCore.SqlServer
 */