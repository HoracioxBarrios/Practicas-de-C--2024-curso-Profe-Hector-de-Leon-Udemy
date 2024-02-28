namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAR NUESTRA BASE DE DATOS Y NUESTRAS TABLAS


        }
    }
}
/*
 * Primero abrimos SSMS Sql Server manager Studio
 
 * Para loguear debemos elegir la Instancia del SERVIDOR que creamos al 
   intalar el MOTOR DE BASE DE DATOS (SQL SERVER 2022) ahi es donde definimos: 
    1 El NOMBRE DEL SERVER,
    2 el USUARIO por defecto es 'sa' y 
    3 la CONTRASEÑA '123456' por ejemplo. SI PONEMOS AUTENTICACION MIXED Y NO AUTENTICAR CON WINDOWS
 
  * YA LOGUEADO AL SERVIDOR:
   1 creamos la BASE DE DATOS : (new database) ejemplo CsharpDB
   2 sobre la db CsharpDb :doble click y se despliega, 
   3 sobre la carpeta Tables :(new ---> table)





    En el Ejemplo tenemos:
TABLA : Beer
                    COLUMN NAME -    DATA TYPE    -      ALLOW NULLS (casilla: acepta null?)
(Primary key)            ID               Int             NO  -------------------> en las opciones de abajo: Identity especification    YES  (define el auto incremento des este ID)
                        Name              varchar(50)     NO
                        BrandID           int             NO

/-------------------------------------------------------------------------------------------


2DA TABLA : Brand
                    COLUMN NAME -    DATA TYPE    -      ALLOW NULLS (casilla: acepta null?)
(Primary key)            ID               Int             NO  -------------------> en las opciones de abajo: Identity especification    YES  (define el auto incremento des este ID)
                        Name              varchar(50)     NO



<<< luego >>>
vamos a relacionar las dos tablas: con una (foraight Key) o llave foranea.

NOS PARAMOS EN LA PRIMERA TABLA SOBRE    BrandID ----> relationship ------> add ----> Tables and colunm specification (en los ...) ----> abre lo siguiente:
.[Relationship Name :]
.   FK_Beer_Beer
.
.Primary Key Table:                     Foreight Key Name
.    [Brand]                                [Beer]
.       ID
.

En el ejemplo quedaria asi la relacion: de la Tabla Brand: la ID relacionada foraneamente con de la Tabla Beer: la BrandID

Ok
Close y Guardar!

cartelito: save --> yes
/-------------------------------------------------------------------------------------------
Dato: 
si no aparecen las tablas creadas, parandonos sobre la base de datos (refresh) para actualizar....

Dato: 
Si es la primera vez que usamos Sql Server lo mas seguro es que no nos deje guardar los cambios,
Tools ---> Options -----> Designers ----> opcion: Tables and database Designer -----> DESTILDAR : prevent saving shanges that require table re -creation


lO SGUIENTE ES:
AGREGAR MARCAS A LA TABLA: Brand
Nos paramos sobre la tabla, click derecho ---> EDIT TOP 200 ROW ...
ID             NAME
1              Delirium
2              Erdinger

<si creas uno luego (se autonumera con 3)y despues lo borras sin querer , y creas otro ,este se autonumera a 4 (esa que ya queda mal porque te falta la id 3 en el registro
),para que se reincie, hice lo siguiente: 
borré todas los datos en el modo (EDIT TOP 200 ROW )y cambie a Modo DESING Y  
en la ID que tiene (identity specification) lo puse en NO ,lo guardé y luego lo puse en Yes como
estaba antes. una forma de Restablecer a 0 todo.
Seguro debe de haber una forma mejor....>


LUEGO AGREGAMOS CERVEZAS A LA TABLA :Beer
ID             NAME               BRANDID
'1'        Delirium Tremens          1 esta se va a relacionar con la marca que tiene la ID 1
'2'        Pikantus                  2 esta se va a relacionar con la marca que tiene la ID 2


YA PODEMOS VER QUE TENEMOS LAS CERVEZAS: ----> Sobre la tabla Beer -------> SELECT TOP 1000 ROWS
y nos quedaria algo asi:

linea de codigo (consulta):
SELECT TOP (1000) [ID] 
                 ,[Name]
                 ,[BrandId]
FROM [CsharpDB].[DBO].[Beer]






resultado:
     ID       NAME                BRANDID
1    1        Delirium Tremens     1
2    2        Pikantus             2


 */