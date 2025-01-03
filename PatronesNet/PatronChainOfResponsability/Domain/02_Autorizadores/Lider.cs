using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Lider:AbstractAutorizador
    {
        public override void AutorizarYAvanzar(Remito remito, Cliente cliente)
        {
            Console.WriteLine("Revision por Lider, debe ser menor a 800 su sueldo");
            remito.AutorizadoPorLider = cliente.ClienteSueldo < 800;
            Console.WriteLine("Resultado = " + (remito.AutorizadoPorLider ? "aprobado" : "desaprobado"));
            Console.WriteLine("\n");

            base.AutorizarYAvanzar(remito, cliente);
        }        
    }
}
