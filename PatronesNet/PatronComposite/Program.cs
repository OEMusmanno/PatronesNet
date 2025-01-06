
#region Texto


Console.WriteLine("----------------------------------------------");
Console.WriteLine("Bienvenido a Bank");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("\n");

Cliente cliente = new Cliente();
Console.WriteLine("Ingrese su nombre: ");
cliente.ClienteNombre = Console.ReadLine();
bool salir = false;

#endregion
 
//Es para ahorrar tiempo en la explicacion

#region Pre-CargaDeInfo 
// Crear permisos individuales
var permisoDepositar = new Permiso("Depositar Dinero", "Deposito");
var permisoRetirar = new Permiso("Retirar Dinero", "Extraccion");
var permisoAprobarPrestamos = new Permiso("Aprobar Préstamos", "OficinaPréstamos");
var permisoConsultar = new Permiso("Consultar Estado", "Consulta");

// Crear roles compuestos
var rolCajero = new Rol("Cajero");
var rolGerente = new Rol("Gerente");
var rolAdmin = new Rol("Administrador General");

// Agregar permisos a roles
rolCajero.Agregar(permisoDepositar);
rolCajero.Agregar(permisoRetirar);

rolGerente.Agregar(permisoAprobarPrestamos);
rolGerente.Agregar(permisoConsultar);

//Se puede anidar roles 
//rolGerente.Agregar(rolCajero); 

rolAdmin.Agregar(rolCajero);
rolAdmin.Agregar(rolGerente);
rolAdmin.Agregar(permisoConsultar);

cliente.Roles = rolAdmin;
#endregion

Console.WriteLine($"Hola: {cliente.ClienteNombre}!");
while (salir == false)
{
    Console.WriteLine($"Que desea realizar?");
    Console.WriteLine($"1 - Mostrar Accesos");
    Console.WriteLine($"2 - Acceder a un recurso");
    Console.WriteLine($"3 - Salir");
    Console.WriteLine("\n");

    var opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            cliente.Roles.Mostrar(0);
            break;
        case 2:
            Console.WriteLine("Ingrese el nombre del recurso que desea acceder");
            string recurso = Console.ReadLine();
            var resultado = cliente.Roles.TieneAcceso(recurso);
            Console.WriteLine(resultado == true ? "usted puede acceder" : "usted no puede acceder de momento");
            break;
        default:
            salir = true;
            break;
    }


    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("\n");
}

