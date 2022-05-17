
//bucle do while
string respuesta; //no necesito inicializarla
do
{
    Console.Clear(); //paso (1) - limpiar la pantalla

    Console.WriteLine("ingresá tu nombre: "); //paso (2) - pedir el nombre
    var nombre = Console.ReadLine();

    Console.WriteLine($"Hola {nombre}!"); //paso (3) - saludarlo

    Console.WriteLine("¿Deseas continuar? INGRESÁ--> 'S' para sí, 'N' para no <--"); //paso (4) - preguntar
    respuesta = Console.ReadLine();
}
while (respuesta.ToLower() == "s");


if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("programa finalizado correctamente.");
}
else
{
    Console.WriteLine("Opción no valida, ingresá nuevamente.");
}
