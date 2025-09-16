** Qué hice? **

- Creeé un archivo para cada clase.

- Creé una clase Shape abstracta para heredar desde cada forma.

- Creé una clase ShapeReport para llamar a cada forma y armar el reporte.

- Unifiqué el idioma utilizado dentro del código a inglés.

- Creeé un diccionario con las traducciones para unificar los mensajes por idioma y poder agregar nuevos fácilmente.

- Agregué un proyecto API con Swagger muy rudimentario para poder consumir la clase ShaperReport utilizando un JSON sencillo.



********************

** Qué se podría agregar? **

- Si la complejidad del proyecto lo requiriera se podría pasar a una Clean Architecture:
    - DevelopmentChallenge.API (sin nada de lógica, solo los endpoints)
    - DevelopmentChallenge.Application (con toda la lógica, los casos de usos, el armado del Shape Report, etc.)
    - DevelopmentChallenge.Infrastructure (persistencia, repository, conexión a db si hubiera, etc.)
    - DevelopmentChallenge.Domain (con las clases de las formas)

- Tests faltantes para el controller




********************

EJEMPLO DE JSON PARA LA API:

{
  "language": 2,
  "shapes": [
    { "type": "square", "size": 5 },
    { "type": "circle", "size": 3 },
    { "type": "triangle", "size": 4 },
    { "type": "rectangle", "width": 2, "height": 6 }
  ]
}





{
  "language": 1,
  "shapes": [
    { "type": "triangle", "size": 2 },
    { "type": "rectangle", "width": 2, "height": 4 },
    { "type": "square", "size": 5 }
  ]
}