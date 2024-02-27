namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Animal animal = new Animal()
                {
                    Nombre = "Lobo",
                    //Color = "Marron" // Se espera el dato, con eso salta el ERROR
                };

                Console.WriteLine(animal);
            }
            catch (FaltaNombreException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(FaltaColorException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }





    public class Animal
    {
        public string Nombre { get; set; }
        public string Color { get; set; } 

        //public Animal() { }    / El constructor esta de forma implicita
       

        // DATO IMPORTANTE:
        //Sino sobreescribimos ToString al querer mostrar el animal nos muestra esto: onsoleApp.Animal
        public override string ToString()
        {
            if(Nombre == null)
            {
                throw new FaltaNombreException();
            }
            if (Color == null)
            {
                throw new FaltaColorException();
            }
            return $"Nombre:{Nombre}, Color: {Color}";
        }

        //public override string ToString()
        //{
        //    if (Nombre == null)
        //    {
        //        throw new FaltaNombreException();
        //    }
        //    else if (Color == null)
        //    {
        //        throw new FaltaColorException();
        //    }
        //    return $"Nombre:{Nombre}, Color: {Color}";
        //}


        /*
         Aquí hay algunas diferencias clave a considerar al evaluar las condiciones:

        Instrucciones if en serie:

        USANDO IF : 
        En este caso, cada condición se evalúa de manera independiente. Si ambas condiciones son verdaderas (es decir, Nombre y Color son nulos), ambas excepciones pueden lanzarse.
        Esto puede ser útil si deseas manejar cada condición de manera independiente y lanzar múltiples excepciones si varias condiciones no se cumplen.
        Estructura if-else:


        USANDO ELSE IF:
        Con esta estructura, si la primera condición (Nombre == null) se evalúa como verdadera, la segunda condición (Color == null) no se evaluará.
        Si Nombre es nulo, se lanzará la excepción FaltaNombreException y la condición Color == null no se verificará.
        Esto puede ser útil si deseas que las condiciones se evalúen de manera secuencial y solo deseas lanzar una excepción basada en la primera condición que no se cumple.
         
         
         */


    }



    public class FaltaNombreException : Exception 
    {
        public FaltaNombreException() : base("Error con el Nombre"){ }  
            
    }

    public class FaltaColorException : Exception
    {
        public FaltaColorException() : base("Error con el Color") { }

    }

}
