using System; // directiva system , para usar el metodo de la class Console 

namespace C_AppFunciones_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FUNCIONES

            /*las funciones son una forma de encapsular la lógica de un programa para que pueda ser reutilizada en
              diferentes partes del código. 
             
            * El proposito de las funciones es de SER REUTILIZABLE

            * Al declarar un metodo se debe hacer usando verbos ya que reprecentan acciones.

            * Se debe escribir en UpperCamelCase ejemplo de un metodo statico que no retorna nada: 
            
            static void MostrarNumero()
            {
            
            };





            En c#* todo se centra en el contexto de clases ya que se Usa el paradigma Orientado a Objetos, por
            lo tanto una funcion siempre está atada a una class, por lo tanto en el contexto de class una funcion 
            es un MÉTODO.



            al crear un metodo (o funcion 'fuera del contexto de un class' en otros lenguajes de programacion)
            como en C# la idea es que un funcion solo debe realizar una accion sola, en caso de hacer mas acciones se debe 
            dividir las fincionalidades en dos o mas funciones reutilizables



            // METODOS son Funciones pero en el contexto de Class

             */

            


            //variables o campos
            int numero1 = 5;
            int numero2 = 15;



        }//fin metodo Main

        //ejemplo 1 - metodo void (no retorna/devuelve nada ) y que no recibe parametros

        static void mostrarNUmero()
        {
            Console.WriteLine("Hola este es un Texto");
        }

        //ejemplo 2 - metodo void (no retorna/devuelve nada ) y que recibe parametros 
        static void MostrarSuma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine(resultado);
        }



        //ejemplo 3 - metodo (que devuelve un resultado) y recibe parametros
        static int sumar (int numero1, int numero2)
        {
            return numero1 + numero2;// para devilver el valor se usa la palabra reservada return
        }


    }//fin class Program
}//fin namespace
