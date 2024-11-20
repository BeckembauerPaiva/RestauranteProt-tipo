using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Entities;
using Restaurante.Services;

namespace Restaurante.Repositories
{
    public abstract class Repository<T> where T : Entity
    {
        public abstract bool AdicionarRepository(T entity);

        public abstract bool RemoverRepository(T entity);
    }
}
