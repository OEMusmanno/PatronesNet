using PatronStrategy._01_Base;

namespace PatronStrategy.Extras
{
    public class Cliente
    {
        public string ClienteNombre { get; set; }
        public float SaldoCuenta { get; set; }

        public OperacionAbstract Operacion { get; set; }

        public void realizarOperacion()
        {
            Operacion.CalculoTotalDeOperacion(this);
        }
    }
}
 