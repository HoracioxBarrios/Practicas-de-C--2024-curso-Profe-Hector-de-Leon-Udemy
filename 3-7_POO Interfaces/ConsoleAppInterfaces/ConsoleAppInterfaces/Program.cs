using System.Xml.Linq;

namespace ConsoleAppInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaramos e instanciamos los (Tiburones)
            Shark[] shark = new Shark[]
            {
                new Shark("Shark1", 56),
                new Shark("Shark2", 60)
            };

            ShowFish(shark); //Este método espera un array de los que implementan IFish
            //Ejemplo 2

            ShowAnimal(shark);//Este método espera un array de los que implementan IAnimal y como la Class Shark implementa las dos , no hay problema.


            //Ejemplo 3
            /*Se puede crear arrays directamente desde la interfaz del siguiente modo */
            IFish[] fishs = new IFish[] //aca no se instancia sino que seria como una capsula de arreglos
            {
                new Siren(100),// Siren cumple con el contrato de IFish
                new Shark("Shark2", 200)// Shark tambien cumple con el contrato de IFish
            };

            /*SE PUEDE SIMPLIFICAR ASI:
            IFish[] fishs =
            [
                new Siren(100),             // Siren cumple con el contrato de IFish
                new Shark("Shark2", 200)    // Shark tambien cumple con el contrato de IFish
            ];

            */


            //Pero si hacemos esto salta error con shark porque espera Objetos que implemente IFish:
            //IFish[] fishs3 = new Siren[] //aca no se instancia sino que seria como una capsula de arreglos
            //{
            //    new Siren(100),// Siren cumple con el contrato de IFish
            //    new Shark("Shark2", 200)// Shark NO cumple
            //};



            IFish[] fishs2 = new Siren[] 
            {
                new Siren(150) //Siren Implementa la Interfaz IFish
            };

            //-----------------------------------------------------------------------------------------
   

            //----- Se comporta como IFish
            IFish pez = new Shark("Tibu", 10);       //********* Se instancia como Shark pero se guarda como una referencia de IFish
            pez.Swim();
            /* IMPORTANTE: Al crear el objeto le decimos que debe comportarse como un IFish, 
               incluso siendo un objeto del tipo Shark. Por lo tanto, solo podemos acceder a los métodos
               definidos en el contrato de IFish, y no a los métodos del contrato de IAnimal. */

            //pez.Name; // NO SE RECONOCE porque es un método de interfaz IAnimal
            
            

            //----- Se comporta como Shark
            Shark pez2 = new Shark("Tibu2", 20);  //********* Se instancia como Shark pero se guarda como una referencia de Shark
            pez2.Swim();
            pez2.Name = "Tíbu"; // Ahora se reconoce porque le dijimos que debe comportarse como Shark (Accede a todos los métodos)



            //----- Se comporta como IAnimal
            IAnimal pez3 = new Shark("Tibu3", 30);  //********* Se instancia como Shark pero se guarda como una referencia de IAnimal
            /* pez3.Swim(); */ // NO SE RECONOCE porque es un método de interfaz IFISH
            pez3.Name = "Tíbu3"; // Accede solo a los métodos del contrato de IAnimal




        }

        static void ShowFish(IFish[] fish) //aclaramos que le vamos a pasar que es una lista de peces
        {
            Console.WriteLine("--- Mostramos los Fish ---");
            int i = 0;
            while(i< fish.Length)
            {
                Console.WriteLine(fish[i].Swim()); //al aclarar lo que le mandamos por parametro ,Podemos hacer uso del metodo de esta interfaz
                i++;
            }
        }
        //Ejemplo 2
        static void ShowAnimal(IAnimal[] animal) //aclaramos que le vamos a pasar que es una lista de Animales
        {
            Console.WriteLine("--- Mostramos los Animales ---");
            int i = 0;
            while (i < animal.Length)
            {
                Console.WriteLine(animal[i].Name); //al aclarar lo que le mandamos por parametro ,Podemos hacer uso del metodo de esta interfaz
                i++;
            }
        }

    }


    /*
    INTERFACES:
    Una interfaz es un contrato en el cual definimos los atributos o 
    métodos que las clases que implementan la interfaz deben implementar 
    obligatoriamente.
    */
    public interface IAnimal
    {
        public string Name { get; set; } //Propiedad

    }

    public interface IFish
    {
        public int Speed { get; set; } //Propiedad

        public string Swim(); // Aquí solo se declara la firma. Método Nadar.
    }



    //Clase que Implementa las interfaces
    public class Shark :IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string name, int speed) 
        {
            this.Name = name;
            this.Speed = speed;
        
        }
        public string Swim()
        {
            return $"{Name} Nada {Speed} Km/h";
        }

    }

    //Otra Class ue implementa la Interfaz
    public class Siren : IFish
    {
        public int Speed { get; set; }

        public Siren(int speed)
        {
            this.Speed = speed;
        }

        public string Swim()
        {
            return $"La Sirena Nada a {this.Speed} Km/h";
        }
    }




}
/*
 CARACTERISTICAS DE INTERFAZ EN C#:

Explicación de las características de las interfaces en C# en 
términos más simples:




1. **Contrato de comportamiento**: 
    Una interfaz en C# es como un contrato que una clase debe seguir. 
    Define qué métodos y/o propiedades debe tener una clase que implementa 
    esa interfaz.


2. **Flexibilidad en la implementación**: 
    Las interfaces permiten que diferentes clases implementen los mismos 
    métodos y propiedades de diferentes maneras, siempre y cuando cumplan con 
    el contrato establecido por la interfaz.


3. **Herencia múltiple**: 
    A diferencia de las clases, que solo pueden heredar de una clase base, 
    una clase en C# puede implementar múltiples interfaces. Esto le permite 
    adquirir comportamientos y funcionalidades de diferentes fuentes.


4. **Polimorfismo**: 
    Las interfaces permiten que los objetos de diferentes clases que implementan 
    la misma interfaz se traten de manera uniforme. Esto significa que puedes 
    trabajar con una variedad de objetos de manera consistente, sin importar sus 
    implementaciones concretas.


5. **Desacoplamiento**: 
    El uso de interfaces ayuda a desacoplar el código, lo que significa que las 
    clases que dependen de una interfaz no necesitan conocer los detalles internos 
    de las clases que la implementan. Esto facilita la modularidad y el mantenimiento 
    del código.




En resumen, las interfaces en C# son herramientas poderosas que permiten definir 
contratos claros entre diferentes partes de un programa, promoviendo la flexibilidad,
la reutilización de código y un diseño más modular y mantenible.
 

----------------- ----------------- ----------------- ----------------- -----------------
Interfaces - Polimorfismo en tiempo de ejecucion (al igual que sobreescitura de metodo Virtual - Override )
Usar interfaces en varias Class emula una especie de herencia multiple, donde cada Clase que implemente los 
metodos de la interfaz le dara a dicho metodo su propia funcionalidad.
 
 */