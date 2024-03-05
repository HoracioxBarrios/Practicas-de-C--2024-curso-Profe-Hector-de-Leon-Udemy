
using Libreria;
using System.Data.SqlClient;
using System.Threading.Channels;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BeerDB beerDB = new BeerDB(@"HORA\SERVER_PRUEBA", "CsharpDB", "sa", "123456");
                bool again = true;
                int op = 0;

                do
                {
                    ShowMenu();
                    
                    op = int.Parse(Console.ReadLine());
                    switch(op)
                    {
                        case 1://Mostrar
                            ShowBeers(beerDB);
                            break;
                        case 2://Agregar
                            AddBeer(beerDB);
                            break;
                        case 3://Editar
                            EditBeer(beerDB);
                            break;
                        case 4://Eliminar
                            break;
                        case 5://Salir
                            again = false;
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            break;

                    }
                } while(again);


                // ACA DEBERIA IR LA CONSULTA


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al conectar con la DB");
            }


        }
        public static void ShowMenu()
        {
            Console.WriteLine("\n --------- MENÚ ---------");
            Console.WriteLine("1. - Mostrar");
            Console.WriteLine("2. - Agregar");
            Console.WriteLine("3. - Editar");
            Console.WriteLine("4. - Eliminar");
            Console.WriteLine("5. - Salir");
            Console.WriteLine("Elige una Opcion: ");
        }

        public static void ShowBeers(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Cervezas Obtenidas de la Base de Datos: \n");
            List<Beer> listBeers = beerDB.GetAll(); //GetAll consulta la db, se trae los datos y devuelve una lista de Cervezas

            foreach (Beer beer in listBeers)
            {
                Console.WriteLine($"Id: {beer.Id}, Name: {beer.Name}");
            }
        }

        public static void AddBeer(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Agregar Nueva Cerveza: \n");
            Console.WriteLine("Escribe el Nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe la ID de la Marca");
            int brandId = int.Parse(Console.ReadLine());
            //Ejemplo sin validador, claramente...

            //Agregar a la DB
            beerDB.Add(new Beer(name, brandId));
        }

        public static void EditBeer(BeerDB beerDB)
        {
            Console.Clear();
            ShowBeers(beerDB);

            Console.WriteLine("Editar Cerveza \n");
            Console.WriteLine("Escribe la Id de la Cerveza a editar: ");
            int id = int.Parse(Console.ReadLine());
            Beer beer = beerDB.GetOne(id);
            if(beer != null)
            {
                Console.WriteLine("Escribe el nuevo nombre de la Cerveza");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe la Brand Id (id de la marca): ");
                int brandId = int.Parse(Console.ReadLine());
                beer.Name = name;
                beer.BrandId = brandId;

                beerDB.Edit(beer); // editamos
                            }
            else
            {
                Console.WriteLine("La Cerveza No existe ");
            }
            
        }
    }
}


/*
 Es importante tener el MOTOR DE LA BASE DE DATOS (Sql server) Inicializado.
supongamos que lo desactivamos en el administrador de tareas de windows,
podemos buscar con la directiva (Servicios) SQL SERVER ej: MISERVER
e iniciar. con el servidor iniciado ya podemos conectarnos con db.Connect()
 */

/*DATO
 En la Db Identity especification es una opcion para decir que se auto incremente.
Identity Seed es el valor que va a ser el inicial cuando se incerte un item.

 con esto corregí un error que se aunto incremento erroneamente la id de la tabla Beer.
 */