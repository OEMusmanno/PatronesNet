using PatronState.Domain._01_Base;
using PatronState.Domain.Extras;

namespace PatronState.Domain._02_Estados
{
    public class EstadoInHabilitado : IEstado
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
            else {
                Console.WriteLine("Se le informa que sigue inhabilitado hasta que salde sus deudas");
            }
        }

        public void Extraccion(Cliente cliente, float monto)
        {
            Console.WriteLine("Se le informa que sigue inhabilitado hasta que salde sus deudas");
        }
        public override string ToString() { return "Inhabilitado"; }
    }
}
