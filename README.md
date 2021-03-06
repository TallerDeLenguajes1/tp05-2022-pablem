# Trabajo Práctico 5
## Ejercicios propuestos - C#

**Responder las siguientes preguntas en el archivo readme.md**

### ¿String es una tipo por valor o un tipo por referencia?
    Una cadena es un objeto de tipo String cuyo valor es texto. Internamente, el texto se almacena como una
    colección de sólo lectura de objetos Char.
    String es un tipo de referencia, pero los operadores de igualdad (== y !=) se definen para comparar los
    valores de objetos string y no las referencias. De esta forma, es más intuitivo comprobar la igualdad
    entre cadenas.
    Los operadores de C# que parecen modificar una cadena, en realidad devuelven los resultados en un nuevo
    objeto de cadena (se debe actuar con precaución al crear referencias a las cadenas).
### ¿Qué secuencias de escape tiene el tipo string?
<table>
<colgroup>
<col>
<col>
<col>
</colgroup>
<thead>
<tr>
<th><p>Secuencia de escape</p></th>
<th><p>Nombre del carácter</p></th>
<th><p>Codificación Unicode</p></th>
</tr>
</thead>
<tbody>
<tr>
<td><p>\'</p></td>
<td><p>Comilla simple</p></td>
<td><p>0x0027</p></td>
</tr>
<tr>
<td><p>\"</p></td>
<td><p>Comilla doble</p></td>
<td><p>0x0022</p></td>
</tr>
<tr>
<td><p>\\</p></td>
<td><p>Barra diagonal inversa</p></td>
<td><p>0x005C</p></td>
</tr>
<tr>
<td><p>\0</p></td>
<td><p>Null</p></td>
<td><p>0x0000</p></td>
</tr>
<tr>
<td><p>\a</p></td>
<td><p>Alerta</p></td>
<td><p>0x0007</p></td>
</tr>
<tr>
<td><p>\b</p></td>
<td><p>Retroceso</p></td>
<td><p>0x0008</p></td>
</tr>
<tr>
<td><p>\f</p></td>
<td><p>Avance de página</p></td>
<td><p>0x000C</p></td>
</tr>
<tr>
<td><p>\n</p></td>
<td><p>Nueva línea</p></td>
<td><p>0x000A</p></td>
</tr>
<tr>
<td><p>\r</p></td>
<td><p>Retorno de carro</p></td>
<td><p>0x000D</p></td>
</tr>
<tr>
<td><p>\t</p></td>
<td><p>Tabulación horizontal</p></td>
<td><p>0x0009</p></td>
</tr>
<tr>
<td><p>\U</p></td>
<td><p>Secuencia de escape Unicode para pares suplentes.</p></td>
<td><p>\Unnnnnnnn</p></td>
</tr>
<tr>
<td><p>\u</p></td>
<td><p>Secuencia de escape Unicode</p></td>
<td><p>\u0041 = "A"</p></td>
</tr>
<tr>
<td><p>\v</p></td>
<td><p>Tabulación vertical</p></td>
<td><p>0x000B</p></td>
</tr>
<tr>
<td><p>\x</p></td>
<td><p>Secuencia de escape Unicode similar a "\u" a excepción de la longitud variable.</p></td>
<td><p>\x0041 = "A"</p></td>
</tr>
</tbody>
</table>

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
    El caracter @ convierte una cadena regular en una cadena textual (verbatim string). Es decir, 
    que las secuencias de escape se imprimen tal cual como aparecen.
    El caracter $ identifica una cadena como cadena interpolada (interpolated string). Cuando una
    cadena interpolada se imprime, los elementos con expresiones de interpolación se reemplazan por las
    representaciones de cadena de los resultados de la expresión.

### Expresiones Regulares
**Busque en diferentes bibliografías que son y cómo funcionan las expresiones regulares.**

    Una expresión regular o regex, es una secuencia de caracteres que conforma un patrón de búsqueda.
    Se utilizan principalmente para la búsqueda de patrones de cadenas de caracteres u operaciones de
    sustituciones.
#### ¿Funcionan únicamente en C#?
    Inicialmente, el mecanismo era inherente al lenguaje de programación pero, con el tiempo, se ha ido
    incorporando el uso de expresiones regulares para facilitar programar la detección de ciertas cadenas.
    Los lenguajes lo han incorporado como funciones específicas sin incorporarlo a su sintaxis.
#### ¿En qué casos le parecen útiles? Enuncie al menos 3.
Las principales utilidades son:
+ Buscar patrones concretos de caracteres.
+ Validar el texto para garantizar que coincide con un patrón predefinido (como una dirección de correo electrónico).
+ Extraer, editar, reemplazar o eliminar subcadenas de texto.
+ Agregar cadenas extraídas en una colección para generar un informe.
#### ¿Cómo se hace uso de estas en C#?

La clase String incluye varios métodos de búsqueda y reemplazo de cadenas que puede usar cuando desee buscar cadenas literales en una cadena mayor. Las expresiones regulares son muy útiles cuando se desea buscar una de varias subcadenas en una cadena mayor o cuando se desea identificar patrones en una cadena, como se muestra en los siguientes ejemplos:

https://docs.microsoft.com/es-es/dotnet/standard/base-types/regular-expressions