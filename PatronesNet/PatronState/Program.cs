using PatronState.Domain._02_Estados;
using PatronState.Domain.Extras;

#region Texto

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Bienvenido a Bank");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("\n");

Cliente cliente = new Cliente();
Console.WriteLine("Ingrese su nombre: ");
cliente.ClienteNombre = Console.ReadLine();
cliente.SaldoCuenta = 2000;
cliente.EstadoDeCliente = new EstadoHabilitado();
bool salir=false;

#endregion

while (salir == false)
{ 
    Console.WriteLine($"Hola: {cliente.ClienteNombre}!");
    Console.WriteLine($"que operacion desea realizar?");
    Console.WriteLine($"1 - Depositar");
    Console.WriteLine($"2 - Extraer");
    Console.WriteLine($"3 - Salir");
   

    var opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------");
    switch (opcion)
    {
        case 1:
        Console.WriteLine($"Que tal {cliente.ClienteNombre}, tiene un estado de {cliente.EstadoDeCliente}, cuanto quiere operar!");
            cliente.EstadoDeCliente.Deposito(cliente, float.Parse(Console.ReadLine()));
            break;
        case 2:
            Console.WriteLine($"Que tal {cliente.ClienteNombre}, tiene un estado de {cliente.EstadoDeCliente}, cuanto quiere extraer!");
            cliente.EstadoDeCliente.Extraccion(cliente, float.Parse(Console.ReadLine()));
            break;
        case 3:
            salir = true;
            break;
        default:
            salir = true;
            break;
    }

    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("\n");
}

