namespace ConsoleAppGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tendria que hacer dos clases MiLista que manejen cada tipo de dato.
            //MiLista1 numeros = new MiLista1(10);
            //numeros.Add(20);
            //numeros.Add(5);

            //MiLista2 cadenas = new MiLista2(10);
            //cadenas.Add("Sol");
            //cadenas.Add("Fer");





            //Con Generics Creamos una Class MiLista que trabaje con cualquier tipo de dato

            //MiLista<T> listaElementos = new MiLista<T>(10); // hay que aclarar aca el tipo en la instancia sino da ERROR
            MiLista<int> listaNumeros = new MiLista<int>(10);
            listaNumeros.Add(2);
            listaNumeros.Add(3);
            MiLista<string> listaPalabras = new MiLista<string>(10);
            listaPalabras.Add("Correr");
            listaPalabras.Add("Saltar");

            //usa el Get generico
            Console.WriteLine(listaNumeros.GetElement(11));
            Console.WriteLine(listaPalabras.GetElement(0));


            //usa el Get String generico
            Console.WriteLine(listaNumeros.GetString());
            Console.WriteLine(listaPalabras.GetString());


            //Podemos menejar otros tipos de datos
            MiLista<Persona> listaPersonas = new MiLista<Persona>(20);
            listaPersonas.Add(new Persona() { Nombre = "Herctor", Pais = "Mexico" });
            listaPersonas.Add((Persona)new Persona() { Nombre = "Alicia", Pais = "EEUU" });

            Console.WriteLine(listaPersonas.GetString());


        }
    }


    public class MiLista1
    {
        private int[] _arrayElementos;
        private int _index = 0; // _index se utiliza para rastrear la posición actual dentro del array. 
                                // Ayuda a controlar en qué parte del array estamos o qué elemento estamos accediendo.
                                // Este seguimiento es esencial para evitar que el acceso al array sea indefinido.



        public MiLista1(int n)//Constructor
        {
            _arrayElementos = new int[n];// 'n' representa la cantidad de elementos o 'espacios disponibles' que tendrá como límite el array.

        }

        public void Add(int elemento)
        {
            if(_index < _arrayElementos.Length)// si hay espacio disponible:
            {
                _arrayElementos[_index] = elemento; // en esa posicion ,guardame el elemento.
                _index++; //incremento, ya que queda ocupado el espacio anterior.
            }
        }
    }

    /*Si Tendriamos que manejar en lugar de Numeros Int, elementos Strings
     Tendriamos que hacer otra class MiLista para eso.

    public class MiLista2 
    {
        private string[] _arrayElementos;
        private int _index = 0; 



        public MiLista2(int n)
        {
            _arrayElementos = new string[n];

        }

        public void Add(string elemento)
        {
            if (_index < _arrayElementos.Length)
            {
                _arrayElementos[_index] = elemento; 
                _index++; 
            }
        }
    }




    Con Generics no es Necesario!
    Ya que va a poder manejar cualquier tipo de dato.
     */


    //GENERICS
    public class MiLista<T> // con <T> aclaramos que va a manejar este tipo generico
    {
        private T[] _arrayElementos;// El array contendrá elementos del tipo genérico T
        private int _index = 0; // _index se utiliza para rastrear la posición actual dentro del array.


        public MiLista(int n)
        {
            _arrayElementos = new T[n];  // El constructor inicializa un array interno de tipo genérico con tamaño n.

        }


        // EN ESTE EJEMPLO ESTAMOS TENIENDO UN EJEMPLO DE RECIBIR UN ELEMENTO DE TIPO T
        public void Add(T elemento) 
        {
            if (_index < _arrayElementos.Length)// Mientras haya lugar disponible
            {
                _arrayElementos[_index] = elemento;// Agrega un elemento al array en la posición actual (_index)
                _index++; // Incrementa el índice para el próximo elemento.
            }
        }


        // En este método, vamos a devolver un elemento de tipo T almacenado en la posición dada.
        public T GetElement(int IndexPosElement)
        {
            // Validamos si el índicePosElement está dentro del rango válido.
            if (IndexPosElement <= _index && IndexPosElement >= 0) 
            {
                return _arrayElementos[IndexPosElement]; // Devolvemos el elemento en la posición IndexPosElement.

            }      
            // En caso de que el índicePosElement esté fuera del rango válido, devolvemos el valor predeterminado de tipo T.
            // Para tipos de valor (int, double, etc.), el valor predeterminado es 0. Para tipos de referencia (string, objetos, etc.), es null.
            return default(T); 
        }




        // Este método devuelve una cadena que representa todos los elementos almacenados en el array, separados por '|'.
        public string GetString()
        {
            int i = 0; // Inicializa un contador para recorrer los elementos del array.
            string resultado = ""; // Inicializa una cadena vacía para almacenar el resultado de la concatenación de elementos.

            // Mientras el contador sea menor que el número de elementos almacenados en el array (_index), continúa el bucle.
            while (i < _index)
            {
                // Concatena el elemento actual del array al resultado, seguido de '|' para separar los elementos.
                resultado += _arrayElementos[i].ToString() + "|";

                // Incrementa el contador para pasar al siguiente elemento del array en la próxima iteración.
                i++;
            }

            // Devuelve la cadena que contiene la concatenación de todos los elementos del array, separados por '|'.
            return resultado;
        }

    }








    public class Persona
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }

        /* Al querer mostrar la persona en el Console.WriteLine 
          usando el método GetString de la clase MiLista, obtenemos
          una representación de la instancia de Persona como:
          ConsoleAppGenerics.Persona|ConsoleAppGenerics.Persona|

          Esto ocurre porque todas las clases heredan de Object, 
          que tiene un método ToString con una implementación básica 
          que devuelve el nombre de la clase. El método ToString de Object 
          tiene la palabra clave 'virtual', lo que nos permite 
          sobrescribirlo para cambiar su comportamiento o para que 
          nos devuelva un formato específico.
        */

        // Sobrescribe el método ToString para personalizar la representación de la clase Persona.
        public override string ToString()
        {
            // Devuelve una cadena que muestra el nombre y el país de la persona.
            return $"Nombre: {Nombre} - País: {Pais}";
        }
    }


}
