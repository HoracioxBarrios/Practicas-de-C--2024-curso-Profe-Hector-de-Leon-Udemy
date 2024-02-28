namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MODIFICAR O CREAR UNA NUEVA INSTANCIA DE SERVIDOR SQL SERVER
        }
    }
}

/*
Crear una nueva instancia de SQL Server:

Instalación de SQL Server: Debes instalar SQL Server 2022 en la máquina donde 
deseas crear la nueva instancia. Durante el proceso de instalación, 
tendrás la opción de agregar una nueva instancia.

Configuración de la instancia: Durante la instalación, deberás especificar 
la configuración de la nueva instancia, incluidos el nombre de la instancia, 
los directorios de instalación, las cuentas de inicio de sesión del servicio, etc.

Finalización de la instalación: Una vez que hayas proporcionado toda la 
información necesaria, puedes completar la instalación. SQL Server configurará 
la nueva instancia según las especificaciones que hayas proporcionado.
*/







//crear nueva instancia o modificar una existente:


/*-------------------------- CREAR UNA NUEVA -----------------------------------
 Con Sql server 2022 instalado: Busca en tu pc el SQL SERVER 2022 INSTALACION CENTER :

1_ Ir Instalacion

2_ Nueva instalacion independiente sql server o agregar carapteristicas a una instalacion existente.

3_ ir a donde esta instalado sql server en C:/SQL2022/    elegir la carpeta ,(aca express) por ejemplo o la version que tenemos instalada. ACEPTAR

4_ siguiente

5_ INSTALACION TYPE: tenemos 2 opciones para elegir : NUEVA INSTALACION o AGREGAR COSAS (MODIFICAR ) UNA IINSTALACION EXISTENTE. 
(voy a crear una nueva en mi caso)

6_ siguiente, siguiente, etc

7_ INSTANCE CONFIGURATION:
Named Instance = server_prueba    por ejemplo
Instance ID: SERVER_PRUEBA  (al hacer click se autocompleta)

8_ siguiente

9_SERVER CONFIGURATIONS

10_ siguiente



11_ DATABASE ENGINE CONFIGURATION: Configurar el acceso, que por defecto nos deja en WINDOWS AUTENTICATION
CAMBIAMOS A MIXED MODE : y por defecto el usuario es :'sa' y ponemos la contraseña_ '123456' y repetimos '123456' por ejemplo.


12_ siguiente y finalizar

# video del ejemplo: https://youtu.be/UnHFRUG6CgI?si=wu7IKtLgKjgNP87r



YA PODEMOS ABRIR SSMS (SQL SERVER MANAGER STUDIO) Y TRABAJAR CON LA BASE DE DATOS, crear tablas, agregar datos , etc
con SSMS ponemos usuario y contraseña  - ya podemos trabajar....
 */