namespace C_AppClasesYObjetos
{
    internal class Program // Class punto de inicio del programa
    {
        static void Main(string[] args)
        {


            // Instanciamos el objeto Venta
            Venta venta1 = new Venta(100, DateTime.Now); // le pasamos el total y el tiempo en que se produjo la venta
            venta1.Show();
            Console.WriteLine(venta1.GetInfo());



            //Otra instancia , otro objeto Venta
            Venta venta2 = new Venta(10000, DateTime.Now);
            venta1.Show();
            Console.WriteLine(venta1.GetInfo());
        }
    }// fin de class program








    // Ejemplo de una Class
    // Clase que representa una venta
    class Venta
    {
        // Campos o atributos
        int total;
        DateTime date;


        //Constructor que no recibe parametros
        public Venta() { }

        // Constructor que inicializa una venta con valores dados
        public Venta(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }


        //metodos

        // Método para mostrar un mensaje sobre la venta
        public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        }

        // Método para obtener información sobre la venta
        public string GetInfo()
        {
            return "Total a Pagar: " + total + " " + "Fecha: " + date.ToLongDateString(); //el metodo de la clase Date se puede usar en un objeto del mismo tipo. aca el metodo ToLongDateString() combierte el dato en string

        }
    }
}
