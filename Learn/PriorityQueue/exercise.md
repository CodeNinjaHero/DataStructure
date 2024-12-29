# Ejercicio: Gestor Genérico de Colas Prioritarias

## Descripción
Imagina que estás desarrollando un sistema para gestionar tareas con diferentes niveles de prioridad. 
Cada tarea tiene un nivel de prioridad y un contenido asociado. 
Tu objetivo es implementar una clase genérica que funcione con cualquier tipo de dato y que gestione 
elementos según su prioridad.

---

## Requisitos

1. **Crea una interfaz genérica `IPriorityQueue<T>`** con los siguientes métodos:
   - `void Enqueue(T item, int priority)`: Añade un elemento con una prioridad específica.
   - `T Dequeue()`: Elimina y devuelve el elemento con la mayor prioridad 
	- (el número más bajo representa la prioridad más alta).
   - `T Peek()`: Devuelve el elemento con la mayor prioridad sin eliminarlo.
   - `int Count()`: Devuelve el número de elementos en la cola.

2. **Implementa la interfaz en una clase `PriorityQueue<T>`**.
   - Almacena los elementos y sus prioridades internamente usando una lista o una estructura similar.
   - Asegúrate de que los elementos siempre se extraigan en orden de prioridad (mayor prioridad primero).
   - Maneja correctamente casos de empate en prioridades (puedes procesarlos por orden de llegada).

3. **Añade validaciones**:
   - Lanza una excepción si intentas extraer un elemento de una cola vacía.

4. **Sobrescribe el método `ToString`** para devolver todos los elementos de la cola junto con sus prioridades.

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
