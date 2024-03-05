namespace ConsoleApp
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
    1_ Tener la Base de datos con las tablas y relacionadas con primary key - foraight key (al menos algo)
    2_ crear un proyecto de libreria de clases para trabajar, e instalar en ese proyecto las siguiente dependencias:
    3_ sobre dependencias click derecho /administrar paquetes nugets:
    INSTALAR:
    Microsoft.EntityFrameworkCore
    Microsoft.EntityFrameworkCore.SqlServer
    Microsoft.EntityFrameworkCore.Tools
    
    Posicionarse sobre el proyecto de Libreria y seleccionarla, luego ir arriba a -> Herramientas / Adminstrador paquetes NuGets/ Consola de adm de Paquetes
    


 EXPLICACION:   contexto      /    server                 / Db               / User / Pass          / Autenticacion para windows (sino da error ssl de permisos) / el proveeedor sql.
COMANDO PARA LA CONSOLA NUGETS:
PM> Scaffold-DbContext "Server=Hora\SERVER_PRUEBA;Database=CsharpDB; User=sa; Password=123456;TrustServerCertificate=Yes;" Microsoft.EntityFrameworkCore.SqlServer

Esto nos mapea las entidades de la DB en clases C# para poder trabajar.




Si se modifica la db con nuevas tablas y queremos remapear podemos forzar el remapeo:
PM> Scaffold-DbContext "Server=Hora\SERVER_PRUEBA;Database=CsharpDB; User=sa; Password=123456;TrustServerCertificate=Yes;" Microsoft.EntityFrameworkCore.SqlServer -force
(No debe de tener errores el codigo c#, sino no tomará eñ comando)
 */