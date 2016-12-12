Ejercicios de Programación en C#
===============

Estos ejercicios están organizados por nivel: básico e intermedio, y por tema. Cada uno de los ejemplos existe en un proyecto individual de Visual Studio. 

En cada nivel la carpeta "Inicial" contiene la versión inicial de cada proyecto.

## Temas C# Básico

- Fundamentos de C#
- Tipos predefinidos y control de flujo
- Clases y Objetos
- Control de Acceso
- Arreglos y `IEnumerable`
- Herencia
- Polimorfismo

## Temas C# Intermedio

- Delegados, Lambdas y Eventos
- Excepciones
- Strings
- Manejo de archivos
- Genéricos
- Colecciones
- LINQ

## Algunos ejemplos

### Constructores
```c#
public class CuentaBancaria
{
    public string NoCuenta { get; set; }
    public string Usuario { get; set; }
    public decimal Saldo { get; set; }       

    public CuentaBancaria(string noCuenta)
    {
        NoCuenta = noCuenta;
    }

    public CuentaBancaria(string noCuenta, string usuario)
        : this(noCuenta)
    {           
        Usuario = usuario;
    }

    public CuentaBancaria(string noCuenta, string usuario, decimal saldo)
        : this(noCuenta, usuario)
    {            
        Saldo = saldo;
    }

    // Constructor vacío
    public CuentaBancaria() { }
}
```

### Clase Array
```c#
int[] list = { 34, 72, 13, 44, 25, 30, 10 };
int[] temp = new int[list.Length];

// Genera una copia del arreglo
Array.Copy(list, temp, list.Length);

Console.Write("Arreglo Original: ");
MostrarArreglo(list);

// invierte el arreglo
Array.Reverse(temp);
Console.Write("Arreglo Invertido: ");
MostrarArreglo(temp);

// ordena el arreglo
Array.Sort(list);
Console.Write("Arreglo Ordenado: ");
MostrarArreglo(list);
 ```
 
### Strings
```c#
string cadena = "Esta es una cadena de prueba";
Console.WriteLine(cadena);
Console.WriteLine("Tamaño: " + cadena.Length);
Console.WriteLine("Mayúsculas: " + cadena.ToUpper());
Console.WriteLine("Minúsculas: " + cadena.ToLower());
// Uso de Replace para quitar espacios
Console.WriteLine("Replace: " + cadena.Replace(" ", ""));
Console.WriteLine("Carácter en índice 0: " + cadena[0]);
Console.WriteLine("Carácter en índice 1: " + cadena[1]);
// Subcadena de 8 caracteres a partir del índice 1
Console.WriteLine("Substring (1-8): " + cadena.Substring(1, 8)); 
 ```
 
### Escritura de archivos
```c#
using (var writer = new StreamWriter("prueba.txt"))
{
    Console.Write("Escritura a un archivo\nEscribe un mensaje: ");
    string str =  Console.ReadLine();
    while (String.Compare(str, "salir", true) != 0)
    {
        writer.WriteLine(str);
        Console.Write("Escribe un mensaje: ");
        str = Console.ReadLine();
    }                    
}
```

### LINQ
```c#
List<int> numeros = new List<int> { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

// Obtiene una lista solo con los elementos mayores a 4
var filtered = numeros.Where(n => n > 4);

// la cláusula order by ordena los valores originales en orden ascendente            
var sorted = numeros.OrderBy(n => n);

// ordena los resultados filtrados en orden descendente            
var sortFilteredResults = filtered.OrderByDescending(n => n);

```
