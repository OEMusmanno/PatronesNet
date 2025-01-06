using PatronState.Domain._01_Base;
using PatronState.Domain.Extras;

namespace PatronState.Domain._02_Estados
{
    public class EstadoHabilitado : IEstado
    {
        public void Deposito(Cliente cliente, float monto)
        {
            cliente.SaldoCuenta += monto;
            Console.WriteLine("Deposito con exito!");
            Console.WriteLine($"nuevo saldo de: {cliente.SaldoCuenta}");
        }

        public void Extraccion(Cliente cliente, float monto)
        {
            cliente.SaldoCuenta -= monto;           
            if (cliente.SaldoCuenta < 0)
            {
                Console.WriteLine("Cuidado, usted ahora se encuentra en sobre girado, trate de depositar sino se hara deudor");
                Console.WriteLine($"nuevo saldo de: {cliente.SaldoCuenta}");
                cliente.EstadoDeCliente = new EstadoSobreGirado();
            }
            else
            {

                Console.WriteLine("Extraccion con exito!");
                Console.WriteLine($"nuevo saldo de: {cliente.SaldoCuenta}");
            }
        }
        public override string ToString() { return "Habilitado"; }
    }
}
