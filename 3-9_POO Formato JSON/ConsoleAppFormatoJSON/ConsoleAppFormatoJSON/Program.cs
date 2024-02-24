

using System.Text;
using System.Timers;

namespace ConsoleAppFormatoJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* La idea del JSON es que sea un formato de datos independiente de los lenguajes de programación,
               lo que permite que la información estructurada pueda ser compartida y entendida entre diferentes sistemas.
               Por ejemplo, si generamos un JSON en C#, otros lenguajes como Java o JavaScript pueden interpretarlo
               correctamente sin importar las diferencias en la sintaxis y las estructuras de datos. 
            */


            //ejemplo 1:json puede representar objetos
            Cerveza miCerveza = new Cerveza()
            {
                Nombre = "Suave",
                Marca = "Quilmes"
            };

            //formato json
            string jsonEjemplo1 = "{\"Nombre\" : \"Suave\",\"Marca\" : \"Quilmes\"}"; // escapamos las comillas dobles con barra invertida (alt + 92)
            //string json2 = @"{""Nombre"" : ""Suave"",""Marca"" : ""Quilmes""}"; // es quivalente
            //string json3 = $"{{\"Nombre\" : \"{miCerveza.Nombre}\", \"Marca\" : \"{miCerveza.Marca}\"}}"; // es equivalente pero con interpolacion

            //Formato de un objeto json
            /*
              {
                "Nombre" : "Suave",
                "Marca" : "Quilmes"
              }               
             */

            //ejemplo 2: json tambien puede representar una coleccon de objetos

            Cerveza[] cervezas = new Cerveza[] {
                new Cerveza()
                {
                    Nombre = "Suave",
                    Marca = "Brahma"
                },
                new Cerveza()
                {
                    Nombre = "Suave",
                    Marca = "Corona"
                }
            };

            string jsonEjemplo2 = "[" +
                "{\"Name\" : \"Suave\", \"Marca\" : \"Brahma\"}," +
                "{\"Name\" : \"Suave\", \"Marca\" : \"Corona\"}" +
                "]"; // ejemplo harcodeado




            //Otro ejemplo para el 2 sin harcodear
            /*
             
             Para usar interpolación de cadenas con una colección de objetos, como en 
            tu ejemplo, puedes recorrer la colección y construir la cadena JSON utilizando
            la interpolación de cadenas. De siguiente modo:
             
             */
            // Utilizamos StringBuilder para construir la cadena JSON eficientemente
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");
            foreach (Cerveza cerveza in cervezas)
            {
                jsonBuilder.Append($"{{\"Name\" : \"{cerveza.Nombre}\", \"Marca\" : \"{cerveza.Marca}\"}},");
            }

            jsonBuilder.Remove(jsonBuilder.Length - 1, 1); // Removemos la última coma
            jsonBuilder.Append("]");

            string jsonEjemploInterpolacion = jsonBuilder.ToString();



            /*
             Este código recorre la colección de cervezas y para cada objeto crea una 
            cadena JSON utilizando la interpolación de cadenas. Luego, utiliza 
            StringBuilder para construir la cadena JSON completa de manera eficiente, 
            asegurándose de eliminar la coma adicional al final. Finalmente, obtenemos 
            la cadena JSON completa llamando al método ToString() del StringBuilder.
                                     
             */


            //El json se veria asi:
            /*
             
             
             
             [
                {"Name" : "Suave", "Marca" : "Brahma"},
                {"Name" : "Suave", "Marca" : "Corona"}
             ]

             
             
             */


        }








        public class Cerveza
        {
            public string Nombre { get; set; }
            public string Marca { get; set; }


        }
    }
}
