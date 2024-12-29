# Ejercicio: Gestor Gen�rico de Colas Prioritarias

## Descripci�n
Imagina que est�s desarrollando un sistema para gestionar tareas con diferentes niveles de prioridad. 
Cada tarea tiene un nivel de prioridad y un contenido asociado. 
Tu objetivo es implementar una clase gen�rica que funcione con cualquier tipo de dato y que gestione 
elementos seg�n su prioridad.

---

## Requisitos

1. **Crea una interfaz gen�rica `IPriorityQueue<T>`** con los siguientes m�todos:
   - `void Enqueue(T item, int priority)`: A�ade un elemento con una prioridad espec�fica.
   - `T Dequeue()`: Elimina y devuelve el elemento con la mayor prioridad 
	- (el n�mero m�s bajo representa la prioridad m�s alta).
   - `T Peek()`: Devuelve el elemento con la mayor prioridad sin eliminarlo.
   - `int Count()`: Devuelve el n�mero de elementos en la cola.

2. **Implementa la interfaz en una clase `PriorityQueue<T>`**.
   - Almacena los elementos y sus prioridades internamente usando una lista o una estructura similar.
   - Aseg�rate de que los elementos siempre se extraigan en orden de prioridad (mayor prioridad primero).
   - Maneja correctamente casos de empate en prioridades (puedes procesarlos por orden de llegada).

3. **A�ade validaciones**:
   - Lanza una excepci�n si intentas extraer un elemento de una cola vac�a.

4. **Sobrescribe el m�todo `ToString`** para devolver todos los elementos de la cola junto con sus prioridades.

5. **Crea un programa de prueba** que gestione tareas de diferentes tipos, como cadenas, enteros y objetos personalizados.

---

## Ejemplo de Uso

```csharp
PriorityQueue<string> tareas = new PriorityQueue<string>();
tareas.Enqueue("Revisar correos", 2);
tareas.Enqueue("Completar informe", 1);
tareas.Enqueue("Responder llamadas", 3);

Console.WriteLine(tareas); 
// Salida esperada: [Completar informe (1), Revisar correos (2), Responder llamadas (3)]

Console.WriteLine(tareas.Dequeue()); 
// Salida esperada: Completar informe

Console.WriteLine(tareas.Peek()); 
// Salida esperada: Revisar correos

Console.WriteLine(tareas.Count()); 
// Salida esperada: 2
