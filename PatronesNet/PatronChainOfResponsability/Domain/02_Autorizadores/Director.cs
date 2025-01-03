using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Director : AbstractAutorizador
    {      

        public override void AutorizarYAvanzar(Remito remito, Cliente cliente)
        {
            Console.WriteLine("Revision por Director, si los anteriores aprobaron, yo apruebo");            
            remito.AutorizadoPorDirector = remito.Aprobado;
            Console.WriteLine("Resultado = " + (remito.AutorizadoPorDirector ? "aprobado" : "desaprobado"));
            Console.WriteLine("\n");

            base.AutorizarYAvanzar(remito, cliente);
        }
    }
}
