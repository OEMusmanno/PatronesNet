namespace PatronStrategy._02_Estrategias
{
    internal class PlazoFijo : OperacionAbstract
    {
        public virtual void CalculoDeBeneficioPorDias(Cliente cliente, int DiasOperacion)
        {
            base.CalculoDeBeneficioPorDias(cliente, DiasOperacion);
            var total = MontoInvertido * (DiasOperacion * 0.2f);
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
    }
}
