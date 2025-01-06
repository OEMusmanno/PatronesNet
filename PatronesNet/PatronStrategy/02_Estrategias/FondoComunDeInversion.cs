namespace PatronStrategy._02_Estrategias
{
    public class FondoComunDeInversion : OperacionAbstract
    {

        public void CalculoDeCostoDeOperacion(Cliente cliente)
        {
            base.CalculoDeCostoDeOperacion(cliente);
            var total = MontoInvertido * 0.00032f;
            cliente.SaldoCuenta -= total;
            Console.WriteLine($"Costo extra por elejir Fondo Comun De Inversion es de: ${total}");
        }

        public void CalculoDeInteres(Cliente cliente)
        {
            base.CalculoDeCostoDeOperacion(cliente);
            var total = MontoInvertido * 0.0232f;
            cliente.SaldoCuenta += total;
            Console.WriteLine($"Interes extra por elejir Fondo Comun De Inversion es de: ${total}");
        }

        public override void CalculoTotalDeOperacion(Cliente cliente, int DiasOperacion)
        {

            Console.WriteLine($"Monto Invertido Total ${MontoInvertido}");
            CalculoDeCostoDeOperacion(cliente);
            CalculoDeInteres(cliente);
            Console.WriteLine($"Su nuevo saldo: ${cliente.SaldoCuenta}");
        }
    }
}
