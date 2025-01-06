namespace PatronComposite._02_Cuentas
{
    public class Rol : AccesoBase
    {
        private readonly List<AccesoBase> Accesos = new();

        public Rol(string nombre) : base(nombre) { }

        public void Agregar(AccesoBase acceso)
        {
            Accesos.Add(acceso);
        }

        public void Eliminar(AccesoBase acceso)
        {
            Accesos.Remove(acceso);
        }

        public override void Mostrar(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + $"Rol: {Nombre}");
            foreach (var acceso in Accesos)
            {
                acceso.Mostrar(nivel + 2);
            }
        }

        public override bool TieneAcceso(string recurso)
        {
            foreach (var acceso in Accesos)
            {
                if (acceso.TieneAcceso(recurso))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
