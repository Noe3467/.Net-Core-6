

//1) Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que intente adivinarlo
Console.Writeline("ingresá un número");
var numUser = Console.ReadLine();


//3) Si el numero ingresado por el usuario es mayor avisarle que es muy grande y que intente de nuevo y que
do
{

    Console.Write("el número que ingresaste es demasiado grande, por favor intentá adivinarlo nuevamente")

}
while (numUser>numeroSecreto);

//4) Si el numero ingresado es menor al número avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.
do
{

    Console.Write("el número que ingresaste es demasiado chico, por favor intentá adivinarlo nuevamente")

}
while (numUser<numeroSecreto);


//5) Si el número ingresado coincide sacar el siguiente mensaje: "Felicitaciones, has adivinado el número secreto que era:  [numeroSecreto]" "Lo has logrado en [n] intentos!!"
if(numUser==numeroSecreto){
    Console.Writeline($"Felicitaciones, adivinaste el número secreto que era:  {numeroSecreto}, lo lograste en [n] intentos!!");
}

Nota:
//falta terminar
