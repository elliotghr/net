## Primera aplicación. Vídeo 2

- C# es case sensitive
- No puede haber 2 clases con el mismo nombre, a menos de que haya dos namespaces diferentes
- El namespace (Espacio de nombres) es como crear una carpeta (espacio) con diferentes clases
- En los namespaces se alojan nuestras clases
- System es un paquete que nos permite utilizar otras clases

## Sintaxis básica I. Vídeo 3

Comentarios con // o /\* \*/

### Identifricadores

Son los nombres que se usan para identificar los elemtnso del programa

- namespaces
- variables
- metodos
- clases
- constantes

Los identificadores:

- Solo se pueden usar letras, numneros y guiones bajos
- Dben comenzar con letra o guiones bajos

## Sintaxis básica II. Vídeo 4

Tipos de datos

- Por valor
- Por referencai

### Primitivos

- Entero
  - Con signo y sin signo
- Reales
  - Decimales
    - Float
    - Double: Doble precisión (precisión muy alta)
    - Decimal: Decimales para transacciónes bancarias
- Booleanos
  - True o false

![Tipos de datos](/assets/tipos-datos.png)

### Variables

Espacio en la memopria del ordenador donde se almacena un valor que podrá cambiar durante la ejecución del programa

- Comenzar con minusculas
- Camelcase (como en JS)
- Declarar el tipo de dato y a continuación (inicializar) el nombre de la variable

## Sintaxis básica III. Vídeo 5

Operadores aritmeticos

- Suma, resta, multiplicación, división, residuo
- +, concatenación de strings

Operadores de aumento y decremento

- ++
- /--

## Sintaxis básica IV. Vídeo 6

Con var asignamos el tipo de dato de manera automática dado por c#

```c#
// La declaración e inicialización sí debe realizarce al momento
var edadPersona = 27;

Console.WriteLine(edadPersona);
```

### Conversiones y Casting

Declaramos el tipo de dato después de la asignación entre parentesis

```c#
    double temperatura = 34.5;

    int tempreaturaMadrid;

    // conversión explícita
    //casting

    tempreaturaMadrid = (int) temperatura;
    // 34
```

```c#
    int habitatesCiudad = 10000000;

    // conversión implicita

    long habitantesCiudad2018 = habitatesCiudad;
    // 34
```

Para corroborar si se puede hacer de manera implicita debemos verificar la información de "Tabla de conversiones númericas implicitas"

## Sintaxis básica V. Vídeo 7

Con parse podremos convertir un texto a número (int, double, etc)

Con el método ReadLine() crearemos un input para el usuario.
ReadLine trae un string, si guardamos el input en int entonces debemos generar un parse

```c#
Console.WriteLine("Introduce un número: ");
int num1 = int.parse(Console.ReadLine()); // Esperamos el valor
Console.WriteLine("Ahora el segundo número: ");
int num2 = int.parse(Console.ReadLine()); // Esperamos el valor
Console.WriteLine($"La suma de los números es: {num1 + num2}");

```

## Sintaxis básica. Uso de constantes. Vídeo 8

Se declara e inicializa una constante al mismo tiempo

```c#
const string MYNAME = "Elliot";
const double PI  = 3.1416;
// WriteLine con paso de argumentos, {n} indica que argumento está tomando, en este ejemplo 0 es MYNAME, 1 es PI y así sucesivamente
Console.WriteLine("El valor de mis constantes es: {0}", MYNAME, PI);
```

Otro ejemplo

```c#
const double PI = 3.1416;

Console.WriteLine("Escribe el radio del circulo: ");
double radio = double.Parse(Console.ReadLine());

// double area = radio * radio * PI;
double area = Math.Pow(radio, 2) * PI;

Console.WriteLine($"El area del circulo es: {area}");

```

## Métodos I. Vídeo 9

Los metodos son un frupo de sentencias (instrucciones) a las que se da un nombre identificativo que realizan una tarea en concreto

Tipodevuelto nombreMetodo (parametros)
{
cuerpo del metodo
}

- Todos los metodos irán dentro de una clase
- No hay distinción entre metodos y funciones, son lo mismo

```c#
 int sumaNumeros(){
    int num1 = 7;
    int num2 = 3;

    int resultado = num1 + num2;

    return resultado;
 }

// con argumentos
  int sumaNumeros(int num1, int num2){
    int resultado = num1 + num2;

    return resultado;
 }

 // no devuelve un valor
 // Un metodo copn void jamás debe tener un return
   void sumaNumeros(int num1, int num2){
    int resultado = num1 + num2;
    Console.WriteLine(resultado);
 }
```

## Métodos II. Vídeo 10

Sintaxis

```c#
class Program
{

    static void Main(string[] args)
    {
        mensajeEnPantalla();

        Console.WriteLine("Mensaje desde el Main");

        sumaNumeros(7,3);
    }

    static void mensajeEnPantalla()
    {
        Console.WriteLine("Mensaje desde el método mensajeEnPantalla");
    }

    static void sumaNumeros(int num1, int num2)
    {
        int res = num1 + num2;

        Console.WriteLine("La respuesta de la suma es: " + res);
    }
}
```

## Métodos III. Métodos return. Vídeo 11

```c#
class Program
{

    static void Main(string[] args)
    {
        int resultadoEntero = sumaNumerosEnteros(10, 5);
        Console.WriteLine("La respuesta de la suma es: " + resultadoEntero);
    }

    static int sumaNumerosEnteros(int num1, int num2)
    {
        int res = num1 + num2;

        return res;
    }
}
```

### Modularización

Dividimos el código en partes pequeñas, si el metodo es pequeño podemos hacer uso del operador flecha

```c#
// El cual ya tiene un return implicito y no necesita llave
class Program
{
    static int sumaNumerosEnteros(int num1, int num2) => num1 + num2;
}
```

### Métodos IV. Ámbito y sobrecarga. Vídeo 12

Variable en ambito de clase

```c#
class Program
{
    // Las variables así se denominan: Campos de clase
    int numero1 = 1;
    int numero2 = 2;

    void primerMetodo()
    {
        // int numero1 = 1;
        // int numero2 = 2;
        Console.WriteLine(numero1 + numero2);
    }

    void segundoMetodo()
    {
        Console.WriteLine(numero1);
    }
}
```

Sobrecarga de metodos

En la misma clase tenemos 2 o más metodos con el mismo nombre, deben recibir diferentes tipos de parametros o diferentes números de parametros

```c#
// Sobrecarga de metodos

static int suma(int operador1, int operador2) => operador1 + operador2;
//diferente tipo de dato
static int suma(int operador1, double operador2) => operador1;
// Más argumentos
static int suma(int numero1, int numero2, int numero3) => numero1 + numero2 + numero3;
```

## Curso C#. Condicional switch. Vídeo 18

Un switch solo puede evaluar

- int
- char
- string

float y double deben usar IF

## Curso C#. Excepciones I. Vídeo 22

usamos try catch y en el catch usamos FormatException, el código no se rompe

```c#
Console.WriteLine("Introduce tu edad:");
try
{
    int myEdad = int.Parse(Console.ReadLine());
    if (myEdad <= 18)
    {
        return;
    }
}
catch (FormatException e)
{
    Console.WriteLine("Introduce un número correcto");
}
catch (OverflowException e)
{
    Console.WriteLine("Introduce un número más corto");
}

Console.WriteLine("Tienes carnet?");
string carnet = Console.ReadLine();

if (carnet == "si")
{
    Console.WriteLine("Adelante");
}
```

## Curso C#. Excepciones II. Captura de varias excepciones. Vídeo 23

Podemos usar varias excepciones con varios bloques catch

```c#
Console.WriteLine("Introduce tu edad:");
try
{
    int myEdad = int.Parse(Console.ReadLine());
    if (myEdad <= 18)
    {
        return;
    }
}
catch (FormatException e)
{
    Console.WriteLine("Introduce un número correcto");
}
catch (OverflowException e)
{
    Console.WriteLine("Introduce un número más corto");
}

```

Sin embargo, podemos ocupar una excepción general y así nunca se romperá el programa

```c#
Console.WriteLine("Introduce tu edad:");
try
{
    int myEdad = int.Parse(Console.ReadLine());
    if (myEdad <= 18)
    {
        return;
    }
}
catch (Exception e)
{
    Console.WriteLine("Introduce un número correcto");
}

```

## Curso C#. Excepciones III. Conflictos varias excepciones, captura con filtros. V

Para capturar una excepción en concreto agregamos el when y comparamos

```c#
Console.WriteLine("Introduce tu edad:");
try
{
    int myEdad = int.Parse(Console.ReadLine());
    if (myEdad <= 18)
    {
        return;
    }
}
catch (Exception e) when (e.GetType() != typeof(FormatException))
{
    Console.WriteLine("Introduce un número correcto");
}
catch(FormatException e){
    Console.WriteLine("Has introducido un string, por favor, introduce un número");

}
```

## Curso C#. Excepciones IV. Lanzamiento de excepciones con throw. Vídeo 25

Con el siguiente código generamos una excepción con throw new ArgumentOutOfRangeException(); y obligamos a que se utilice un try catch para poder continuar con el código, esto generará un mensaje perosnalizado del error

```c#
static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número del mes");
            int numeroMes = int.Parse(Console.ReadLine());

            try
            {
            Console.WriteLine(NombreDelMes(numeroMes));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! fuera");
            }

            Console.WriteLine("Seguimos!");
        }

        public static string NombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Feb";
                case 3:
                    return "Marzo";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
```

## Curso C#. POO. ¿Qué es la POO? Vídeo 27

Una variable en la clase es una propiedad
Una clase tiene propiedades y metodos, de aqui se crean los objetos, los cuales comparten estos datos con sus variaciones correspondientes

```c#
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creacion de objeto de tipo circulo. Variable/Objeto de tipo circulo

            miCirculo = new Circulo(); // Iniciación de variable. Instanciar una clase

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculoRojo = new Circulo();

            // miCirculo.pi = 50.45;

            Console.WriteLine(miCirculoRojo.calculoArea(9));

        }
    }

    class Circulo
    {
        const double pi = 3.1416; // propiedad de la clase Circulo. Campo de clase

        public double calculoArea(int radio) /// metodo de clase ¿ Qué pueden hacer los objetos de tipo circulo?
        {
            return pi * radio * radio;
        }

    }
```

## Curso C#. POO III. Encapsulación y convenciones. Vídeo 29

Crearemos diferentes modulos en nuestra clase para que no se puedan acceder a ellos desde una clase externa, es una medida de seguridad y buen funcionamiento del sistema

Con private ese metodo o propiedad solo funcionará en esa clase, nunca desde fuera

- Los identificadores public deben comenzar con letra mayuscula
- Los que no son public deben empezar con minuscula
- Es recomendable que para modificar el valor de una propiedad creemos un metodo que lo modifique, siempre con sus validaciones correspondientes, y no que se modifique de manera directa

```c#
public void cambiaValorEuro(double nuevoValor)
{
    if (nuevoValor < 0)
    {
        euro = 1.253;
    }
    else
    {
        euro = nuevoValor;
    }
}
```

## Curso C#. POO IV. Constructores. Vídeo 30

Cuando creamos un objeto debemos pensar en su estado inicial, aqui se define la plantilla para todos nustros objetos
El constructor tiene el mismo nombre que la clase y no puede devolver ningun dato

```c#
    class Coche
    {

        public Coche()
        {
            ruedas = 4;
            largo = 2300;
            ancho = 0.800;
        }


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
```

Para acceder a las propiedades crearemos un método getter que nos permita acceder al valor privado de estas propiedades

```c#
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crear objeto/instancia de un coche
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getRuedas());
        }
    }
   class Coche
    {

        public Coche()
        {
            ruedas = 4;
            largo = 2300;
            ancho = 0.800;
        }

        public int getRuedas()
        {
            return ruedas;
        }


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
```

### Sobrecarga de constructores

- Es cuando tenemos más de 1 constructor

```php
        {
            Coche coche3 = new Coche(2134.12, 123.12);

        }


        public Coche()
        {
            ruedas = 4;
            largo = 2300;
            ancho = 0.800;
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }
```

## Curso C#. POO V. Getters y Setters. Vídeo 31

Un metodo setter establece propiedades a los objetos

- no devuelven nada, no llevan return, no especificaremos ningun tipo de datos, solo void

Un metodo setter normalmente tiene su metodo getter

```c#
public void setExtras(bool paramClimatizador, String paramTapiceria)
{
    climatizador = paramClimatizador;
    tapiceria = paramTapiceria;
}

public String getExtras()
{
    return $"Extras del coche: Tapiceria {tapiceria}, Climatizador: {climatizador}";
}
```

### this

Cuando se desee hacer referencia a un campo de clase se debe hacer uso de this delante de ese campo

```c#
public void setExtras(bool climatizador, String tapiceria)
{
    this.climatizador = climatizador;
    this.tapiceria = tapiceria;
}
```
