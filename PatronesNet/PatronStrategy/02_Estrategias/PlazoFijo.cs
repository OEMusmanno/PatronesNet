namespace PatronStrategy._02_Estrategias
{
    internal class PlazoFijo : OperacionAbstract
    {
        public virtual void CalculoDeBeneficioPorDias(Cliente cliente)
        {
            Console.WriteLine($"Que tal {cliente.ClienteNombre}, Cuantos dias quiere mantener la operacion?");
            var dias = int.Parse(Console.ReadLine());
            var total = MontoInvertido * (dias * 0.2f);
            cliente.SaldoCuenta += total;
            Console.WriteLine($"Beneficio extra es de: ${total}");
        }

        public virtual void CalculoDeCostoDeOperacion(Cliente cliente)
        {
            base.CalculoDeCostoDeOperacion(cliente);
            var total = MontoInvertido * 0.001f;
            cliente.SaldoCuenta -= total;
            Console.WriteLine($"Costo extra es de: ${total}");
        }

        public virtual void CalculoDeInteres(Cliente cliente)
        {
            base.CalculoDeInteres (cliente);
            var total = MontoInvertido * 0.01f;
            cliente.SaldoCuenta += total;
            Console.WriteLine($"Interes extra es de: ${total}");
        }
        public override void CalculoTotalDeOperacion(Cliente cliente)
        {
            Console.WriteLine($"Monto Invertido Total ${MontoInvertido}");
            CalculoDeCostoDeOperacion(cliente);
            CalculoDeBeneficioPorDias(cliente);
            CalculoDeInteres(cliente);
            Console.WriteLine($"Su nuevo saldo: ${cliente.SaldoCuenta}");
        }
    }
}
