using PatronDecorator.Domain.Base;

namespace PatronDecorator.Domain._03_Decoradores
{
    public class Seguro : DecoradorBase
    {
        public Seguro(string cliente, CuentaBancaria cuentaBancaria) : base(cliente, cuentaBancaria)
        {
        }

        public override int Costo => cuentaBancaria.Costo + 30;

        public override string Descripcion => string.Format($"{cuentaBancaria.Descripcion}, seguro");
    }
}
