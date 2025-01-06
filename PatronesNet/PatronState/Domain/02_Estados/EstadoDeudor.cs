using PatronState.Domain._01_Base;
using PatronState.Domain.Extras;

namespace PatronState.Domain._02_Estados
{
    public class EstadoDeudor : IEstado
    {
        public void Deposito(Cliente cliente, float monto)
        {
            cliente.SaldoCuenta += monto;
            if (cliente.SaldoCuenta > 0) {
                cliente.EstadoDeCliente = new EstadoHabilitado();
                Console.WriteLine("Felicidades, saldo su deuda, ahora esta habilitado");
            }
        }

        public void Extraccion(Cliente cliente, float monto)
        {            
            if (cliente.SaldoCuenta < 0)
            {
                Console.WriteLine("No puede extraer mas dinero ya que es un deudor");
                cliente.EstadoDeCliente = new EstadoInHabilitado();
            }
        }

        public override string ToString() { return "Deudor"; }
    }
}
