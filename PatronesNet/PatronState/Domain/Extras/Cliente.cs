using PatronState.Domain._01_Base;

namespace PatronState.Domain.Extras
{
    public class Cliente
    {
        public string ClienteNombre { get; set; }        
        public float SaldoCuenta { get; set; }        

        public IEstado EstadoDeCliente{ get; set; }   


    }
}
