using PatronDecorator.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.Domain.Decoradores
{
    public class CuentaCorriente: CuentaBancaria
    {
        public CuentaCorriente(string cliente) : base(cliente)
        {
        }

        public override int Costo => 15;

        public override string Descripcion => "Es una cuenta corriente y tiene adicionales como ser ";
    }
}
