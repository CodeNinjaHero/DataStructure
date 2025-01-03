# Func en C#
Un Func es un delegado que apunta a un m�todo que **devuelve un valor**. 
Puede aceptar de 0 a 16 par�metros, y **el �ltimo tipo gen�rico especifica el tipo del valor de retorno**.

---
## Definici�n general:
```csharp
	public delegate TResult Func<in T1, in T2, ..., out TResult>(T1 arg1, T2 arg2, ...);
```

---
## Caracter�sticas principales:
- Retorno: Siempre devuelve un valor, y el tipo de este valor es el �ltimo argumento gen�rico.
- Par�metros: Puede aceptar entre 0 y 16 par�metros.
- Se utiliza para evaluar l�gica o realizar c�lculos que devuelvan un valor.

---
### Ejemplo 1: Func sin par�metros
```csharp
	Func<int> getRandomNumber = () => new Random().Next(1, 100);
	Console.WriteLine(getRandomNumber()); // Ejemplo de salida: 42

```

### Ejemplo 2: Func con par�metros

```csharp
	Func<int, int, int> multiply = (x, y) => x * y;
	Console.WriteLine(multiply(3, 5)); // Salida: 15
```