System.Console.WriteLine("============================================");
System.Console.WriteLine("     MANIPULACIÓN DE CADENAS Y ARREGLOS");
System.Console.WriteLine("============================================");

//Manipular cadenas de texto
string textoBase = "Sistema de Programación en CSharp y Python";
System.Console.WriteLine($"Original: {textoBase}");

//Limpiar espacios y mayúsculas
string textoLimpio = textoBase.Trim().ToUpper();
System.Console.WriteLine($"Trim y Upper: {textoLimpio}");

//Extraer PROGRAMACIÓN
string subcadena = textoLimpio.Substring(11,12);
System.Console.WriteLine($"Substring: {subcadena}");

//Buscar posición
int posicion =textoLimpio.IndexOf("CSHARP");
System.Console.WriteLine($"IndexOf 'CSharp': Índice {posicion}");

//Sustituir texto
string reemplazado = textoLimpio.Replace("PYTHON", "JAVA");
System.Console.WriteLine($"Replace: {reemplazado}");

//Dividir por espacios (con arreglo)
string [] palabras = reemplazado.Split(' ');
System.Console.WriteLine("Split - Palabras resultantes: ");
foreach(string palabra in palabras)
{
    System.Console.WriteLine($"- {palabra}");
}
System.Console.WriteLine("Presione cualquier tecla para continuar...");
Console.ReadKey();