using PatronDecorator.Domain.Base;

namespace PatronDecorator.Domain._03_Decoradores
{
    public class CajaSeguridad : DecoradorBase
    {
        public CajaSeguridad(string cliente, CuentaBancaria cuentaBancaria) : base(cliente, cuentaBancaria)
        {
        }

        public override int Costo => cuentaBancaria.Costo + 120;

        public override string Descripcion => string.Format($"{cuentaBancaria.Descripcion}, caja de seguridad");
    }
}
