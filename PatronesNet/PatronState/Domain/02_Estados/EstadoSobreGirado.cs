using PatronState.Domain._01_Base;
using PatronState.Domain.Extras;

namespace PatronState.Domain._02_Estados
{
    public class EstadoSobreGirado : IEstado
    {
        public void Deposito(Cliente cliente, float monto)
        {
            cliente.SaldoCuenta += monto;
            if (cliente.SaldoCuenta > 0)
            {
                Console.WriteLine("Felicidades, usted esta habilitado!");
                Console.WriteLine($"nuevo saldo de: {cliente.SaldoCuenta}");
                cliente.EstadoDeCliente = new EstadoHabilitado();
            }
            else
            {
                Console.WriteLine("Se le informa que si no paga en la siguiente operacion, sera deudor");
            }
        }

        public void Extraccion(Cliente cliente, float monto)
        {
            Console.WriteLine("lamentamos informar que ahora usted es un deudor");
            cliente.EstadoDeCliente = new EstadoDeudor();
        }

        public override string ToString() { return "Sober Girado"; }
    }
}
