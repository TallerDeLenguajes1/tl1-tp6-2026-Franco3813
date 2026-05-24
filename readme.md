4)
¿String es una tipo por valor o un tipo por referencia?
En la mayoría de los lenguajes de programación modernos (como C#, Java, JavaScript o Python), un string es un tipo por referencia.Sin embargo, se comporta en la práctica como un tipo por valor debido a su inmutabilidad. Cuando intentas modificarlo, el sistema crea un nuevo objeto en lugar de alterar el original

¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape son combinaciones que comienzan con una barra invertida y se usan para representar caracteres especiales o no imprimibles dentro de un tipo de dato string

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Cuando se utiliza los caracteres @ y $ antes de una cadena de texto, generalmente es para dar instrucciones especiales al compilador sobre cómo procesar y formatear esa información.
Usar el $ antes de las comilllas permite insertar variables o expresiones directamente dentro del texto usando llaves {}. El compilador reemplaza esas llaves con el valor real de la variable.
El símbolo @ indica al compilador que ignore los caracteres de escape (como \n para salto de línea o \t para tabulación) y que trate el texto exactamente como fue escrito. También permite escribir textos que ocupen varias líneas.