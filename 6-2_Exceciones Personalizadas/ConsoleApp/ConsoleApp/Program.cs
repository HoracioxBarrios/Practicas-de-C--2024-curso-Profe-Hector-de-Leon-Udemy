namespace ConsoleApp
{
    internal class Program
    {
        /*
            Las excepciones personalizadas son clases que heredan de la clase base Exception y se 
            utilizan para representar situaciones excepcionales específicas dentro de una aplicación. 
            Proporcionan información detallada sobre el error que ocurrió y pueden incluir mensajes 
            personalizados, propiedades adicionales y métodos para ayudar en el manejo y diagnóstico 
            de la excepción.
         
         */
        static void Main(string[] args)
        {
            try
            {
                Cerveza cerveza = new Cerveza()
                {
                    Name = "Suave",
                    //Brand = "Quilmes"    //---- Forzamos que falte la marca -----
                };

                Console.WriteLine(cerveza); // AL QUERER MOSTRAR cerveza VA A SALTAR EL ERROR
                
            }
            catch (invalidCervezaException ex) // capturamos la excepcion -- aca tenemos dos modelos de ejemplo
            {
                Console.WriteLine(ex.Message);
            }


        }
    }//Fin class Program

    public class Cerveza
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            if(Name == null || Brand == null)
            {
                throw new invalidCervezaException();
                //throw new invalidCervezaException2("Segundo mensaje--- Nombre o Marca Invalido!");
            }
            return $"Cerveza: {Name}, {Brand}";


        }
    }

    //FORMA 1 - recomendada aca ponemos el mensaje pasandole al Padre en el constructor
    public class invalidCervezaException : Exception
    {

        public invalidCervezaException() : base("La Cerveza no tiene nombre o marca, por lo cual es Invalido!!!")
        {

        }

    }

    //Forma 2 - menos recomendable 

    //public class invalidCervezaException2 : Exception
    //{
    //    private string _mensaje;
    //    public invalidCervezaException2(string mensaje) : base(mensaje)
    //    {
    //        _mensaje = mensaje;
    //    }

    //}


    /*
        la implementación de invalidCervezaException2 podría ser útil si planeas realizar 
        algún tipo de lógica adicional en el constructor de la excepción para manipular el 
        mensaje de alguna manera antes de pasarlo a la clase base Exception. Si no necesitas 
        esa lógica adicional, la primera implementación es más directa y suficiente para la 
        mayoría de los casos.
     */
}
