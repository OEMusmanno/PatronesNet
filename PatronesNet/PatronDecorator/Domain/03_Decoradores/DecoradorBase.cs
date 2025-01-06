using PatronDecorator.Domain.Base;

namespace PatronDecorator.Domain._03_Decoradores
{
    public abstract class DecoradorBase : CuentaBancaria
    {
        public DecoradorBase(string cliente, CuentaBancaria cuentaBancaria) : base(cliente)
        {
            this.cuentaBancaria = cuentaBancaria;
        }

        protected CuentaBancaria cuentaBancaria;

    }
}
