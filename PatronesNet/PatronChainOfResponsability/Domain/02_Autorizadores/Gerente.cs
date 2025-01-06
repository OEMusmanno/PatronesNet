using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Gerente:AbstractAutorizador
    {
        public override void AutorizarYAvanzar(Remito remito, Cliente cliente)
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Revision por Gerente, debe ser mayor a $2000 su sueldo");
            remito.AutorizadoPorGerente = cliente.ClienteSueldo > 2000;
            Console.WriteLine("Resultado = " + (remito.AutorizadoPorGerente ? "aprobado" : "desaprobado"));

            base.AutorizarYAvanzar(remito, cliente);
        }
    }
}
