namespace PatronComposite._01_Base
{
    public abstract class AccesoBase
    {
        public string Nombre { get; set; }
        protected AccesoBase(string nombre)
        {
            Nombre = nombre;
        }
        public abstract bool TieneAcceso(string area);

        public abstract void Mostrar(int nivel);

    }
}
