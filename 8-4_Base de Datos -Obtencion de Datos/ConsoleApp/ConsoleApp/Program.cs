
using Libreria;
using System.Data.SqlClient;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BeerDB beerDB = new BeerDB(@"HORA\SERVER_PRUEBA", "CsharpDB", "sa", "123456");
                // ACA DEBERIA IR LA CONSULTA
                List<Beer> listBeers = beerDB.GetAll(); //GetAll consulta la db, se trae los datos y devuelve una lista de Cervezas

                foreach (Beer beer in listBeers)
                {
                    Console.WriteLine(beer);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al conectar con la DB");
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