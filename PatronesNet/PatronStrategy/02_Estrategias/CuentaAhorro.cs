﻿namespace PatronStrategy._02_Estrategias
{
    public class CuentaAhorro : OperacionAbstract
    {

        public void CalculoDeInteres(Cliente cliente)
        {
            base.CalculoDeInteres(cliente);
            var total = MontoInvertido * 0.0002f;
            cliente.SaldoCuenta += total;
            Console.WriteLine($"Interes extra por elejir cuentaAhorro es de: ${total}");
        }

        public override void CalculoTotalDeOperacion(Cliente cliente, int DiasOperacion)
        {

            Console.WriteLine($"Monto Invertido Total ${MontoInvertido}");
            CalculoDeBeneficioPorDias(cliente, DiasOperacion);
            CalculoDeInteres(cliente);
            Console.WriteLine($"Su nuevo saldo: ${cliente.SaldoCuenta}");
        }
    }
}