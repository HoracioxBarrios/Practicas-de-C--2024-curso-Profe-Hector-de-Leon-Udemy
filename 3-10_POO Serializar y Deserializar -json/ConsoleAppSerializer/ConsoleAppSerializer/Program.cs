using System.Text.Json; //esta directiva para poder hacer uso de la class JsonSerializer
namespace ConsoleAppSerializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               SERIALIZAR: es convertir un objeto a formato JSON,
               que en fin un string con estructura JSON.
            */

            Beer mybeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Eringer"
            };

            //string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Eringer\"}";

            /*Para No tener que hacer esto a mano,
             ya existe un metodo que lo hace por nosotros:*/

            string json = JsonSerializer.Serialize(mybeer); 
            Console.WriteLine(json);// nos da el mismo resultado



            /*
                DESSERIALIZAR: es convertir un JSON a un objeto
            */
            Beer beer = JsonSerializer.Deserialize<Beer>(json); // Deserialize<> :usa generic y hay que aclararle el tipo que va a devolver, en este caso Beer


            //EJEMPLO 2 con un array de Objetos, en este caso de Cervezas

            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                    Name = "Pikantus",
                    Brand = "Erdinger"
                },
                new Beer()
                {
                    Name = "Corona",
                    Brand = "Modelo"
                }

            };
            // SERIALIZAR
            string json2 = JsonSerializer.Serialize(beers);
            Console.WriteLine(json2);



            //DESEREALIZAR 
            Beer[] arrayBeers = JsonSerializer.Deserialize<Beer[]>(json2);

            foreach (Beer beer1 in arrayBeers)
            {
                Console.WriteLine($"Name: {beer1.Name}, Brand: {beer1.Brand}");
                Console.WriteLine(beer1.ToString()); // Podemos sobreescribir el metodo toString en la Class Beer y setear como mostramos el objeto. 
            }



        }
    }



    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Brand: {Brand}"; 
        }
    }
}
