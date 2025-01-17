﻿namespace PatronStrategy._01_Base
{
    public abstract class OperacionAbstract : IOperacionBase
    {
        public float MontoInvertido { get; set; }

        public virtual void CalculoDeBeneficioPorDias(Cliente cliente)
        {
            Console.WriteLine($"Que tal {cliente.ClienteNombre}, Cuantos dias quiere mantener la operacion?");
            var dias = int.Parse(Console.ReadLine());
            var total = MontoInvertido * (dias * 0.2f);
            cliente.SaldoCuenta += total;
            Console.WriteLine($"Beneficio Base es de: ${total}");
        }

        public virtual void CalculoDeCostoDeOperacion(Cliente cliente)
        {
            var total = MontoInvertido * 0.001f;
            cliente.SaldoCuenta -= total;
            Console.WriteLine($"Costo Base es de: ${total}");
        }

        public virtual void CalculoDeInteres(Cliente cliente)
        {
            var total = MontoInvertido * 0.01f;
            cliente.SaldoCuenta += total;
            Console.WriteLine($"Interes Base es de: ${total}");
        }

        public virtual void CalculoTotalDeOperacion(Cliente cliente)
        {
            Console.WriteLine($"Monto Invertido Total ${MontoInvertido}");
            CalculoDeCostoDeOperacion(cliente);
            CalculoDeBeneficioPorDias(cliente);
            CalculoDeInteres(cliente);
            Console.WriteLine($"Su nuevo saldo: ${cliente.SaldoCuenta}");
        }
    }
}
