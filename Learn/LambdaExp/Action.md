# Action en C#
Un Action es un delegado que apunta a un método que no devuelve **ningún valor** (void). 
Puede recibir de 0 a 16 parámetros.

---
## Definición general:

```csharp
	public delegate void Action<in T1, in T2, ...>(T1 arg1, T2 arg2, ...);
```

---
## Características principales:
- Retorno: No devuelve ningún valor (void).
- Parámetros: Puede aceptar entre 0 y 16 parámetros.
- Se utiliza para realizar acciones o ejecutar lógica sin necesidad de obtener un valor de retorno.

---
### Ejemplo 1: Action con un solo parámetro
```csharp
	Action<string> greet = name => Console.WriteLine($"Hola, {name}!");
	greet("Andres"); // Salida: Hola, Andres!
```
### Ejemplo 2: Action con múltiples parámetros
```csharp
	Action<int, int> add = (a, b) => Console.WriteLine($"La suma es: {a + b}");
	add(3, 4); // Salida: La suma es: 7
```