using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Repositories
{
    public class PedidoRepository : Repository<Pedido>
    {
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public override bool AdicionarRepository(Pedido pedido)
        {
            Pedidos.Add(pedido);
            return true;
        }

        public override bool RemoverRepository(Pedido pedido)
        {
            Pedidos.Remove(pedido);
            return true;
        }

        public void ListarPedidos()
        {
            foreach (var pedido in Pedidos)
            {
                Console.WriteLine(pedido);
            }
        }
    }
}
