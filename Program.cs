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
System.Console.WriteLine("Presione cualquier tecla para continuar con el bloque 2...");
Console.ReadKey();

//Arreglos paralelos
Console.Clear();
System.Console.WriteLine("============================================");
System.Console.WriteLine("            ARREGLOS PARALELOS");
System.Console.WriteLine("============================================");

//Declaración de arreglos alineados por indice
string[] nombreEmpleados={"Anthony", "Jorge", "Emilia", "Marco", "Ellie"};
int[] edadEmpleados={23, 17, 28, 18, 13};

System.Console.WriteLine("Listado inicial de personal registrado:");
for(int i=0;i<nombreEmpleados.Length;i++)
{
    System.Console.WriteLine($"- Empleado: {nombreEmpleados[i]} | Edad: {edadEmpleados[i]} años");
}

//Busqueda por nombre asociado
System.Console.WriteLine("Ingrese el nombre del colaborador a buscar: ");
string nombreBuscar =Console.ReadLine()??"";
int indiceEncontrado=-1;
for(int i=0;i<nombreEmpleados.Length;i++)
{
    if(nombreEmpleados[i].Equals(nombreBuscar.Trim(),StringComparison.OrdinalIgnoreCase))
    {
        indiceEncontrado=i;
        break;
    }
}
if(indiceEncontrado!=-1)
{
    System.Console.WriteLine("¡Resultado encontrado!");
    System.Console.WriteLine($"Nombre: {nombreEmpleados[indiceEncontrado]}");
    System.Console.WriteLine(($"Edad correspondiente: {edadEmpleados[indiceEncontrado]}"));
}
else
{
    System.Console.WriteLine("El colaborador buscado no se encuentra en el registro de empleados");
}
System.Console.WriteLine("Presione cualquier tecla para continuar con el bloque 3...");
Console.ReadKey();