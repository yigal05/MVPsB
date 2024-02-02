# Cómo se ha usado el modelo MVP en este proyecto
Este documento proporciona una visión general de cómo se ha implementado el Modelo Vista Presentador (MVP) en el proyecto, centrándose en la creación de una interfaz que permite controlar una linterna en una pantalla oscura con elementos visuales relacionados con el personaje Batman.

## Descripción del Proyecto
El proyecto presenta una interfaz gráfica con una pantalla oscura, acompañada de una barra en la parte inferior que contiene dos botones. Estos botones permiten encender y apagar una linterna, que está representada mediante una sprite 2D de luz que ilumina en forma de murciélago permitiendo ver a batman.

## Uso del Modelo MVP
El Modelo Vista Presentador (MVP) se implementa de la siguiente manera en este proyecto:

### Modelo
En este contexto, el "Modelo" está representado por los scripts del proyecto. Estos scripts son responsables de alterar visualmente la interfaz en el momento adecuado. En el contexto de la linterna, los scripts pueden controlar la activación y desactivación de la luz, así como cualquier otro comportamiento relacionado con la interfaz.

### Vista
La "Vista" se refiere a la interfaz gráfica que el usuario puede ver. En este caso, la interfaz se crea utilizando UXML (User Interface XML). La pantalla oscura, la barra inferior y los botones para encender y apagar la linterna son elementos de la "Vista".

### Presentador
El "Presentador" es un objeto que contiene el script responsable de controlar la lógica de la interfaz. Además, incluye el elemento llamado "ui document" que actúa como intermediario entre el modelo y la vista, permitiendo la comunicación eficiente y organizada.

En resumen, el MVP se utiliza para dividir la interfaz en tres partes claves (Modelo, Vista y Presentador), facilitando así la gestión y manipulación de los datos y la interfaz gráfica de manera más eficiente en el proyecto.
