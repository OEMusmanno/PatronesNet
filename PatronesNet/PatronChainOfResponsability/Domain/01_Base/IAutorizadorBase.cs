using PatronChainOfResponsability.Domain.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronChainOfResponsability.Domain._01_Base
{
    public interface IAutorizadorBase
    {
        IAutorizadorBase SetProximoAutorizador(IAutorizadorBase autorizador);
        void AutorizarYAvanzar(Remito remito, Cliente cliente);
    }
}
