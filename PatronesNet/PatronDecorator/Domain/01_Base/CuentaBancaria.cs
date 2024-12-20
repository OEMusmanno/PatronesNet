namespace PatronDecorator.Domain.Base
{
    public abstract class CuentaBancaria
    {
        public CuentaBancaria(string cliente)
        {
            Cliente = cliente;
        }

        public string Cliente { get; set; }
        public abstract int Costo { get; }
        public abstract string Descripcion { get; }

             

    }
}
