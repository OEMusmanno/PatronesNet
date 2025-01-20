using PatronChainOfResponsability.Domain._01_Base;
using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._02_Autorizadores
{
    public class Gerente:AbstractAutorizador
    {
        public override void AutorizarYAvanzar(Prestamo prestamo, Cliente cliente)
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Revision por Gerente, debe ser mayor a $2000 su sueldo");
            prestamo.AutorizadoPorGerente = cliente.ClienteSueldo > 2000;
            Console.WriteLine("Resultado = " + (prestamo.AutorizadoPorGerente ? "aprobado" : "desaprobado"));

            base.AutorizarYAvanzar(prestamo, cliente);
        }
    }
}
