using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._01_Base
{
    public abstract class AbstractAutorizador : IAutorizadorBase
    {
        private IAutorizadorBase _proximoAutorizador;

        public IAutorizadorBase SetProximoAutorizador(IAutorizadorBase autorizador)
        {
            _proximoAutorizador = autorizador;
            return _proximoAutorizador;
        }
        public virtual void AutorizarYAvanzar(Remito remito, Cliente cliente)
        {
            if (_proximoAutorizador != null)
            {
                _proximoAutorizador.AutorizarYAvanzar(remito, cliente);
            }
        }
    }
}
