using System.Data.SqlClient;

namespace Libreria
{
    public class DB // despues la vamos a hacer abtracta
    {
        private string _connectionString;
        protected SqlConnection _connection; // SqlConnection (Acciones rapidas e instalar libreria SqlClient)
                                            //Solo queda definidio: _connection



        public DB(string server, string baseDatos, string user, string password)
        {
            _connectionString = $"Data Source={server}; Initial Catalog={baseDatos};" + $"User={user}; Password={password}"; 
        }





        //MÉTODO QUE VA A HACER LA CONEXION
        public void Connect()
        {
            _connection = new SqlConnection(_connectionString); //Instancia la conecion
            _connection.Open();
            Console.WriteLine("Se abrio la conexion");
        }


        // MÉTODO PARA CERRAR LA CONEXION 
        public void Close()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open) // protejemos el close() si _conection no es null y si el estado es open, podemos cerrar porque está abierto.
            {
                _connection.Close();
                Console.WriteLine("Se cerro la conexion");
            }
        }

    }
}
