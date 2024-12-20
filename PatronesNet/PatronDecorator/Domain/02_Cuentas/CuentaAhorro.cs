using PatronDecorator.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.Domain.Decoradores
{
    public class CuentaAhorro : CuentaBancaria
    {
        public CuentaAhorro(string cliente) : base(cliente)
        {
        }

        public override int Costo => 10;

        public override string Descripcion => "Es una cuenta ahorro y tiene adicionales como ser ";

    }
}
