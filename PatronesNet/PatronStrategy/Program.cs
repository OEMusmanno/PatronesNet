
#region Texto


Console.WriteLine("----------------------------------------------");
Console.WriteLine("Bienvenido a Bank");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("\n");

Cliente cliente = new Cliente();
Console.WriteLine("Ingrese su nombre: ");
cliente.ClienteNombre = Console.ReadLine();
cliente.SaldoCuenta = 2000;
bool salir = false;

var fci = new FondoComunDeInversion();
var pf = new PlazoFijo();
var inv = new Inversiones();
var cah = new CuentaAhorro();
var onb = new ObligacionesNegociables();

#endregion

Console.WriteLine($"Hola: {cliente.ClienteNombre}!");
while (salir == false)
{
    Console.WriteLine($"que operacion desea realizar?");
    Console.WriteLine($"1 - Depositar en Fondo comun de inversion");
    Console.WriteLine($"2 - Depositar en Plazo Fijo");
    Console.WriteLine($"3 - Depositar en Inversiones");
    Console.WriteLine($"4 - Depositar en Cuenta ahorro");
    Console.WriteLine($"5 - Depositar en Obligaciones Negociables");
    Console.WriteLine($"6 - Salir");
    Console.WriteLine("\n");

    var opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"Cual va a ser el monto");
    var monto = float.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            cliente.Operacion = fci;            
            break;
        case 2:
            cliente.Operacion = pf;
            break;
        case 3:
            cliente.Operacion = inv;
            break;
        case 4:
            cliente.Operacion = cah;
            break;
        case 5:
            cliente.Operacion = onb;
            break;
        default:
            salir = true;
            break;
    }

    cliente.Operacion.MontoInvertido += monto;

    Console.WriteLine("\n");
    cliente.realizarOperacion();

    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("\n");
}

