namespace ConsoleAppGenerics2Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso de la clase genérica
            MiLista<int> listaDeEnteros = new MiLista<int>(5); // Se instancia una lista de tipo Int
            listaDeEnteros.Agregar(10);
            listaDeEnteros.Agregar(20);
            listaDeEnteros.Agregar(30);

            Console.WriteLine("Elemento en el índice 1: " + listaDeEnteros.ObtenerElemento(1));

            MiLista<string> listaDeCadenas = new MiLista<string>(3); // Se instancia una lista de tipo string - ----- con la misma Class MiLista ya que soporta cualquier tipo ------
            listaDeCadenas.Agregar("Hola");
            listaDeCadenas.Agregar("Mundo");

            Console.WriteLine("Elemento en el índice 0: " + listaDeCadenas.ObtenerElemento(0));
        }
    }




    // Definición de una clase genérica
    public class MiLista<T>
    {
        private T[] elementos;
        private int tamañoActual;


        public MiLista(int capacidad)
        {
            elementos = new T[capacidad];
            tamañoActual = 0;
        }

        public void Agregar(T elemento)
        {
            if (tamañoActual < elementos.Length)
            {
                elementos[tamañoActual] = elemento;
                tamañoActual++;
            }
            else
            {
                Console.WriteLine("La lista está llena.");
            }
        }

        public T ObtenerElemento(int indice)
        {
            if (indice >= 0 && indice < tamañoActual)
            {
                return elementos[indice];
            }
            else
            {
                throw new IndexOutOfRangeException("Índice fuera de rango.");
            }
        }
    }

}
