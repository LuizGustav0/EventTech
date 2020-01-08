using System.Collections.Generic;
using System.Linq;
using Evento.Dominio.Contratos;
using Evento.Repositorio.Contexto;

namespace Evento.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly EventoContexto EventoContexto;

        public BaseRepositorio(EventoContexto eventoContexto)
        {
            EventoContexto = eventoContexto;
        }


        public void Adicionar(TEntity entity)
        {
            EventoContexto.Set<TEntity>().Add(entity);
            EventoContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            EventoContexto.Set<TEntity>().Add(entity);
            EventoContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return EventoContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return EventoContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            EventoContexto.Remove(entity);
            EventoContexto.SaveChanges();
        }

        public void Dispose()
        {
            EventoContexto.Dispose();
        }

    }
}
