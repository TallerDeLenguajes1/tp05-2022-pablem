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
    El caracter **@** convierte una cadena regular en una cadena textual (*verbatim string*). Es decir, 
    que las secuencias de escape se imprimen tal cual como aparecen.
    El caracter **$** identifica una cadena como cadena interpolada (*interpolated string*). Cuando una
    cadena interpolada se imprime, los elementos con expresiones de interpolación se reemplazan por las
    representaciones de cadena de los resultados de la expresión.
