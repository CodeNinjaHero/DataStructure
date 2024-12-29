# Ejercicio Sencillo: Gesti�n de Tareas

## Descripci�n:
Imagina que tienes una lista de tareas pendientes que se deben realizar en orden de llegada (FIFO).
Tienes que implementar un sistema que simule el procesamiento de tareas usando una **Queue**.

## Instrucciones:
1. Crea una cola (`Queue<T>`) para almacenar las tareas.
2. A�ade al menos 5 tareas a la cola.
3. Imprime las tareas de la cola en el orden en que ser�n procesadas.
4. Despu�s de procesar una tarea (eliminarla de la cola), imprime el nombre de la tarea procesada.
5. Cuando todas las tareas hayan sido procesadas, imprime un mensaje indicando que ya no hay m�s tareas pendientes.

## Ejemplo de salida esperada:
Tareas en la cola: Tarea 1 Tarea 2 Tarea 3 Tarea 4 Tarea 5

Procesando: Tarea 1 Procesando: Tarea 2 Procesando: Tarea 3 Procesando: Tarea 4 Procesando: Tarea 5

No hay m�s tareas pendientes.


## Pistas:
- Usa `Enqueue()` para a�adir tareas a la cola.
- Usa `Dequeue()` para procesar (eliminar) las tareas.
- Usa `Peek()` si deseas ver la tarea al frente de la cola sin eliminarla.


