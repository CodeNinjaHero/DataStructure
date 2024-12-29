# `Stack` en C#

## �Qu� es una Pila (Stack)?
Una **pila** (Stack) es una estructura de datos que sigue el principio **LIFO** (Last In, First Out), 
lo que significa que el �ltimo elemento a�adido es el primero en ser removido. 
Es como una pila de platos: cuando apilas platos, el �ltimo plato que agregas es el primero en 
ser retirado.

En C#, una pila se implementa mediante la clase `Stack<T>`, que es una colecci�n gen�rica.

## Caracter�sticas principales de una Pila:
- **LIFO** (Last In, First Out): El �ltimo elemento que entra es el primero en salir.
- **Operaciones b�sicas**:
  - **Push(T item)**: Agrega un elemento al final de la pila.
  - **Pop()**: Elimina y devuelve el elemento en la parte superior de la pila.
  - **Peek()**: Devuelve el elemento en la parte superior de la pila sin eliminarlo.
  - **Count**: Propiedad que devuelve el n�mero de elementos en la pila.

## M�todos Principales:
1. **`Push(T item)`**: 
   - Agrega un elemento al final de la pila.
   - Ejemplo: `stack.Push(10);`

2. **`Pop()`**: 
   - Elimina el elemento en la parte superior de la pila y lo devuelve.
   - Ejemplo: `int item = stack.Pop();`
   - **Nota**: Si la pila est� vac�a, se lanzar� una excepci�n `InvalidOperationException`.

3. **`Peek()`**: 
   - Devuelve el elemento en la parte superior de la pila sin eliminarlo.
   - Ejemplo: `int item = stack.Peek();`
   - **Nota**: Si la pila est� vac�a, se lanzar� una excepci�n `InvalidOperationException`.

4. **`Count`**: 
   - Propiedad que devuelve el n�mero de elementos en la pila.
   - Ejemplo: `int count = stack.Count;`


