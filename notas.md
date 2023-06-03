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

## Condicional switch. Vídeo 18

Un switch solo puede evaluar

- int
- char
- string

float y double deben usar IF

## Excepciones I. Vídeo 22

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

## Excepciones II. Captura de varias excepciones. Vídeo 23

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

## Excepciones III. Conflictos varias excepciones, captura con filtros. V

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

## Excepciones IV. Lanzamiento de excepciones con throw. Vídeo 25

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

## POO. ¿Qué es la POO? Vídeo 27

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

## POO III. Encapsulación y convenciones. Vídeo 29

La encapsulación es un principio fundamental de la programación orientada a objetos que consiste en agrupar datos y los métodos que operan sobre esos datos en una unidad coherente, conocida como clase. La encapsulación permite ocultar los detalles internos de una clase y proporcionar una interfaz controlada a través de la cual se puede acceder y manipular los datos.

En C#, la encapsulación se logra mediante el uso de modificadores de acceso como public, private, protected, entre otros. Estos modificadores determinan el nivel de acceso que otros componentes del programa tienen a los miembros de una clase (propiedades, campos, métodos, etc.).

Aquí hay algunos conceptos clave relacionados con la encapsulación:

Visibilidad de los miembros: Los miembros de una clase pueden tener diferentes niveles de acceso. El modificador "public" permite que un miembro sea accesible desde cualquier parte del programa, mientras que el modificador "private" restringe el acceso solo dentro de la propia clase. Además, existen los modificadores "protected" (accesible en la clase y en las clases derivadas) e "internal" (accesible dentro del mismo ensamblado).

Propiedades: Las propiedades proporcionan un mecanismo para encapsular los campos de una clase y controlar el acceso a ellos. Permiten establecer reglas y lógica adicional al leer o escribir los valores de los campos. Pueden tener modificadores de acceso para definir quién puede acceder a ellos.

Métodos de acceso: En lugar de acceder directamente a los campos de una clase, se recomienda utilizar métodos de acceso (getters y setters) para obtener y establecer los valores de los campos encapsulados. Esto permite mantener el control sobre cómo se accede y manipula la información contenida en los campos.

Ocultamiento de información: La encapsulación también permite ocultar la implementación interna de una clase y exponer solo los detalles relevantes a través de una interfaz pública. Esto promueve la modularidad y el bajo acoplamiento, ya que los componentes externos no necesitan conocer los detalles internos de la clase, sino que solo interactúan con su interfaz pública.

La encapsulación es importante porque proporciona una capa de abstracción y protección al permitir un control estricto sobre cómo se accede y manipula la información en una clase. Esto facilita el mantenimiento del código, mejora la legibilidad y facilita los cambios futuros en la implementación sin afectar a otros componentes del programa.

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

## POO IV. Constructores. Vídeo 30

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

La sobrecarga de constructores es un concepto en programación orientada a objetos que permite definir múltiples constructores para una clase, cada uno con diferentes conjuntos de parámetros. Esto significa que una clase puede tener varios constructores con el mismo nombre pero con diferentes listas de argumentos.

La sobrecarga de constructores es útil cuando se desea crear instancias de una clase de diferentes maneras, proporcionando diferentes valores de inicialización o permitiendo diferentes combinaciones de argumentos.

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

## POO V. Getters y Setters. Vídeo 31

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

## Bucle foreach. Arrays IV. Vídeo 39

```c#
static void Main(string[] args)
{
    int[] arrayTest = { 1, 2, 3 };

    foreach (var item in arrayTest)
    {
        Console.WriteLine(item);
    }
}
```

## Herencia. Concepto y explicación teórica. Vídeo 41

En C#, la herencia es un mecanismo que permite crear una clase nueva basada en una clase existente. La clase existente se conoce como clase base o clase padre, y la nueva clase se conoce como clase derivada o clase hija. La herencia permite que la clase derivada herede los miembros (métodos, propiedades, campos) y el comportamiento de la clase base, y luego agregue o modifique estos miembros según sea necesario.

Para definir una clase derivada en C#, se utiliza la palabra clave "class" seguida del nombre de la clase derivada y la palabra clave " : " seguida del nombre de la clase base. Por ejemplo:

```csharp
class ClaseDerivada : ClaseBase
{
    // Miembros adicionales de la clase derivada
}
```

La clase derivada puede acceder a los miembros heredados de la clase base, incluyendo sus métodos y propiedades públicas o protegidas. La herencia permite la reutilización de código y la creación de una jerarquía de clases, donde las clases derivadas pueden especializarse y agregar funcionalidad adicional a medida que sea necesario.

Además de heredar los miembros de la clase base, una clase derivada puede sobrescribir (override) los métodos virtuales de la clase base para proporcionar una implementación personalizada. Esto se logra utilizando la palabra clave "override" en la definición del método en la clase derivada.

## Herencia III. Constructores y base. Vídeo 43

Cada clase, ya sea padre o hijo tiene su propio constructor, además, el constructor de la subclase (clase hija) siempre llama al constructor por defecto de la clase padre, esto se hace con la instrucción **:base()**, si se modifica el constructor del padre por uno dado por el desarrollador entonces la intrucción base ya no funciona y deberemos programar la instrucción base de manera manual en cada clase

```c#
    class Mamiferos
    {
        private String nombreSerVivo;
        //remplazamos el constructor por defecto
        public Mamiferos(String nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }
    }

    class Caballo : Mamiferos
    {
        // creamos el constructor de caballo y asignamos la base con el parametro que esperamos recibir
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
    }
```

## Herencia IV. Principio de sustitución. Vídeo 44

El principio de sustitución establece que una instancia de una clase derivada debe ser capaz de sustituir sin problemas a una instancia de su clase base en cualquier contexto en el que se espere una instancia de la clase base.

Cuando se cumple el principio de sustitución, se garantiza que el código que utiliza la clase base también funcionará correctamente con instancias de las clases derivadas, sin necesidad de realizar modificaciones en el código existente.

Para cumplir con el principio de sustitución, es necesario que las clases derivadas se adhieran a las mismas reglas y contratos definidos por su clase base. Esto significa que los métodos sobrescritos en las clases derivadas deben tener el mismo tipo de retorno, la misma lista de parámetros y respetar las mismas precondiciones y postcondiciones establecidas por los métodos de la clase base. En resumen, la clase derivada debe comportarse como una especialización o extensión de la clase base.

```c#
// principio de sustitución
Mamiferos animal = new Caballo("2Pak");
```

## Herencia V. Polimorfismo. Vídeo 45

Es la capacidad de un objeto de tomar diferentes formas y comportarse de manera distinta según el contexto en el que se utilice.

En el contexto del polimorfismo, una referencia de un tipo base puede apuntar a un objeto de su tipo base o a un objeto de cualquiera de sus tipos derivados. Esto significa que se puede tratar a un objeto de una clase derivada como si fuera un objeto de su clase base.

El polimorfismo se logra a través del uso de la herencia y la sobreescritura de métodos. Cuando una clase derivada redefine un método de su clase base utilizando la palabra clave override, se puede invocar ese método redefinido a través de una referencia del tipo base, y el comportamiento adecuado se determinará en tiempo de ejecución.

Aquí hay un ejemplo que ilustra el polimorfismo:

```c#
public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido genérico.");
    }
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra.");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla.");
    }
}
```

En este ejemplo, la clase Animal es la clase base y las clases Perro y Gato son clases derivadas. Cada una de las clases derivadas sobrescribe el método HacerSonido() de la clase base para proporcionar una implementación específica.

Luego, se puede utilizar el polimorfismo para tratar a un objeto de una clase derivada como un objeto de su clase base:

```c#
Animal animal1 = new Perro();
Animal animal2 = new Gato();

animal1.HacerSonido(); // Resultado: "El perro ladra."
animal2.HacerSonido(); // Resultado: "El gato maulla."
```

## Herencia VI. Modificador de acceso Protected. Vídeo 46

Lo más normal es declarar una variable o propiedad de la clase en private generando encapsulación

- protected es un metodo intermedio, es accesible por la misma clase y por las clases que la hereden
  En resumen, protected nos va a funcionar cuando necesitemos que los metodos se ejecuten dentro de otros metodos de ciertas clases, no llamandolos desde el Main

## Curso C#. Interfaces I. Vídeo 48

En C#, una interfaz es una especificación de un conjunto de métodos, propiedades y eventos que una clase puede implementar. Una interfaz define un contrato que una clase debe cumplir, es decir, establece qué miembros deben estar presentes en la clase que implementa la interfaz y cómo deben ser definidos.

Las interfaces en C# se definen utilizando la palabra clave interface y pueden contener métodos, propiedades, eventos e indexadores, pero no pueden contener implementaciones de código. Aquí tienes un ejemplo de cómo se define una interfaz:

```c#
public interface IReproducible
{
    void Reproducir();
    string ObtenerInformacion();
}
```

En este ejemplo, se ha definido una interfaz llamada IReproducible que especifica dos métodos: Reproducir() y ObtenerInformacion(). Cualquier clase que implemente esta interfaz deberá proporcionar implementaciones concretas para estos métodos.

Para que una clase implemente una interfaz en C#, se utiliza la palabra clave class seguida del nombre de la clase, seguida de la palabra clave :, y finalmente el nombre de la interfaz que se va a implementar. Aquí tienes un ejemplo de una clase que implementa la interfaz IReproducible:

```c#
public class Reproductor : IReproducible
{
    public void Reproducir()
    {
        Console.WriteLine("Reproduciendo...");
    }

    public string ObtenerInformacion()
    {
        return "Información del reproductor";
    }
}
```

En este caso, la clase Reproductor implementa la interfaz IReproducible y proporciona implementaciones concretas para los métodos Reproducir() y ObtenerInformacion().

Al implementar una interfaz, una clase puede cumplir múltiples contratos y adquirir funcionalidades adicionales. Esto permite que se aplique el polimorfismo y se utilicen objetos de diferentes clases que implementan la misma interfaz de manera intercambiable.

Las interfaces son útiles para lograr una mayor flexibilidad y extensibilidad en el diseño de software, ya que permiten definir contratos claros y desacoplados entre las clases. También facilitan la implementación de patrones de diseño como la inyección de dependencias y favorecen una mejor modularidad y reutilización del código.

## Curso C#. Interfaces II. Vídeo 49

Si existen dos interfaces con el mismo nombre de metodo entonces especificaremos a que interface pertence

```c#
// interfaz
    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }
    interface ISaltoConPatas
    {
        int numeroPatas();
    }
// clase
        class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {
        }
        // Se elimina el modificador de acceso
        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }
        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
    }
```

## Curso C#. Clases abstractas I. Vídeo 52

Una clase abstracta es una clase que no se puede instanciar directamente, sino que se utiliza como una base para otras clases. Proporciona una estructura común y un conjunto de características que las clases derivadas pueden heredar y ampliar.

En C#, una clase abstracta se declara utilizando la palabra clave abstract. Puede contener miembros abstractos y miembros concretos. Sin embargo, una clase abstracta puede tener al menos un miembro abstracto, que es un miembro sin implementación y debe ser implementado en las clases derivadas.

Aquí hay un ejemplo de cómo se define una clase abstracta en C#:

```csharp
public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public abstract void Conducir();

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}
```

En este ejemplo, la clase Vehiculo es una clase abstracta que tiene dos propiedades (Marca y Modelo) y dos métodos. El método Conducir() es un método abstracto, mientras que el método MostrarInformacion() es un método concreto.

Cuando una clase hereda de una clase abstracta, debe proporcionar una implementación para todos los miembros abstractos de la clase base. Aquí hay un ejemplo de una clase derivada que implementa la clase abstracta Vehiculo:

```csharp
public class Coche : Vehiculo
{
    public override void Conducir()
    {
        Console.WriteLine("Conduciendo el coche...");
    }
}
```

En este caso, la clase Coche hereda de la clase abstracta Vehiculo y proporciona una implementación para el método Conducir(). La clase Coche ahora se puede instanciar y utilizar.

Las clases abstractas son útiles cuando se desea proporcionar una implementación base común para un grupo de clases relacionadas, pero se espera que cada clase derivada proporcione su propia implementación para ciertos métodos específicos.

Algunas características clave de las clases abstractas son:

- No se pueden crear instancias directamente de una clase abstracta.
- Pueden contener métodos abstractos, que deben ser implementados por las clases derivadas.
- Pueden contener métodos concretos, que ya tienen una implementación.
- Pueden contener propiedades, campos y eventos.
- Pueden ser heredadas por clases derivadas.

En resumen, una clase abstracta es una clase base que proporciona una estructura común y puede contener métodos abstractos y concretos. Sirve como una plantilla para las clases derivadas y proporciona una manera de definir comportamientos comunes y obligar a las clases derivadas a implementar ciertos métodos.

## Curso C#. Clases selladas (sealed classes). Vídeo 54

En C#, una clase sellada (sealed class) es una clase que no se puede heredar. Es decir, no se puede crear una clase derivada a partir de una clase sellada.

Para definir una clase sellada, se utiliza la palabra clave sealed antes de la declaración de la clase. Aquí tienes un ejemplo:

```csharp
public sealed class MiClaseSellada
{
    // Código de la clase
}
```

En este caso, la clase MiClaseSellada está marcada como sellada, lo que significa que no se puede heredar de ella. No se puede usar la palabra clave abstract en conjunto con sealed, ya que son conceptos opuestos.

La intención de una clase sellada es evitar que se extienda o se cree una clase derivada. Esto se puede utilizar por varias razones, como mantener un control estricto sobre la funcionalidad de la clase, evitar problemas de diseño o proteger la implementación interna de una clase.

Es importante tener en cuenta que las clases selladas aún pueden implementar interfaces y pueden ser instanciadas como cualquier otra clase. Sin embargo, no se puede heredar de ellas.

Algunos puntos clave sobre las clases selladas:

Una clase sellada no puede tener clases derivadas.

- No se pueden utilizar las palabras clave abstract y sealed juntas, ya que son mutuamente excluyentes.
  -Las clases selladas pueden ser útiles para proteger componentes críticos o finales de la implementación de una clase.
- Las clases selladas aún pueden implementar interfaces y pueden ser instanciadas normalmente.

En resumen, una clase sellada en C# es una clase que no puede ser heredada. Su declaración con la palabra clave sealed impide que otras clases se deriven de ella. Se utiliza para controlar y restringir la estructura de herencia en una jerarquía de clases.

Esto también aplica para los métodos, lo cual impedirá que se puedan modificar

```c#
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        // Impedimos la modificación del método con sealed
        public sealed override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }

    }
```

## Curso C#. Properties (Propiedades) I. Vídeo 56

En C#, las properties (propiedades) son miembros de una clase que encapsulan el acceso y la modificación de los datos de un objeto. Proporcionan una forma de definir y controlar cómo se obtienen y establecen los valores de los campos internos de una clase, proporcionando una interfaz para interactuar con esos datos.

Las properties permiten acceder a los datos de una clase de manera controlada, ocultando la implementación interna y protegiendo los campos subyacentes de la clase. Se definen utilizando bloques de código especiales llamados "accessors" (accesores), que especifican la lógica para obtener y establecer el valor de una propiedad.

Aquí tienes un ejemplo de cómo se define una propiedad en C#:

```csharp
public class Persona
{
private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

}
```

En este ejemplo, la clase Persona tiene una propiedad llamada Nombre. La propiedad tiene un acceso get (obtener) y un acceso set (establecer) definidos dentro de bloques de código. El acceso get devuelve el valor del campo nombre, mientras que el acceso set asigna un valor al campo nombre.

La propiedad se puede utilizar de la siguiente manera:

```csharp
Persona persona = new Persona();
persona.Nombre = "John Doe"; // Establecer el valor de la propiedad
string nombre = persona.Nombre; // Obtener el valor de la propiedad
```

En este caso, se utiliza la propiedad Nombre para establecer y obtener el valor del campo nombre de la instancia de Persona.

Las properties también pueden tener modificadores de acceso, lo que permite controlar la visibilidad de la propiedad y restringir su acceso. Por ejemplo:

```csharp
public class Persona
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        private set { nombre = value; }
    }
}
```

En este caso, el acceso set de la propiedad Nombre se ha establecido como privado, lo que significa que solo se puede establecer el valor desde dentro de la clase Persona.

Además de los accesores get y set, las properties también pueden tener solo un accesor get, lo que las convierte en propiedades de solo lectura, o solo un accesor set, lo que las convierte en propiedades de solo escritura.

El uso de properties en lugar de acceder directamente a los campos de una clase proporciona una capa adicional de encapsulación y control sobre los datos de la clase. Además, las properties son una parte fundamental del concepto de programación orientada a objetos y ayudan a mantener un diseño coherente y robusto del código.

## Curso C#. Struct. Vídeo 57

En C#, una struct (estructura) es un tipo de dato de valor que puede contener datos y funciones relacionadas. A diferencia de las clases, que son tipos de referencia, las structs son tipos de valor y se almacenan directamente en la memoria donde se declaran, en lugar de almacenarse en la memoria heap y hacer referencia a través de punteros.

Las structs se definen utilizando la palabra clave struct y se pueden considerar como pequeñas clases que contienen datos y, opcionalmente, métodos asociados. A menudo se utilizan para representar conceptos de valor más simples y livianos, como puntos, fechas o valores numéricos, donde el rendimiento y la eficiencia son importantes.

Aquí tienes un ejemplo de cómo se define una struct en C#:

```csharp
public struct Punto
{
    public int X;
    public int Y;

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Mover(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }
}
```

En este ejemplo, se ha definido una struct llamada Punto que tiene dos campos públicos: X e Y. También se ha definido un constructor y un método Mover() que realiza una modificación en los campos de la struct.

Una vez definida la struct, se puede crear una instancia y acceder a sus campos y métodos de la siguiente manera:

```csharp
Punto punto = new Punto(3, 5);
Console.WriteLine($"Posición actual: ({punto.X}, {punto.Y})"); // Resultado: Posición actual: (3, 5)
punto.Mover(2, -1);
Console.WriteLine($"Posición actual después de mover: ({punto.X}, {punto.Y})"); // Resultado: Posición actual después de mover: (5, 4)
```

En este caso, se crea una instancia de la struct Punto y se utilizan sus campos X e Y para representar una posición en un plano cartesiano. Luego, se llama al método Mover() para cambiar la posición del punto.

Algunas características importantes de las structs son:

- Las structs son tipos de valor y se almacenan en la memoria stack.
- Las structs no admiten herencia, pero pueden implementar interfaces.
- Las structs no pueden tener un constructor sin parámetros.
- Las structs no pueden ser nulas (a menos que se utilice el modificador nullable).
- Las structs son más eficientes en cuanto a rendimiento y uso de memoria en comparación con las clases, pero pueden ser menos flexibles y no admiten características como la herencia y la sobrecarga de operadores.

En resumen, las structs en C# son tipos de valor que se utilizan para representar datos simples y livianos. Son útiles cuando se necesita un tipo de valor eficiente en cuanto a rendimiento y almacenamiento, y no se requieren características complejas como la herencia.

### ¿Cuándo usar Struct?

Puedes considerar el uso de una struct en las siguientes situaciones:

1. Representación de tipos de valor pequeños y livianos: Las structs son adecuadas para representar tipos de valor simples y pequeños, como puntos en un plano, coordenadas, fechas, valores numéricos, colores, etc. Si tienes un tipo de valor que no contiene una gran cantidad de datos y solo necesitas almacenar sus propiedades, una struct puede ser una opción adecuada.

2. Pasar datos por valor: Cuando pasas una struct como argumento a un método o la asignas a otra variable, se realiza una copia de los datos de la struct. Esto puede ser útil en situaciones en las que deseas pasar datos por valor en lugar de por referencia. En contraste, las clases se pasan por referencia.

3. Eficiencia y rendimiento: Las structs se almacenan en la memoria stack y no requieren la asignación de memoria en el heap. Esto puede llevar a una mejor eficiencia en términos de uso de memoria y rendimiento, especialmente cuando trabajas con grandes volúmenes de datos o necesitas un rendimiento optimizado.

4. Inmutabilidad: Si deseas que los objetos sean inmutables, es decir, que no se puedan modificar una vez creados, puedes utilizar structs. Al ser tipos de valor, las structs son inmutables por naturaleza, ya que no se pueden cambiar una vez que se han creado. Esto puede ser útil para garantizar la consistencia de los datos y evitar cambios accidentales.

En general, si estás trabajando con tipos de valor pequeños, necesitas una alta eficiencia y rendimiento, o deseas asegurarte de que los objetos sean inmutables, las structs pueden ser una buena opción.

## Enums

Un enum (enumeración) es un tipo de dato que permite definir un conjunto de constantes con nombre. Un enum define un conjunto de valores que representan opciones o categorías discretas.

Un enum se declara utilizando la palabra clave enum y se puede personalizar con una lista de constantes separadas por comas. Aquí tienes un ejemplo básico de cómo se define un enum en C#:

```csharp
public enum DiaSemana
{
Lunes,
Martes,
Miércoles,
Jueves,
Viernes,
Sábado,
Domingo
}
```

En este ejemplo, se ha definido un enum llamado DiaSemana que representa los días de la semana. Cada elemento del enum (Lunes, Martes, Miércoles, etc.) se considera una constante con nombre y se trata como un valor discreto único.

Una vez definido el enum, puedes utilizarlo para declarar variables, asignar valores y realizar comparaciones. Aquí tienes un ejemplo de uso del enum DiaSemana:

```csharp
DiaSemana diaActual = DiaSemana.Martes;
Console.WriteLine($"Hoy es {diaActual}"); // Resultado: Hoy es Martes

if (diaActual == DiaSemana.Sábado || diaActual == DiaSemana.Domingo)
{
Console.WriteLine("¡Es fin de semana!");
}
else
{
Console.WriteLine("No es fin de semana.");
}
```

En este caso, se declara una variable diaActual del tipo DiaSemana y se le asigna el valor DiaSemana.Martes. Luego se muestra el valor de la variable en la consola. También se utiliza una estructura condicional if para determinar si el día actual es un fin de semana o no.

Algunos puntos clave sobre los enums son:

- Los enums son tipos de valor que representan un conjunto de constantes con nombre.
- Los elementos de un enum se consideran constantes y se tratan como valores únicos.
- Los valores predeterminados de un enum se asignan automáticamente en orden ascendente a partir de 0, pero se pueden personalizar asignando valores explícitos.
- Los enums se pueden utilizar para declarar variables, realizar comparaciones y controlar el flujo del programa.
- Los enums también se pueden utilizar como parámetros de métodos y propiedades para limitar las opciones de valores aceptados.

En resumen, los enums en C# son tipos de dato que permiten definir un conjunto de constantes con nombre, lo que facilita el manejo de opciones discretas y mejora la legibilidad y el mantenimiento del código. Se utilizan para representar conjuntos predefinidos de valores y proporcionan una forma más intuitiva y semántica de trabajar con opciones discretas.

## Curso C#. Destructores. Vídeo 59

En C#, un destructor es un método especial que se utiliza para liberar recursos o realizar acciones de limpieza antes de que un objeto sea destruido y eliminado de la memoria. Un destructor se define utilizando la sintaxis ~nombreDeClase() y no toma ningún parámetro.

El destructor se ejecuta automáticamente cuando un objeto es eliminado de la memoria, ya sea porque ha quedado fuera del alcance (finalizado su ciclo de vida) o porque ha sido explícitamente destruido utilizando el recolector de basura (garbage collector).

Aquí tienes un ejemplo de cómo se define un destructor en C#:

```csharp
public class MiClase
{
    // Constructor de la clase
    public MiClase()
    {
        // Inicialización de la clase
    }

    // Destructor de la clase
    ~MiClase()
    {
        // Acciones de limpieza y liberación de recursos
    }
}
```

En este ejemplo, se ha definido un destructor para la clase MiClase. El cuerpo del destructor puede contener cualquier código necesario para liberar recursos, como cerrar archivos, liberar conexiones de red, liberar memoria asignada dinámicamente u otras tareas de limpieza necesarias antes de que el objeto se elimine.

Es importante tener en cuenta que el uso de destructores en C# no es tan común como en otros lenguajes de programación, ya que el recolector de basura (garbage collector) se encarga automáticamente de liberar la memoria asignada a los objetos una vez que ya no están en uso. En general, el recolector de basura maneja la mayoría de los casos de liberación de recursos y limpieza de objetos de manera eficiente.

Sin embargo, hay situaciones específicas en las que puede ser útil utilizar un destructor, como cuando se trabaja con recursos no administrados, como manipuladores de archivos o conexiones a bases de datos, que pueden requerir una liberación explícita.

En resumen, un destructor en C# es un método especial que se ejecuta automáticamente cuando un objeto se destruye y se elimina de la memoria. Se utiliza para realizar acciones de limpieza y liberación de recursos antes de que el objeto sea eliminado. Aunque el uso de destructores no es común en C# debido al recolector de basura, pueden ser útiles en situaciones específicas que involucran recursos no administrados.

### Garbage Collector

El Garbage Collector (recolector de basura) en C# es un componente del entorno de ejecución de .NET que se encarga de administrar la memoria y realizar la recolección automática de objetos no utilizados o inaccesibles. Su objetivo principal es liberar la memoria ocupada por los objetos que ya no son necesarios, lo que ayuda a evitar fugas de memoria y optimiza el uso de recursos en una aplicación.

El Garbage Collector realiza el seguimiento de los objetos creados en tiempo de ejecución y determina cuáles de ellos ya no son accesibles desde el código. Luego, recupera la memoria ocupada por esos objetos para que pueda ser reutilizada en otros fines.

El funcionamiento del Garbage Collector se basa en la detección de objetos no referenciados, es decir, aquellos objetos a los que no se puede acceder directa o indirectamente desde el código en ejecución. Estos objetos se consideran candidatos para ser recolectados y liberados de memoria.

El proceso de recolección de basura consta de varias etapas, incluyendo:

1. Marcado: El Garbage Collector recorre el gráfico de objetos y marca aquellos que son alcanzables y, por lo tanto, deben mantenerse en memoria.

1. Compactación: Se reorganiza la memoria ocupada por los objetos para reducir la fragmentación y mejorar la eficiencia.

1. Liberación: Los objetos no marcados durante el proceso de marcado se consideran no utilizados y se liberan de memoria.

El Garbage Collector opera de manera automática y transparente para el desarrollador. Se encarga de administrar la memoria en segundo plano, liberando los objetos no utilizados en momentos oportunos y sin intervención directa del programador.

La utilización del Garbage Collector en C# proporciona varias ventajas, como:

- Simplifica la administración de memoria, ya que el programador no tiene que preocuparse por liberar manualmente la memoria asignada a los objetos.

- Ayuda a prevenir fugas de memoria, ya que se encarga de liberar objetos que ya no son accesibles.

- Mejora el rendimiento general de la aplicación al evitar la fragmentación de la memoria y al realizar la recolección de basura en momentos óptimos.

Sin embargo, es importante tener en cuenta que el Garbage Collector no es perfecto y no puede liberar memoria instantáneamente. La frecuencia y el momento exacto de la recolección de basura dependen de varios factores, como el uso de memoria, la carga de trabajo del sistema y las políticas de recolección de basura configuradas.

En resumen, el Garbage Collector en C# es un componente del entorno de ejecución de .NET que se encarga de administrar la memoria y realizar la recolección automática de objetos no utilizados. Su función principal es liberar la memoria ocupada por objetos inaccesibles, mejorando el rendimiento y evitando fugas de memoria en una aplicación.

## Curso C#. Genéricos I. Vídeo 60

La programación genérica es un concepto en la programación que permite escribir algoritmos y estructuras de datos que pueden funcionar con diferentes tipos de datos sin tener que ser reescritos o duplicados para cada tipo específico. Es una característica que se encuentra en muchos lenguajes de programación modernos, incluyendo C#.

En lugar de escribir código específico para un tipo de dato en particular, la programación genérica permite definir clases, interfaces, métodos y estructuras de datos que pueden trabajar con tipos de datos genéricos. Estos tipos de datos genéricos se representan mediante parámetros de tipo (también conocidos como tipos genéricos o placeholders) que se reemplazarán con tipos específicos en el momento de su uso.

La programación genérica ofrece varios beneficios, entre ellos:

- Reutilización de código: Al escribir algoritmos y estructuras de datos genéricos, se puede reutilizar el mismo código para diferentes tipos de datos, lo que evita la duplicación de código y simplifica el mantenimiento.

- Flexibilidad y extensibilidad: La programación genérica permite escribir componentes de software que pueden adaptarse a diferentes tipos de datos, lo que brinda flexibilidad y extensibilidad a medida que se agregan nuevos tipos de datos.

- Seguridad en tiempo de compilación: El compilador realiza comprobaciones de tipo en tiempo de compilación para garantizar que los tipos utilizados en la programación genérica sean consistentes y coherentes, lo que ayuda a detectar errores de tipo antes de la ejecución del programa.

- Mejora del rendimiento: Al utilizar tipos genéricos, se evita la necesidad de realizar conversiones de tipo y almacenar objetos en estructuras de datos basadas en referencias, lo que puede resultar en un mejor rendimiento en comparación con el uso de tipos de datos no genéricos.

Un ejemplo común de programación genérica en C# es el uso de las colecciones genéricas proporcionadas por el Framework de Clases de .NET, como List<T>, Dictionary<TKey, TValue>, entre otras. Estas colecciones pueden trabajar con cualquier tipo de dato especificado mediante el parámetro de tipo, lo que las hace flexibles y reutilizables.

Aquí tienes un ejemplo básico de cómo se utiliza la programación genérica en C#:

```csharp
public class MiClaseGenerica<T>
{
    private T dato;

    public MiClaseGenerica(T dato)
    {
        this.dato = dato;
    }

    public T ObtenerDato()
    {
        return dato;
    }
}

// Uso de la clase genérica
MiClaseGenerica<int> instancia1 = new MiClaseGenerica<int>(5);
int dato1 = instancia1.ObtenerDato(); // dato1 será igual a 5

MiClaseGenerica<string> instancia2 = new MiClaseGenerica<string>("Hola");
string dato2 = instancia2.ObtenerDato(); // dato2 será igual a "Hola"
```

En este ejemplo, se ha definido una clase genérica llamada MiClaseGenerica que tiene un parámetro de tipo T. El constructor y el método ObtenerDato trabajan con ese tipo genérico T. Luego, se crean instancias de la clase MiClaseGenerica con diferentes tipos de datos (int y string) y se utilizan los métodos correspondientes.

En resumen, la programación genérica es una técnica que permite escribir código reutilizable que puede trabajar con diferentes tipos de datos. Proporciona flexibilidad, reutilización de código y seguridad en tiempo de compilación. En C#, la programación genérica se logra mediante el uso de parámetros de tipo que se reemplazan por tipos específicos cuando se utilizan los componentes genéricos.

## Colecciones

En el contexto de la programación, las colecciones se refieren a estructuras de datos que se utilizan para almacenar y organizar elementos de datos de manera eficiente. Las colecciones proporcionan métodos y funcionalidades para agregar, eliminar, buscar y manipular elementos dentro de la estructura de datos.

En C#, el Framework de Clases de .NET proporciona una amplia variedad de colecciones predefinidas que se pueden utilizar para diferentes propósitos. Estas colecciones están disponibles en el espacio de nombres System.Collections y System.Collections.Generic, y algunas de las colecciones más comunes son:

- List<T>: Es una lista dinámica que puede contener elementos de cualquier tipo. Proporciona métodos para agregar, eliminar, buscar y modificar elementos en la lista. Los elementos se almacenan en un orden secuencial y se pueden acceder mediante un índice.

- Dictionary<TKey, TValue>: Es una colección de pares clave-valor, donde cada elemento está asociado a una clave única. Proporciona métodos para agregar, eliminar, buscar y modificar elementos basados en su clave. Los elementos se almacenan de forma no secuencial, pero el acceso a ellos es rápido a través de su clave.

- Queue<T>: Es una estructura de datos de cola en la que los elementos se agregan al final y se eliminan desde el frente en un orden FIFO (primero en entrar, primero en salir). Proporciona métodos para agregar, eliminar y examinar elementos en la cola.

- Stack<T>: Es una estructura de datos de pila en la que los elementos se agregan y eliminan desde la parte superior en un orden LIFO (último en entrar, primero en salir). Proporciona métodos para agregar, eliminar y examinar elementos en la pila.

- HashSet<T>: Es una colección que almacena elementos únicos sin ningún orden en particular. Proporciona métodos eficientes para agregar, eliminar y buscar elementos basados en su contenido.

Estas son solo algunas de las colecciones disponibles en C#, pero hay muchas más, como LinkedList<T>, SortedList<TKey, TValue>, ObservableCollection<T>, etc. Cada colección tiene sus características y se utiliza en diferentes escenarios según los requisitos específicos del programa.

Las colecciones en C# son muy útiles para almacenar y manipular conjuntos de datos de manera eficiente, y proporcionan métodos y propiedades convenientes para trabajar con ellos. Al elegir una colección, es importante considerar el rendimiento, el ordenamiento, la búsqueda y los requisitos de duplicación de elementos para seleccionar la más adecuada para una situación dada.

```swift
| Colección                  | Descripción                                                                                         |
|----------------------------|-----------------------------------------------------------------------------------------------------|
| List<T>                    | Lista dinámica que puede contener elementos de cualquier tipo.                                      |
| Dictionary<TKey, TValue>   | Colección de pares clave-valor, donde cada elemento está asociado a una clave única.                |
| Queue<T>                   | Estructura de datos de cola, donde los elementos se agregan al final y se eliminan desde el frente. |
| Stack<T>                   | Estructura de datos de pila, donde los elementos se agregan y eliminan desde la parte superior.     |
| HashSet<T>                 | Colección que almacena elementos únicos sin ningún orden en particular.                             |
| LinkedList<T>              | Lista enlazada que permite la inserción y eliminación eficientes en cualquier posición.              |
| SortedList<TKey, TValue>   | Colección de pares clave-valor ordenada por la clave.                                                |
| ObservableCollection<T>   | Colección que notifica los cambios de sus elementos a través de eventos.                             |
| ConcurrentQueue<T>         | Versión segura para subprocesos de la estructura de cola (Queue<T>).                                |
| ConcurrentStack<T>         | Versión segura para subprocesos de la estructura de pila (Stack<T>).                                |
| ConcurrentDictionary<TKey, TValue> | Versión segura para subprocesos de la estructura de diccionario (Dictionary<TKey, TValue>).   |
```

![Tabla colecciones](/assets/colecciones.png)

Ejemplo:

sintaxis básica de algunas de las colecciones en C# junto con un ejemplo de uso:

List<T>:

```csharp
List<T> lista = new List<T>();
lista.Add(elemento);
elemento = lista[index];
lista.RemoveAt(index);
```

Ejemplo:

```csharp
List<int> numeros = new List<int>();
numeros.Add(10);
numeros.Add(20);
int primerNumero = numeros[0]; // primerNumero será igual a 10
numeros.RemoveAt(1); // Elimina el elemento en el índice
```

## Curso C#. Colecciones II LinkedList. Vídeo 64

La LinkedList en C# es una implementación de una lista enlazada, una estructura de datos que consta de nodos que se enlazan entre sí. Cada nodo contiene un valor y una referencia al siguiente nodo en la secuencia.

A diferencia de las listas dinámicas convencionales (como List<T>), donde los elementos se almacenan en ubicaciones contiguas en la memoria, las listas enlazadas no requieren que los elementos estén en posiciones contiguas. Cada nodo de la lista enlazada contiene el valor del elemento y una referencia al siguiente nodo en la secuencia. Esto permite una inserción y eliminación más eficiente en cualquier posición de la lista.

En C#, la LinkedList se encuentra en el espacio de nombres System.Collections.Generic y se utiliza de la siguiente manera:

Las listas enlazadas son útiles en situaciones donde se requieren inserciones y eliminaciones frecuentes en diferentes posiciones de la lista. Sin embargo, pueden requerir un poco más de memoria debido a la necesidad de almacenar las referencias a los nodos en lugar de los elementos en ubicaciones contiguas.

![Link vs LinkedList](/assets/list-vs-linkedlist.png)

## Curso C#. Colecciones IV. Stacks y Dictionary. Vídeo 66

En C#, un diccionario es una colección que almacena pares de elementos clave-valor, donde cada elemento tiene una clave única asociada a un valor. Los diccionarios proporcionan una forma eficiente de acceder y buscar valores utilizando su clave.

En el Framework de Clases de .NET, hay dos implementaciones principales de diccionarios: Dictionary<TKey, TValue> y SortedDictionary<TKey, TValue>.

1. Dictionary<TKey, TValue>:

- Es una implementación de diccionario que no garantiza un orden específico de los elementos.
- Los elementos se almacenan en función de su clave y se accede a ellos de manera eficiente a través de su clave.
- La clave debe ser única dentro del diccionario.
- Proporciona métodos como Add, Remove, ContainsKey y TryGetValue para agregar, eliminar, buscar y obtener valores del diccionario.

1. SortedDictionary<TKey, TValue>:

- Es una implementación de diccionario que mantiene los elementos ordenados en función de su clave.
- Los elementos se almacenan en un árbol binario de búsqueda y se accede a ellos de manera eficiente a través de su clave.
- La clave debe ser única dentro del diccionario.
- Proporciona los mismos métodos que Dictionary<TKey, TValue> pero también ofrece funcionalidades relacionadas con el orden, como First, Last, Range y Comparer.

Ambas implementaciones de diccionarios permiten agregar, eliminar y buscar elementos de manera eficiente utilizando la clave como referencia. Son ampliamente utilizados para mantener relaciones entre datos y proporcionan un acceso rápido a los valores en función de su clave.

Aquí tienes un ejemplo de cómo utilizar Dictionary<TKey, TValue>:

```csharp
Dictionary<string, int> edades = new Dictionary<string, int>();

// Agregar elementos al diccionario
edades.Add("Juan", 25);
edades.Add("María", 30);
edades["Pedro"] = 35; // Otra forma de agregar elementos

// Acceder a los valores utilizando la clave
int edadDeJuan = edades["Juan"]; // edadDeJuan será igual a 25

// Verificar si una clave existe en el diccionario
bool existeMaria = edades.ContainsKey("María");

// Obtener el valor asociado a una clave de forma segura
int edadDePedro;
bool existePedro = edades.TryGetValue("Pedro", out edadDePedro);

// Eliminar un elemento del diccionario
edades.Remove("Juan");
```

En este ejemplo, se crea un diccionario edades que almacena las edades de diferentes personas utilizando sus nombres como clave. Se agregan elementos utilizando el método Add y también se puede utilizar la sintaxis de indexación para agregar elementos. Se puede acceder a los valores utilizando la clave y se pueden verificar la existencia de una clave utilizando ContainsKey. También se muestra cómo obtener el valor asociado a una clave de forma segura utilizando TryGetValue. Finalmente, se elimina un elemento del diccionario utilizando Remove.

Los diccionarios son útiles cuando se necesita almacenar y acceder a elementos de manera rápida y eficiente utilizando una clave única. Se utilizan en una amplia variedad de escenarios, como la indexación de datos, la creación de diccionarios de sinónimos, la implementación de cachés, entre otros.

## Curso C#. Delegados predicados y lambdas I. Vídeo 67

En C#, un delegado es un tipo de dato que representa referencias a métodos. Es similar a un puntero a función en otros lenguajes de programación. Un delegado permite tratar los métodos como entidades que se pueden asignar a variables y pasar como parámetros, lo que proporciona una forma flexible de invocar métodos.

Los delegados son especialmente útiles en situaciones en las que se desea pasar un método como argumento a otro método, o cuando se necesita implementar eventos y devoluciones de llamada. Permiten encapsular la lógica de un método y proporcionan una forma segura de invocar ese método en un momento posterior.

La declaración de un delegado se realiza utilizando la palabra clave delegate y especificando la firma del método al que el delegado puede hacer referencia. Aquí tienes un ejemplo de declaración de delegado:

```csharp
delegate void MiDelegado(string mensaje);
```

En el ejemplo anterior, se declara un delegado llamado MiDelegado que puede hacer referencia a métodos que toman un parámetro de tipo string y no tienen un valor de retorno (void).

Una vez que se ha declarado un delegado, se pueden crear instancias de él y asignarle métodos que coincidan con la firma especificada. Luego, se puede invocar el delegado para ejecutar el método al que hace referencia. Aquí tienes un ejemplo de uso de un delegado:

```csharp
class Program
{
    static void Main()
    {
        MiDelegado delegado = Saludar;
        delegado("Hola, mundo");
    }

    static void Saludar(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
```

En este ejemplo, se crea una instancia del delegado MiDelegado y se le asigna el método Saludar. Luego, se invoca el delegado pasando un mensaje como argumento. La salida del programa será "Hola, mundo".

Los delegados también se utilizan comúnmente en el contexto de eventos, donde se pueden utilizar para suscribirse y notificar a los controladores de eventos cuando ocurre un evento específico.

En resumen, los delegados en C# son tipos de datos que representan referencias a métodos y permiten la invocación indirecta de métodos. Proporcionan una forma flexible de pasar métodos como argumentos y se utilizan ampliamente en eventos, devoluciones de llamada y programación orientada a eventos en general.

## Curso C#. Delegados predicados y lambdas II. Vídeo 68

Los delegados predicados en C# son un tipo especial de delegado que se utiliza para representar métodos que toman un argumento y devuelven un valor booleano. Estos delegados se utilizan principalmente para realizar pruebas o evaluaciones de condiciones en colecciones de datos.

En C#, el delegado predicado más comúnmente utilizado es Predicate<T>, que está definido en el espacio de nombres System. La firma del delegado Predicate<T> es la siguiente:

```csharp
delegate bool Predicate<T>(T obj);
```

El delegado Predicate<T> toma un argumento de tipo T y devuelve un valor booleano que indica si se cumple o no una determinada condición.

Aquí tienes un ejemplo de cómo se utiliza el delegado predicado Predicate<T> para realizar una prueba en una lista de números:

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

Predicate<int> esPar = numero => numero % 2 == 0;

List<int> numerosPares = numeros.FindAll(esPar);

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}
```

En este ejemplo, se crea una lista de números y se define un delegado predicado esPar que verifica si un número es par. Luego, se utiliza el método FindAll de la lista para encontrar todos los números que cumplen la condición del predicado y se almacenan en la lista numerosPares. Finalmente, se muestra cada número par en la consola.

El uso de delegados predicados como Predicate<T> ofrece una forma concisa y flexible de realizar pruebas en colecciones de datos y filtrar elementos en función de una condición específica. Puedes utilizar otros delegados predicados o incluso definir tus propios delegados predicados personalizados para adaptarse a tus necesidades.

## Curso C#. Delegados predicados y lambdas III. Vídeo 69

Las expresiones lambda en C# son funciones anónimas y compactas que se pueden utilizar para crear instancias de delegados o para escribir funciones de una manera más concisa. Las expresiones lambda permiten definir funciones de una línea sin necesidad de declarar un método separado.

La sintaxis básica de una expresión lambda en C# es la siguiente:

```cscsharps
(input) => expresión
(parametros) => expresión/bloque de sentencia
```

Donde input representa los parámetros de la función y expresión es el cuerpo de la función. La expresión lambda se puede asignar a un delegado o utilizar directamente en una llamada a un método.

Aquí tienes un ejemplo de una expresión lambda que calcula el cuadrado de un número:

```csharp
Func<int, int> calcularCuadrado = x => x * x;

int resultado = calcularCuadrado(5); // resultado será igual a 25
```

En este ejemplo, se define una expresión lambda x => x \* x que toma un parámetro x y devuelve su cuadrado. La expresión lambda se asigna a un delegado Func<int, int> que toma un entero como argumento y devuelve un entero. Luego, se utiliza el delegado para calcular el cuadrado del número 5, y el resultado se almacena en la variable resultado.

Las expresiones lambda también se pueden utilizar en métodos que aceptan delegados como argumentos, como en el siguiente ejemplo:

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

List<int> numerosPares = numeros.FindAll(x => x % 2 == 0);

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}
```

En este caso, se utiliza una expresión lambda en el método FindAll de la lista numeros para encontrar todos los números pares. La expresión lambda x => x % 2 == 0 verifica si un número es par y se utiliza como criterio de filtrado. Los números que cumplen la condición se almacenan en la lista numerosPares y se muestran en la consola.

Las expresiones lambda proporcionan una forma concisa y legible de escribir funciones en línea y se utilizan ampliamente en C# para mejorar la expresividad del código y simplificar tareas como filtrar, ordenar o transformar datos.

## Curso C#. Expresiones regulares I. Vídeo 70

Las expresiones regulares, también conocidas como regex (del inglés "regular expressions"), son patrones de texto que se utilizan para buscar y manipular cadenas de caracteres de manera eficiente. Son una herramienta poderosa para realizar operaciones de búsqueda, validación y manipulación de texto en diversos contextos, como procesamiento de texto, análisis léxico, validación de formatos, entre otros.

En C#, las expresiones regulares están disponibles a través del espacio de nombres System.Text.RegularExpressions. Este espacio de nombres proporciona la clase Regex, que se utiliza para trabajar con expresiones regulares.

Una expresión regular se compone de caracteres literales y metacaracteres especiales que definen un patrón de búsqueda. Estos patrones pueden incluir letras, dígitos, caracteres especiales, operadores de cuantificación y constructos de agrupación. Aquí hay algunos ejemplos de metacaracteres comunes:

- .: Coincide con cualquier carácter, excepto nueva línea.
- ^: Coincide con el inicio de una línea.
- $: Coincide con el final de una línea.
- \d: Coincide con un dígito.
- \w: Coincide con un carácter alfanumérico o guion bajo.
- [ ]: Coincide con un solo carácter que está dentro del rango o conjunto especificado.
- +: Coincide con uno o más repeticiones del elemento anterior.
- \*: Coincide con cero o más repeticiones del elemento anterior.
- ?: Coincide con cero o una repetición del elemento anterior.
- |: Coincide con una de las opciones separadas por el operador.

A continuación se muestra un ejemplo de cómo utilizar la clase Regex para realizar una búsqueda y reemplazo utilizando una expresión regular en C#:

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
static void Main()
{
string texto = "Hola, mi número de teléfono es 123-456-7890. Llámame.";

        // Buscar coincidencias de un número de teléfono en el texto
        string patron = @"\d{3}-\d{3}-\d{4}";
        MatchCollection coincidencias = Regex.Matches(texto, patron);

        // Mostrar las coincidencias encontradas
        foreach (Match coincidencia in coincidencias)
        {
            Console.WriteLine(coincidencia.Value);
        }

        // Reemplazar el número de teléfono por "XXXXX"
        string resultado = Regex.Replace(texto, patron, "XXXXX");
        Console.WriteLine(resultado);
    }

}
```

En este ejemplo, se utiliza la expresión regular \d{3}-\d{3}-\d{4} para buscar coincidencias de un número de teléfono en un texto. La clase Regex y el método Matches se utilizan para buscar todas las coincidencias y almacenarlas en una colección de Match. Luego, se utiliza un bucle foreach para mostrar cada coincidencia encontrada.

Además, se utiliza el método Replace de la clase Regex para reemplazar el número de teléfono encontrado por "XXXXX". El resultado del reemplazo se almacena en la variable resultado y se muestra en la consola.

Las expresiones regulares son una herramienta poderosa para manipular y buscar texto de manera eficiente. Sin embargo, pueden volverse complejas rápidamente, especialmente cuando se utilizan patrones más elaborados. Por lo tanto, es recomendable aprender y practicar para aprovechar al máximo su potencial.

## Curso C#. WPF Interfaces gráficas I. Vídeo 72

Las interfaces gráficas, también conocidas como GUI (del inglés "Graphical User Interface"), son formas visuales de interactuar con un programa de software. Proporcionan elementos gráficos, como ventanas, botones, menús y cuadros de diálogo, que permiten a los usuarios interactuar con el software de una manera más intuitiva y amigable.

Las interfaces gráficas facilitan la interacción con el software al proporcionar una representación visual de las funcionalidades y opciones disponibles. Los usuarios pueden realizar acciones como hacer clic en botones, ingresar datos en campos de texto, seleccionar elementos de una lista, arrastrar y soltar elementos, entre otras acciones, para interactuar con el programa.

En el desarrollo de software, las interfaces gráficas se implementan utilizando bibliotecas o frameworks específicos que proporcionan componentes y herramientas para construir interfaces de usuario. En el caso de C#, algunos de los frameworks más comunes para el desarrollo de interfaces gráficas son Windows Forms (WinForms) y Windows Presentation Foundation (WPF).

En una interfaz gráfica, se diseñan y organizan visualmente los elementos de la interfaz, y se definen las acciones y comportamientos que se desencadenarán al interactuar con esos elementos. Esto se logra utilizando un enfoque basado en eventos, donde se asocian acciones o métodos a eventos específicos, como hacer clic en un botón o cambiar el valor de un campo.

A través de las interfaces gráficas, los usuarios pueden interactuar con el software de una manera más intuitiva y visual, lo que mejora la experiencia de usuario y facilita la realización de tareas. Estas interfaces se utilizan en una amplia gama de aplicaciones, desde programas de productividad y herramientas de gestión, hasta aplicaciones de entretenimiento y juegos.

En resumen, las interfaces gráficas son representaciones visuales de un software que permiten a los usuarios interactuar con él de manera intuitiva y amigable. Estas interfaces se implementan utilizando frameworks y bibliotecas específicas, y se basan en eventos y acciones para facilitar la interacción del usuario con el software.
