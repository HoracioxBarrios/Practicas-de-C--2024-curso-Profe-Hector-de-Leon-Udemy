using System.Security.Cryptography.X509Certificates;//

namespace C_AppVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 
             - VARIABLE o CAMPO o PROPIEDAD




            Una variable es un contenedor que almacena un valor.


            -variable
            en C# (C sharp la regla es, que para declarar una variable
            se debe usar camelCase. si se empieza con letra o con guon bajo (esto es para campos privados) Y luego se puede usar numeros.



            - Campo (es una variable en un contexto de clase y puede ser public, private, internal o protected
            que son modificadores de acceso)




            - Propiedad - es una variable que le da un nivel mas de astraccion generalmente es un Getter y 
            un setter que te da acceso a un campo privado.








            Distinción entre variables, campos y propiedades en C# puede ser un tanto confusa al principio, 
            pero aquí te doy una explicación más detallada para clarificar cada uno:



            1. **Variable**: Una variable es simplemente un espacio en la memoria que contiene un valor. 
            En C#, las variables pueden ser locales (definidas dentro de un método y solo accesibles dentro de ese método), 
            parámetros de método (valores que se pasan a un método), o variables de instancia (definidas a nivel de clase y 
            accesibles desde cualquier método de esa clase).




            2. **Campo**: Un campo es una variable que está declarada dentro de una clase, pero fuera de cualquier método. 
            Los campos son miembros de datos de la clase y almacenan el estado de un objeto. Los campos pueden tener 
            modificadores de acceso como public, private, protected, etc., que determinan cómo pueden ser accedidos desde 
            otras clases.




            3. **Propiedad**: Una propiedad es un miembro de una clase que proporciona un mecanismo flexible para leer, 
            escribir o calcular el valor de un campo privado. Las propiedades tienen métodos asociados llamados "getters" 
            y "setters" que permiten leer y escribir el valor del campo, respectivamente. Las propiedades en C# permiten 
            un mejor encapsulamiento y control del acceso a los campos de la clase.





            La diferencia fundamental entre un campo y una propiedad es que una propiedad proporciona un nivel adicional 
            de abstracción y control sobre el acceso y modificación de un campo subyacente. Al usar propiedades, puedes 
            definir lógica personalizada en los métodos de acceso (getters y setters) para validar o manipular los valores 
            que se establecen o se leen.


            RESUMEN:
            En resumen, mientras que una variable es simplemente un contenedor de datos, un campo es una variable declarada 
            dentro de una clase y una propiedad es un mecanismo para controlar el acceso a un campo y proporcionar un 
            punto de entrada para la lógica adicional. La elección entre utilizar un campo o una propiedad depende de las 
            necesidades de diseño y de la encapsulación que deseas aplicar en tu código.
             
             
             
             */


            //VARIABLE
            int edad = 25; // se llama variable al espacio de memoria declarado en el contecto de un metodo sino se la llama de otra manera
                       

        }// fin metodo main

    }//fin class Program



    //CAMPO
    public class Persona
    {
        private string _nombre; // (campo es una variable en el contexto de clase) en troas palabras: Un campo es una variable que está asociada a una clase

        public void MostrarNombre()
        {
            Console.WriteLine(_nombre);// Accediendo al campo desde dentro de la clase
        }
    }//fin class Persona



    //PROPIEDAD
    /*Una propiedad proporciona un mecanismo para controlar el acceso a un campo de una clase. 
     * Proporciona una forma de leer o modificar el valor de un campo privado, generalmente 
     * con lógica adicional para validar o procesar los datos. Aquí hay un ejemplo:
     */
    public class Animal
    {
        private string _nombre; // campo privado




        public string Nombre // Propiedad:  que tiene acceso al campo privado
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }// fin class Animal


}//Fin espacio de nombre
