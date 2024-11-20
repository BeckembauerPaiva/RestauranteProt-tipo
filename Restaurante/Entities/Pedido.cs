using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Entities
{
    public class Pedido : Entity
    {
        public Mesa Mesa { get; set; }
        public List<Produto> Produtos { get; set; }

        public Pedido(Mesa mesa, List<Produto> produto)
        {
            Mesa = mesa;
            Produtos = produto;
        }
        public Pedido(Mesa mesa)
        {
            Mesa=mesa;
        }

        public void ListarPedido(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }


        }

        public override string ToString()
        {
            return $"Mesa: {Mesa} \n Lista de consumo:\n{ListarPedido} ";//revisar
        }
    }
}
