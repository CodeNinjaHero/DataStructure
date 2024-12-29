# Concepto de Queue

## �Qu� es una Queue?
Una **Queue (cola)** es una estructura de datos lineal que sigue el principio 
**FIFO (First In, First Out)**, es decir, el primer elemento que entra es el primero que sale. 
Es similar a una fila en la vida real, donde las personas que llegan primero son atendidas primero.

---

## Caracter�sticas Clave de una Queue
1. **FIFO:** Los elementos se procesan en el orden en que se insertan.
2. **Operaciones Principales:**
   - **Enqueue:** A�adir un elemento al final de la cola.
   - **Dequeue:** Eliminar y devolver el elemento al frente de la cola.
   - **Peek:** Consultar el elemento al frente de la cola sin eliminarlo.
3. **Capacidad Din�mica:** En lenguajes como C#, una cola puede crecer din�micamente si se usa la clase `Queue<T>`.

---

## Queue en C#
En C#, la clase `Queue<T>` est� disponible en el espacio de nombres `System.Collections.Generic`. 
Es una implementaci�n gen�rica que permite trabajar con cualquier tipo de datos.

### Propiedades y M�todos Comunes
1. **`Enqueue(T item)`**: A�ade un elemento al final de la cola.
2. **`Dequeue()`**: Devuelve y elimina el elemento al frente de la cola.
3. **`Peek()`**: Devuelve el elemento al frente de la cola sin eliminarlo.
4. **`Count`**: Devuelve el n�mero de elementos en la cola.
5. **`Clear()`**: Vac�a la cola.

---
