# Predicado en C#

En C#, un predicado es un delegado que representa un m�todo que toma un �nico par�metro y devuelve un valor booleano (true o false). 
Se utiliza para evaluar una condici�n sobre un objeto y es com�nmente empleado en operaciones como b�squedas, filtros o verificaciones.

---
## Definici�n
Un predicado en C# se define utilizando el delegado gen�rico Predicate<T>, donde T es el tipo del objeto que ser� evaluado.

```csharp
public delegate bool Predicate<T>(T obj);
```

---
## Caracter�sticas principales:
- Firma: Un predicado siempre devuelve un valor booleano (bool).
- Uso com�n: Se utiliza con m�todos que necesitan condiciones, como List<T>.Find, List<T>.FindAll, etc.
- Sintaxis simplificada: Se puede implementar como m�todos an�nimos, expresiones lambda o m�todos nombrados.

---
Ejemplo 1: Usar un predicado para encontrar un elemento en una lista
```csharp
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Usamos un predicado para encontrar el primer n�mero mayor que 3
        int result = numbers.Find(IsGreaterThanThree);

        Console.WriteLine(result); // Salida: 4
    }

    static bool IsGreaterThanThree(int number)
    {
        return number > 3;
    }
```