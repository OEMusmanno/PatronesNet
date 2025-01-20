using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Empleado : AbstractAutorizador
    {
        public override void AutorizarYAvanzar(Prestamo prestamo, Cliente cliente)
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Revision por Empleado, debe ser mayor a $1000 su sueldo");
            prestamo.AutorizadoPorEmpleado = cliente.ClienteSueldo > 1000; 
            Console.WriteLine("Resultado = " + (prestamo.AutorizadoPorEmpleado ? "aprobado" : "desaprobado" ));

            base.AutorizarYAvanzar(prestamo, cliente);
        }
    }
}
