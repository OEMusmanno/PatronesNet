using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Empleado : AbstractAutorizador
    {
        public override void AutorizarYAvanzar(Remito remito, Cliente cliente)
        {
            Console.WriteLine("Revision por Empleado, debe ser menor a 1000 su sueldo");
            remito.AutorizadoPorEmpleado = cliente.ClienteSueldo < 1000; 
            Console.WriteLine("Resultado = " + (remito.AutorizadoPorEmpleado ? "aprobado" : "desaprobado" ));
            Console.WriteLine("\n");

            base.AutorizarYAvanzar(remito, cliente);
        }
    }
}
