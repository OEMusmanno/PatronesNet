using PatronState.Domain.Extras;

namespace PatronState.Domain._01_Base
{
    public interface IEstado
    {       
        public void Deposito(Cliente cliente, float monto);
        public void Extraccion(Cliente cliente, float monto);
    }
}
