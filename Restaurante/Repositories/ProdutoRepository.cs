

using Restaurante.Entities;

namespace Restaurante.Repositories
{
    public class ProdutoRepository : Repository<Produto>//herança com generics <T> de Produto 
    {


        public List<Produto> Produtos {  get; set; }= new List<Produto>();

        public override bool AdicionarRepository(Produto produto)
        {
            
            
            Produtos.Add(produto);

            return true;
        }

        public override bool RemoverRepository(Produto produto)
        {
            
            var product = Produtos.FirstOrDefault(x => x.CodigoDeBarras == produto.CodigoDeBarras);
            if (product != null)
            {
                Produtos.Remove(product);
            }
            else { Console.WriteLine("Produto não encontrado"); }

            return true;
        }

        public void ListarProduct()
        {
            foreach (Produto p in Produtos)
            {
                Console.WriteLine(p);
            }
        }
    }
}
