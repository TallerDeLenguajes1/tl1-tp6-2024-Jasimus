## ¿String es un tipo *por valor* o un tipo *por referencia*?
El tipo string de C# es un tipo *por referencia*, es decir, la variable es una referencia a algún dato guardado en el heap.

## ¿Qué secuencias de escape tiene el tipo string?
**@**: define un literal de cadena textual; interpreta las demás secuancias de escape **literalmente**.
**\\**: toma el siguiente caracter como un literal.
**\x0xxx**: secuencia de escape hexadecimal.
**\u0xxx**: secuencia de escape Unicode.
**""**: no se interpretan literalmente en un literal de cadena textual, sino que generan comillas dobles **"**.
**{{**: no se interpretan literalmente en un literal de cadena textual, sino que generan el caracter llave simple **{**.

## ¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?
Si se utiliza el carácter @ antes de una cadena de texto, se toma a la cadena como una _cadena textual_; si se utiliza el carácter $ antes de una cadena de texto, la cadena admite variables, que se deben encerrar entre llaves (**{}**).

