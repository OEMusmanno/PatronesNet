using PatronDecorator.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.Domain._03_Decoradores
{
    public class TarjetaGold: DecoradorBase
    {
        public TarjetaGold(string cliente, CuentaBancaria cuentaBancaria) : base(cliente, cuentaBancaria)
        {
        }

        public override int Costo => cuentaBancaria.Costo + 15;

        public override string Descripcion => string.Format($"{cuentaBancaria.Descripcion}, tarjeta gold");
    }
}
