
namespace Restaurante.Entities
{
    public class Garcom : Entity
    {
        public string Nome { get; set; }

        public Garcom()
        {
            
        }
        public Garcom(string nome)
        {
            Nome = nome;
        }

        public Garcom(Guid id,string nome):base(id)//id automatico usando guid sem ser atribuido no program
        {
            Nome = nome;
            
        }
        public override string ToString()
        {
            return $"Id: {Id} Garçom: {Nome}\n";
        }
    }
}
