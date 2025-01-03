using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronChainOfResponsability.Domain.Extras
{
    public class Remito
    {
        public bool AutorizadoPorDirector { get; set; }
        public bool AutorizadoPorGerente { get; set; }
        public bool AutorizadoPorLider { get; set; }
        public bool AutorizadoPorEmpleado { get; set; }

        public bool Aprobado { get { return AutorizadoPorEmpleado && AutorizadoPorLider && AutorizadoPorGerente; }}
    }
}
