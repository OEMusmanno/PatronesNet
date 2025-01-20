using PatronChainOfResponsability.Domain.Extras;

namespace PatronChainOfResponsability.Domain._01_Base
{
    public abstract class AbstractAutorizador 
    {
        private AbstractAutorizador _proximoAutorizador;

        public AbstractAutorizador SetProximoAutorizador(AbstractAutorizador autorizador)
        {
            _proximoAutorizador = autorizador;
            return _proximoAutorizador;
        }
        public virtual void AutorizarYAvanzar(Prestamo prestamo, Cliente cliente)
        {
            if (_proximoAutorizador != null)
            {
                _proximoAutorizador.AutorizarYAvanzar(prestamo, cliente);
            }
        }
    }
}
