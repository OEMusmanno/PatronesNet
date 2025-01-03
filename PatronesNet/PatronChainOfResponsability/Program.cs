using PatronChainOfResponsability.Domain._02_Autorizadores;
using PatronChainOfResponsability.Domain.Extras;

#region Texto
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Bienvenido a Bank");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("\n");

var cliente = new Cliente();
Console.WriteLine("Ingrese su nombre: ");
cliente.ClienteNombre = Console.ReadLine();
Console.WriteLine("Ingrese su sueldo: ");
cliente.ClienteSueldo = float.Parse(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine($"Hola: {cliente.ClienteNombre}, usted solicito un prestamo,usted tiene un sueldo de ${cliente.ClienteSueldo.ToString()}. Realizaremos los chequeos y le informaremos");
Console.WriteLine("\n");
#endregion

var remito = new Remito();
var empleado = new Empleado();
var lider = new Lider();
var gerente = new Gerente();
var director = new Director();


//Seteamos la cadena
empleado.SetProximoAutorizador(lider).SetProximoAutorizador(gerente).SetProximoAutorizador(director);
empleado.AutorizarYAvanzar(remito, cliente);

//resultado
if (remito.AutorizadoPorDirector)
{
    Console.WriteLine($"Su prestamos resulto: aprobado");

    Console.WriteLine("\n");
    Console.WriteLine("Recuerde, Si deja de pagar, una agente lo visitara :)");
    Console.ReadLine();
}
else
{
    Console.WriteLine($"Su prestamos resulto: desaprobado");

    Console.WriteLine("\n");
    Console.WriteLine("Gracias Vuelva prontos! :)");
    Console.ReadLine();
}

