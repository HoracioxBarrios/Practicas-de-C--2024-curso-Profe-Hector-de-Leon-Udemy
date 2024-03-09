using EntityDB;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EN la Class CSharpDbContext entity framework nos Generó la string connection, pero donde lo puso no es seguro. Por lo tanto lo sacamos de ahi(lo ideal es leerlo de un archivo de configuracion para no dejarlo tan expuesto).
            DbContextOptionsBuilder<CsharpDbContext> optionsBuilder = new DbContextOptionsBuilder<CsharpDbContext> ();// le pasamos en Generic el DbContext que nos generó Ent. Framework
            optionsBuilder.UseSqlServer("Server=Hora\\SERVER_PRUEBA;Database=CsharpDB; User=sa; Password=123456;TrustServerCertificate=Yes;");

            bool again = true;
            int operacion = 0;

            do
            {
                ShowMenu();
                Console.WriteLine("Elige una Opcion");
                operacion = int.Parse(Console.ReadLine());

                switch(operacion)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        again = false;
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;

                }

            } while (again);











            //Db context con using EJEMPLO
            //using (CsharpDbContext context = new CsharpDbContext(optionsBuilder.Options)) //usamos la Property Options
            //{
            //    List<Beer> listBeers = context.Beers.ToList();

            //    foreach (Beer beer in listBeers)
            //    {
            //        Console.WriteLine(beer.Name);
            //    };
            //}
            


            //SIN USING 1:
            //Ejemplo con el tipo de dato especifico por mí
            //CsharpDbContext context = new CsharpDbContext();
            //List<Beer> listBeers = context.Beers.ToList();

            //foreach(Beer beer in listBeers)
            //{
            //    Console.WriteLine(beer.Name);
            //}




            //SIN USING 2
            //El ejemplo como lo da el profe es así:
            /*
            CsharpDbContext context = new CsharpDbContext();
            var listBeers = context.Beers.ToList();

            foreach (var beer in listBeers)
            {
                Console.WriteLine(beer.Name);
            }
            */


            //CIERRE CON Dispose() O EL USO DE using: 
            /*En SQL cuando haciamos el connect a la db, teniamos que abrirla y luego cerrarla.
            En entity framework hay que hacer algo parecido, usando el Dispose() para cerrar la conexion.EJEMPLO:
            context.Dispose();

            Podemos cerrar correctamente el contexto de la base 
            de datos, ya sea mediante el uso de Dispose() explícitamente 
            o utilizando la declaración using, que implementa la interfaz 
            IDisposable y garantiza que el contexto se cierre correctamente 
            al salir del bloque using de forma implicita.
            
             */
        }
        
        public static void ShowMenu()
        {
            Console.WriteLine("\n ------ Menú ------");
            Console.WriteLine("1.- Mostrar");
            Console.WriteLine("2.- Agregar");
            Console.WriteLine("3.- Editar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Salir");
        }

        public static void Show(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("-Cervezas en la Base de Datos");

            using (var context = new CsharpDbContext(optionsBuilder.Options))
            {
                //List<Beer> beers = context.Beers.ToList();//esta en este tipo:  DbSet<Beer> , por eso lo parseamos a List<> aclarando el tipo de dato de la coleccion.
                // LINQ utilizando el método OrderBy y Lambda - formato con metodos
                List<Beer> beers = context.Beers.OrderBy(b =>  b.Name).ToList(); //Ordenamos y luego parseamos a List<>

                // Equivalente utilizando LINQ en formato de consulta
                List<Beer> beers2LinQ = (from b in context.Beers
                                         where b.BrandId == 2
                                         orderby b.Name
                                         select b).Include(b => b.Brand).ToList();//Include nos trae informacion de la entidad Brand

                foreach (Beer beer in beers)
                {
                    Console.WriteLine($"Id: {beer.Id}, Nombre: {beer.Name}");
                }


                //foreach (Beer beer in beers2LinQ)
                //{
                //    Console.WriteLine($"Id: {beer.Id}, Nombre: {beer.Name}, BrandID: {beer.BrandId}, BrandName: {beer.Brand.Name}");
                //}
            }
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