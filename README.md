# ExamenIngreso

¿C# permite herencia múltiple?
No.

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
Si se necesita que la Clase tenga sus propias implementaciones de metodos.

¿Qué implica una relación de Generalización entre dos clases?
Implica que una clase (clase derivada) hereda los métodos y atributos especificados por una clase (clase base).

¿Qué implica una relación de Implementación entre una clase y una interfaz?
La intefaz sirve de contrato para la clase, esta misma debera implentar todos los metodos definidos en la interfaz.

¿Qué diferencia hay entre la relación de Composición y la Agregación?
En la relación de Composición los objetos estan unidos fuertmente y uno no puede existir sin el otro, ejemplo si destuimos
un objeto (Escuela), otro objeto (Aulas) que está unido a él también será destruido. Ambos no pueden existir de forma independiente.
En la Agregación pasa lo contrario, podemos destruir un Objeto (Empleado), y su objeto ascoiado (Empresa) seguira existiendo.

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
V
Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 
F
Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada,
es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 
F
