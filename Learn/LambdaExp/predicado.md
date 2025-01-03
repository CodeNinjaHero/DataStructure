# Predicado en C#

En C#, un predicado es un delegado que representa un método que toma un único parámetro y devuelve un valor booleano (true o false). 
Se utiliza para evaluar una condición sobre un objeto y es comúnmente empleado en operaciones como búsquedas, filtros o verificaciones.

---
## Definición
Un predicado en C# se define utilizando el delegado genérico Predicate<T>, donde T es el tipo del objeto que será evaluado.

```csharp
public delegate bool Predicate<T>(T obj);
```

---
## Características principales:
- Firma: Un predicado siempre devuelve un valor booleano (bool).
- Uso común: Se utiliza con métodos que necesitan condiciones, como List<T>.Find, List<T>.FindAll, etc.
- Sintaxis simplificada: Se puede implementar como métodos anónimos, expresiones lambda o métodos nombrados.

---
Ejemplo 1: Usar un predicado para encontrar un elemento en una lista
```csharp
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Usamos un predicado para encontrar el primer número mayor que 3
        int result = numbers.Find(IsGreaterThanThree);

        Console.WriteLine(result); // Salida: 4
    }

    static bool IsGreaterThanThree(int number)
    {
        return number > 3;
    }
```