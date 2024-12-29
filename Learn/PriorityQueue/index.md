# Teor�a B�sica: Uso de `PriorityQueue` en C#

## �Qu� es una Priority Queue?
Una **Priority Queue (cola de prioridad)** es una estructura de datos que permite almacenar 
elementos junto con una prioridad asociada. 
Los elementos con mayor prioridad (generalmente el n�mero m�s bajo) se procesan antes que 
aquellos con menor prioridad.

En C#, puedes implementar una cola de prioridad personalizada o usar la clase 
`PriorityQueue<TElement, TPriority>` que se incluye en .NET 6 y versiones posteriores.

---

## Caracter�sticas Clave de una Priority Queue
1. **Ordenaci�n por Prioridad:**
   - Cada elemento tiene una prioridad asociada.
   - Los elementos con mayor prioridad se extraen primero.
   - En caso de empate en la prioridad, se puede respetar el orden de llegada.

2. **Operaciones Comunes:**
   - **Insertar elementos (`Enqueue`)**: A�adir un elemento junto con su prioridad.
   - **Eliminar elementos (`Dequeue`)**: Extraer el elemento con mayor prioridad.
   - **Consultar el pr�ximo elemento (`Peek`)**: Obtener el elemento con mayor prioridad sin eliminarlo.

3. **Implementaci�n Interna:**
   - Las colas de prioridad suelen implementarse usando estructuras como **heaps** para optimizar el rendimiento de las operaciones.

---

## Clase `PriorityQueue` en C#

La clase `PriorityQueue<TElement, TPriority>` de .NET 6 permite trabajar con colas de 
prioridad de manera sencilla. Aqu�, `TElement` es el tipo de los elementos, y `TPriority` 
es el tipo de la prioridad.

### Propiedades y M�todos
- `Enqueue(TElement element, TPriority priority)`: Agrega un elemento con su prioridad.
- `Dequeue()`: Devuelve y elimina el elemento con mayor prioridad.
- `Peek()`: Devuelve el elemento con mayor prioridad sin eliminarlo.
- `Count`: Devuelve el n�mero de elementos en la cola.

---