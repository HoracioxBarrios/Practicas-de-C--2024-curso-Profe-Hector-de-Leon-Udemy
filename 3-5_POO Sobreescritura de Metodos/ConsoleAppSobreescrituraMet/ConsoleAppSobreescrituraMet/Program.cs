namespace ConsoleAppSobreescrituraMet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B objetoB = new B();
            Console.WriteLine(objetoB.Saludar());

            C objetoC = new C();
            Console.WriteLine(objetoC.Saludar());


            //Ejemplo 2
            Sale sale = new Sale(10);// cuantos elementos vamos a manejar
            sale.Add(2);// una cantidad un producto, un precio
            sale.Add(3);
            Console.WriteLine("El total es: " + sale.GetTotal());// imprimimos el total

            SaleWhithTax saleWithTax = new SaleWhithTax(10, 1.16m); //al inicializar variables decimales, es necesario agregar el sufijo m o M al final del número para indicar que se trata de un decimal. 
            saleWithTax.Add(2);
            saleWithTax.Add(3);
            Console.WriteLine("El total con impuesto es: " + saleWithTax.GetTotal());
        }
    }

    //Clase base (Padre)
    public class A
    {

        /* PROTECTED : Este modificador de acceso permite que solo sea usado en las class derivadas. PUBLIC: en cualquier contexto.
        protected virtual string Saludar()
        {
            return "Hola soy el método de A";
        }
        */

        //Métoodo Original se usa el modificador: VIRTUAL
        public virtual string Saludar()
        {
            return "Hola soy el método de A";
        }

    }

    //Clase derivada (hija)
    public class B : A
    {

        //Sobreeescribimos el método para cambiar su funcionalidad
        //modificador OVERRIDE
        public override string Saludar()
        {
            return "Hola soy el metodo de B";
        }
    }


    //otra Clase derivada (hija)
    public class C : A
    {
        //Sobreescribimos el método para extender su funcionalidad
        //modificador OVERRIDE
        public override string Saludar()
        {
            return base.Saludar() + " y de C";//base hace referencia al Padre
        }
    }







    //Ejemplo 2 'mas real'
    public class Sale
    {
        private decimal[] _amounts;
        private int _n;
        private int _end;


        public Sale(int n) 
        {
            _amounts = new decimal[n];
            _n = n;
            _end = 0;        
        }

        public void Add(decimal amount)
        {
            if (_end < _n)
            {
                _amounts[_end] = amount;
                _end++;
            }
        }
        public virtual decimal GetTotal()
        {
            decimal result = 0;
            int i = 0;

            while(i < _amounts.Length)
            {
                result += _amounts[i];
                i++;
            }

            return result;
        }
    }

    //Supongamos que necesitamos obtener el total de una venta pero con un impuesto agregado.
    //Podemos crear una class que herede de Sale con un metodo al que vamos a sobreeescribir para ampliar su funcionalidad.
    public class SaleWhithTax : Sale
    {
        private decimal _tax;
        public SaleWhithTax(int n, decimal tax) : base(n)// Tenemos que pasarle el parametro al Padre
        {
            _tax = tax;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * _tax; // ampliamos la funcionalidad agregandole el impuesto
        }

    }


}

/*
 POLIMORFISMO:

    El polimorfismo utilizando sobreescritura de métodos con virtual y override en C# permite que las clases 
    derivadas proporcionen su propia implementación de un método definido en una clase base.

    virtual: Se utiliza en un método de la clase base para indicar que dicho método puede ser sobrescrito en 
    clases derivadas. Este método virtual proporciona una implementación predeterminada que puede ser 
    reemplazada por las clases hijas.

    override: Se utiliza en un método de una clase derivada para indicar que está proporcionando una 
    implementación específica para un método virtual de la clase base. Este método reemplaza la 
    implementación base del método virtual.


    Esto se considera:
        Polimorfismo de tiempo de ejecución.
 */