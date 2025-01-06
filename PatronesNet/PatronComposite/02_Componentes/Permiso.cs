using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PatronComposite._02_Cuentas
{
    public class Permiso : AccesoBase
    {
        private readonly string _recurso;

        public Permiso(string nombre, string recurso) : base(nombre)
        {
            _recurso = recurso;
        }

        public override bool TieneAcceso(string recurso)
        {
            return _recurso == recurso;
        }

        public override void Mostrar(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + $"Permiso: {Nombre}, Recurso: {_recurso}");
        }
    }
}
