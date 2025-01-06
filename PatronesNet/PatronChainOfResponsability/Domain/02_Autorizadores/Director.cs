using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Director : AbstractAutorizador
    {      

        public override void AutorizarYAvanzar(Remito remito, Cliente cliente)
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Revision por Director, si los anteriores aprobaron, yo apruebo");            
            remito.AutorizadoPorDirector = remito.Aprobado;
            if (remito.AutorizadoPorDirector)
            {
                Console.WriteLine("Su prestamos resulto: Aprobado :)");
                Console.WriteLine("\n");
                Console.WriteLine("Recuerde, Si deja de pagar, una agente lo visitara :)");
            }
            else {
                Console.WriteLine("Su prestamos resulto: Desaprobado :)");
                Console.WriteLine("\n");
                Console.WriteLine("Lastima, trabaje mas y vuelva! :)");
            }
            Console.WriteLine("\n");

            Console.WriteLine("----------------------------------------------");
            base.AutorizarYAvanzar(remito, cliente);
        }
    }
}
