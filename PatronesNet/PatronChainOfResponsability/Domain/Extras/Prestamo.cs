namespace PatronChainOfResponsability.Domain.Extras
{
    public class Prestamo
    {
        public bool AutorizadoPorDirector { get; set; }
        public bool AutorizadoPorGerente { get; set; }
        public bool AutorizadoPorLider { get; set; }
        public bool AutorizadoPorEmpleado { get; set; }

        public bool Aprobado { get { return AutorizadoPorEmpleado && AutorizadoPorLider && AutorizadoPorGerente; }}
    }
}
