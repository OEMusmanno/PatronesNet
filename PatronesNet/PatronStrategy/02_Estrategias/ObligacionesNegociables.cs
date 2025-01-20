namespace PatronStrategy._02_Estrategias
{
    internal class ObligacionesNegociables : OperacionAbstract
    {

        public override void CalculoDeCostoDeOperacion(Cliente cliente)
        {
            var total = MontoInvertido * 0.001f;
            cliente.SaldoCuenta -= total;
            Console.WriteLine($"Costo Base es de: ${total}");
        }

        public override void CalculoDeInteres(Cliente cliente)
        {
            var total = MontoInvertido * 365 * 0.01f;
            cliente.SaldoCuenta += total;
            Console.WriteLine($"Interes por 1 año de ON es de: ${total}");
        }

        public override void CalculoTotalDeOperacion(Cliente cliente)
        {
            Console.WriteLine($"Monto Invertido Total ${MontoInvertido}");
            CalculoDeCostoDeOperacion(cliente);
            CalculoDeInteres(cliente);
            Console.WriteLine($"Su nuevo saldo: ${cliente.SaldoCuenta}");
        }
    }
}
