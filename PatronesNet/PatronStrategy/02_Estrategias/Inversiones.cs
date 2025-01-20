namespace PatronStrategy._02_Estrategias
{
    internal class Inversiones : OperacionAbstract
    {

        public virtual void CalculoDeCostoDeOperacion(Cliente cliente)
        {
            var total = MontoInvertido * 0.1f;
            cliente.SaldoCuenta -= total;
            Console.WriteLine($"Costo extra es de: ${total}");
        }


        public override void CalculoTotalDeOperacion(Cliente cliente)
        {
            Console.WriteLine($"Monto Invertido Total ${MontoInvertido}");
            CalculoDeCostoDeOperacion(cliente);
            Console.WriteLine($"Su nuevo saldo: ${cliente.SaldoCuenta}");
        }

    }
}
