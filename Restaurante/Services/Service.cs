


using Restaurante.Entities;

namespace Restaurante.Services
{
    public abstract class Service<T> where T : Entity
    {
        public abstract bool Adicionar(T entity);
        public abstract bool Remover(T entity);

    }
}
