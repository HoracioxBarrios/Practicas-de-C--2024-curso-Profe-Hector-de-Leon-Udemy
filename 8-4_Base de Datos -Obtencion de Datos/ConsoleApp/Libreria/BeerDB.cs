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

        //PARA PODER UPDATEAR UNA CERVEZA, NECESITAMOS TRAERLA
        public Beer GetOne(int id)
        {
            Beer beer = null;
            base.Connect();
            string query = "SELECT Id, Name, BrandId FROM BEER " +
                   "WHERE id = @id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                                                  //en el index 0 en la tabla Beer tenemos la id que es (int 32)
                string name = reader.GetString(1); //en el index 1 el Name que es string
                int brandId = reader.GetInt32(2);
                beer = new Beer(id, name, brandId);
            }


            base.Close();
            return beer;
        }

        

        //INSERT EN DB
        public void Add(Beer beer)
        {
            base.Connect();
            string query = "INSERT INTO Beer(Name, BrandId) " + //ojo el espacio despues de BrandId
                "VALUES(@name, @brandId) "; // No le pasamos beer.Name, o beer.BrandId porque puede ser peligroso por la inyeccion de SQL, sino que le pasamos un alias con el @
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();

            base.Close();
        }

        //Teniendo la Cerveza que trajimos usando GetOne podemos updatear
        public void Edit(Beer beer)
        {
            base.Connect();
            string query = "UPDATE beer SET name = @name, brandId = @brandId " +
                "WHERE id = @id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.Parameters.AddWithValue("@id", beer.Id);// le pasamos la id para que sepa cual debe modificar
            command.ExecuteNonQuery();
            base.Close();
        }

        public void Delete(int id)
        {
            base.Connect();
            string query = "DELETE FROM beer WHERE id=@id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            base.Close();
        }

    }
}
