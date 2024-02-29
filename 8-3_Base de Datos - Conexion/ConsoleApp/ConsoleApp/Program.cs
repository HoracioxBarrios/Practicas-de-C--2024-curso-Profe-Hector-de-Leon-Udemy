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
                DB baseDato = new DB(@"HORA\SERVER_PRUEBA", "CsharpDB", "sa", "123456");
                baseDato.Connect();

                // ACA DEBERIA IR LA CONSULTA

                baseDato.Close();

            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error al conectar con la DB");
            }
        }
    }
}
