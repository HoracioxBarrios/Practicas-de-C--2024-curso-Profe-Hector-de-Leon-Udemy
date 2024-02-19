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