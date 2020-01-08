using Evento.Dominio.Contratos;
using Evento.Dominio.Entidades;
using Evento.Repositorio.Contexto;
using System.Linq;


namespace Evento.Repositorio.Repositorios
{
    public class ConvidadoRepositorio : BaseRepositorio<Convidado>, IConvidadoRepositorio
    {

        public ConvidadoRepositorio(EventoContexto eventoContexto) : base(eventoContexto)
        {
        }

        public Convidado Obter(string email)
        {
            return EventoContexto.Convidados.FirstOrDefault(u => u.Email == email);
        }
    }
}
