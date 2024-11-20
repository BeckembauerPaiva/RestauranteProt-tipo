

using System.Globalization;

namespace Restaurante.Entities
{
    public class Produto: Entity
    {
        
        public string Name { get; private set; }
        public double Preco { get; private set; }
        public string CodigoDeBarras { get; set; }

        public Produto(string name, double preco, string codigoDeBarras)//construtor opcional sem guid
        {
            Name = name;
            Preco = preco;
        }
        public Produto()
        {

        }

        public Produto(Guid id, string name, double preco, string codigoDeBarras) : base(id)//guid 
        {
            Name = name;
            Preco = preco;
            CodigoDeBarras = codigoDeBarras;
        }

        public override string ToString()
        {
            return $"Id: {Id} Nome: {Name} Preço: {Preco.ToString("F2",CultureInfo.InvariantCulture)} codigo de barras: {CodigoDeBarras}";
        }
    }
}
