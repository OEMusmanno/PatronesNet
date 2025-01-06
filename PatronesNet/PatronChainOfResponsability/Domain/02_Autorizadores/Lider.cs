using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Lider:AbstractAutorizador
    {
        public override void AutorizarYAvanzar(Remito remito, Cliente cliente)
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Revision por Lider, debe ser mayor a $1500 su sueldo");
            remito.AutorizadoPorLider = cliente.ClienteSueldo > 1500;
            Console.WriteLine("Resultado = " + (remito.AutorizadoPorLider ? "aprobado" : "desaprobado"));

            base.AutorizarYAvanzar(remito, cliente);
        }        
    }
}
