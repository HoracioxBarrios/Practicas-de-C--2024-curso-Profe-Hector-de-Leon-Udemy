namespace CAppPropiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Venta venta1 = new Venta(100, DateTime.Now);
            venta1.Total = -153652555;
            Console.WriteLine(venta1.Total); // usamos la propiedad Total y nos hace de Get para traernos el valor guardado en _total 

            //venta1.Date = DateTime.Now; // No me permite settear ya que mi propiedad no tiene set
            Console.WriteLine(venta1.Date); // Solo tenemso el Accesor Get
        }
    }




    class Venta
    {
        // Los atributos sin modificador de acceso se establecen como private de forma implícita.
        private int _total; // Por convención, se puede usar guion bajo para nombrar atributos privados.
        DateTime date;



        /* Encapsulación:
               Para tener un control de los datos se utiliza la encapsulación. Es decir, los atributos que no 
               queremos que sean accedidos desde cualquier lado o modificados de cualquier forma se definen como privados.

               Para poder tener acceso controlado a dicho atributo se utilizan las propiedades Get y Set. Estas propiedades deben tener acceso public.
        */


        public Venta(int total, DateTime date)
        {
            _total = total;// En este caso, se asigna el valor del parámetro 'total' al atributo '_total'. No es necesario usar 'this' ya que los nombres son distintos.
            this.date = date;// 'this' se utiliza para diferenciar entre el parámetro 'date' y el atributo 'date' de la clase.
        }






        // Tenemos acceso al atributo privado _total con la propiedad Total que es public y tenemos control sobre dicho atributo.

        //public int Total 
        //{
        //    get { return _total.ToString(); } // Nos da error porque estamos definiendo el retorno en Int en la declaracion de la propiedad Total y estamos convirtiendo el valor que se retorna a string
        //    set { _total = value;}
        //}




        // otro ejemplo
        //public string Total
        //{
        //    get
        //    {
        //        return _total.ToString();
        //    }

        //}



        // Propiedad para obtener y establecer el total de la venta.

        // Propiedad con getter y setter
        public int Total
        {
            get // Accesor de lectura (getter)
            { 
                return _total; 
            }
            set // Accesor de escritura (setter)
            { 
                if(value < 0) // Se verifica que el valor no sea negativo antes de asignarlo.
                {
                    value = 0;
                }
                _total = value;
            }

        }


        public string Date
        {
            get 
            {
                return this.date.ToString();
            }
        }

        public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        }


        public string GetInfo()
        {
            return "Total a Pagar: " + _total + " " + "Fecha: " + date.ToLongDateString(); 

        }
    }
}
