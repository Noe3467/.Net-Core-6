
//clase martes 10 de mayo
//ciclo while (mientras)
// Console.WriteLine("cuántas vueltas queres dar?");
// var totalDeVueltas = int.Parse(Console.ReadLine());

// var contador = 0;
// while(contador < totalDeVueltas)
// {
//     contador ++; //contador = contador + 1
//     Console.WriteLine("Seguimos dando vueltas, vuelta número: " + contador);
// }

//ciclo while 

/*Console.WriteLine("cuántas vueltas queres dar?");
var respuesta = "S";
var contador = 0;

while (respuesta.ToUpper() != "N")
{
    contador ++; //contador=contador +1
    Console.WriteLine("Seguimos dando vueltas, vuelta número: " + contador);

    Console.WriteLine("Seguimos? (S/N)");
    respuesta = Console.ReadLine();
}
*/
//bucle for
    //declaracion           condición       paso(incremento/decremento)
/*for (var cantCaramelos = 0; cantCaramelos <= 12; cantCaramelos++)
{
    Console.WriteLine("Mi bolsita tiene " + cantCaramelos + " caramelos"); //la primera ejecución del for NO tiene incremento
}*/

var cantCaramelos = 0;
while (cantCaramelos <= 12)
{
    Console.WriteLine($"Mi bolsita tiene {cantCaramelos} caramelos"); //interpolación de string
    cantCaramelos ++;
}



