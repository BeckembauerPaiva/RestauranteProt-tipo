using Restaurante.Entities;
using Restaurante.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Services
{
    internal class PedidoService : Service<Pedido>
    {
        private PedidoRepository _repository;
        public PedidoService(PedidoRepository repository)
        {
            _repository = repository;
        }
        public override bool Adicionar(Pedido pedido)
        {
            _repository.AdicionarRepository(pedido);
            return true;
        }

        public override bool Remover(Pedido pedido)
        {
            _repository.RemoverRepository(pedido);
            return true;
        }
    }
}
