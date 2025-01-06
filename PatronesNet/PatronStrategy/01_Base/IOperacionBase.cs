using PatronStrategy.Extras;

namespace PatronStrategy._01_Base
{
    public interface IOperacionBase
    {
        public void CalculoTotalDeOperacion(Cliente cliente, int DiasOperacion);
        public void CalculoDeInteres(Cliente cliente);
        public void CalculoDeCostoDeOperacion(Cliente cliente);
        public void CalculoDeBeneficioPorDias(Cliente cliente, int DiasOperacion);
    }
}
