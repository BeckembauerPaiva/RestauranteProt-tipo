using Restaurante.Entities;
using Restaurante.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Services
{
    public class ProdutoService : Service<Produto>
    {
        private Repository<Produto> _repository;

        public ProdutoService(Repository<Produto> repository)
        {
            _repository = repository;
        }
        
        public override bool Remover(Produto entity)
        {
            _repository.RemoverRepository(entity);
            return true;

        }

        public override bool Adicionar(Produto entity)
        {
            _repository.AdicionarRepository(entity);
            return true;
        }
    }
}
