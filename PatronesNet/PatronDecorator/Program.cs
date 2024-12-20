using PatronDecorator.Domain._03_Decoradores;
using PatronDecorator.Domain.Base;
using PatronDecorator.Domain.Decoradores;

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Bienvenido a Bank");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("\n");

Console.WriteLine("Ingrese su nombre: ");
string clienteNombre = Console.ReadLine();

Console.WriteLine("\n");

CuentaBancaria cuentaBancaria = new CuentaCorriente(clienteNombre);
Console.WriteLine("Bienvenido " + cuentaBancaria.Cliente);

cuentaBancaria = new Prestamo(clienteNombre, cuentaBancaria);
cuentaBancaria = new Seguro(clienteNombre, cuentaBancaria);
cuentaBancaria = new TarjetaBlack(clienteNombre, cuentaBancaria);


Console.WriteLine("Sus productos: \n" + cuentaBancaria.Descripcion);
Console.WriteLine("\n");
Console.WriteLine("usted nos debe $" + cuentaBancaria.Costo);
Console.WriteLine("\n");
Console.WriteLine("Recuerde, Si deja de pagar, una agente lo visitara :)");
Console.ReadLine();
