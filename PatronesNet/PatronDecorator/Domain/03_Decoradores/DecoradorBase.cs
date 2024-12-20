using PatronDecorator.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
