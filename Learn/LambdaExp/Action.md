# Action en C#
Un Action es un delegado que apunta a un m�todo que no devuelve **ning�n valor** (void). 
Puede recibir de 0 a 16 par�metros.

---
## Definici�n general:

```csharp
	public delegate void Action<in T1, in T2, ...>(T1 arg1, T2 arg2, ...);
```

---
## Caracter�sticas principales:
- Retorno: No devuelve ning�n valor (void).
- Par�metros: Puede aceptar entre 0 y 16 par�metros.
- Se utiliza para realizar acciones o ejecutar l�gica sin necesidad de obtener un valor de retorno.

---
### Ejemplo 1: Action con un solo par�metro
```csharp
	Action<string> greet = name => Console.WriteLine($"Hola, {name}!");
	greet("Andres"); // Salida: Hola, Andres!
```
### Ejemplo 2: Action con m�ltiples par�metros
```csharp
	Action<int, int> add = (a, b) => Console.WriteLine($"La suma es: {a + b}");
	add(3, 4); // Salida: La suma es: 7
```