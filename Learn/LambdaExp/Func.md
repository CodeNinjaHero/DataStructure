# Func en C#
Un Func es un delegado que apunta a un método que **devuelve un valor**. 
Puede aceptar de 0 a 16 parámetros, y **el último tipo genérico especifica el tipo del valor de retorno**.

---
## Definición general:
```csharp
	public delegate TResult Func<in T1, in T2, ..., out TResult>(T1 arg1, T2 arg2, ...);
```

---
## Características principales:
- Retorno: Siempre devuelve un valor, y el tipo de este valor es el último argumento genérico.
- Parámetros: Puede aceptar entre 0 y 16 parámetros.
- Se utiliza para evaluar lógica o realizar cálculos que devuelvan un valor.

---
### Ejemplo 1: Func sin parámetros
```csharp
	Func<int> getRandomNumber = () => new Random().Next(1, 100);
	Console.WriteLine(getRandomNumber()); // Ejemplo de salida: 42

```

### Ejemplo 2: Func con parámetros

```csharp
	Func<int, int, int> multiply = (x, y) => x * y;
	Console.WriteLine(multiply(3, 5)); // Salida: 15
```