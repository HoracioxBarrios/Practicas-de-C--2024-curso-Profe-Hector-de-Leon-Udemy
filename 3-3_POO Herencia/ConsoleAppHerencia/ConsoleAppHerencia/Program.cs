namespace ConsoleAppHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de Doctor y la inicializamos con valores específicos.
            Doctor doctor1 = new Doctor("Pedro", 30, "Cardiologo");
            Console.WriteLine(doctor1.GetInfo()); //uso del mtodo Heredado
            Console.WriteLine(doctor1.GetData()); // uso del metodo propio

            // Creamos una instancia de Dev y la inicializamos con valores específicos.
            Dev desarrollador1 = new Dev("Horacio", 35, "C#");
            Console.WriteLine(desarrollador1.GetInfo());
            Console.WriteLine(desarrollador1.GetData());
        }
    }

    // Clase base para representar personas.
    class People
    {
        private string _name; // Por convención, los atributos privados se nombran con guion bajo al inicio.
        private int _age;

        //Constructor
        public People(string name, int age)
        {
            _name = name; // No se utiliza 'this' aquí porque los nombres de los parámetros son distintos de los campos.
            _age = age;
        }

        // Método para obtener información básica de la persona.
        public string GetInfo()
        {
            //return _name + " " + _age;   * No se recomienda esta concatenacion de este modo.

            // Utilizamos interpolación de cadenas para combinar el nombre y la edad.
            return $"{_name} {_age}";

        }
        /*utilizando interpolación de cadenas (string interpolation) al colocar $ delante 
         de la cadena. Esto es una forma más moderna y legible de combinar cadenas en 
         comparación con la concatenación convencional, que implica el uso del operador +.*/

    }

    /*
     HERENCIA EN C#
     * En C# solo se puede Heredar de una Clase base, a diferencia de otros lenguajes.
    para emular esto se utilizan las Interfaces, que vemos mas adelante.



     En C#, una clase solo puede heredar de una única clase base directa, lo que se conoce 
    como herencia simple. En comparación con algunos otros lenguajes de programación, como C++,
    donde la herencia múltiple es permitida, C# restringe esta posibilidad para simplificar el
    diseño y evitar ambigüedades que puedan surgir de la herencia múltiple.
    */



    //Herencia 1
    // Clase derivada Doctor que hereda de People.

    class Doctor : People
    {
        private string _speciality;



        // Constructor: Primero inicializa los atributos específicos de la clase derivada (Doctor) 
        // y luego invoca al constructor de la clase base (People) para inicializar los datos básicos de una persona.

        public Doctor(string name, int age, string speciality) : base(name, age) 
        {
            _speciality = speciality;
        }


        public string GetData()
        {
            return $"{GetInfo()} {_speciality}"; // podemos usar el metodo del padre(este devuelve el nombre y la edad) y tambien devolvemos la especialidad - aca usamos :interpolación de cadenas

        }
    }

    /*
        Importante: En la herencia, evita redefinir atributos o métodos del padre en el hijo, ya que estos se heredan automáticamente. 
        Puedes hacer uso de lo heredado. Hay excepciones, como el uso de Polimorfismo, que se discute más adelante.
    */




    //Herencia 2 
    class Dev : People
    {
        private string _lenguage;

        public Dev(string name, int age, string lenguage) : base(name, age)  
        {
            _lenguage = lenguage;

        }
        public string GetData()
        {
            return $"{GetInfo()} {_lenguage}"; 

        }
    }
}
