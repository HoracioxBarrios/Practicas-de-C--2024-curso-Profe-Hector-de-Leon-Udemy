using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    //BeerDB es el servicio que va a Gestionar las Beers en la DB
    public class BeerDB : DB
    {
        
        public BeerDB(string server, string db, string user, string pass) : 
            base(server, db, user, pass)
        {
            /*
             Los valores de server, db, user, pass se manejan en la clase base.
             El constructor del padre hace la tarea del conection string.
             Nosotros necesitamos el obj que tiene la conexion.
             */
        }
        //Método que nos regrese una lista de Beers en base a los datos de la Base de datos.

        public List<Beer> GetAll()
        {
            base.Connect();
            List<Beer> listBeer = new List<Beer>();
            string query = "SELECT Id, Name, BrandId FROM BEER"; //consulta
            SqlCommand command = new SqlCommand(query, _connection); //SqlCommand va a mandar comandos a la db, en este caso la consulta (query) ---- SqlComand espera la consulta, y la conexion (que la tenemos creada en la clase Padre DB como protected _connection) la clase derivada puede hacer uso de los atribut protected, pero no de lo private que es de propio de la Clase
            //Necesitamos ahora ejecutar ese comando
            SqlDataReader reader = command.ExecuteReader(); //ExecuteReader() devuelve un tipo SqlDataReader que es en si la informacion conseguida de la base de datos, pero necesitamos tratar los datos del siguiente modo, para que este metodo devuelve la lista de cervezas.

            //vamos a leer el reader siempre que haya algo por leer, o siempre que exista una fila.
            while(reader.Read())
            {
                int id = reader.GetInt32(0);// primer elemento es la id
                string name = reader.GetString(1);//segundo elemento es el name
                int brandId = reader.GetInt32(2);
                listBeer.Add(new Beer(id, name, brandId));// creamos la Cerveza y la Guardamos a la Lista
            }


            base.Close();
            return listBeer;
        }


        //INSERT EN DB
        public void Add(Beer beer)
        {
            Connect();
            string query = "INSERT INTO Beer(Name, BrandId) " + //ojo el espacio despues de BrandId
                "VALUES(@name, @brandId) "; // No le pasamos beer.Name, o beer.BrandId porque puede ser peligroso por la inyeccion de SQL, sino que le pasamos un alias con el @
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();

            Close();
        }

    }
}
