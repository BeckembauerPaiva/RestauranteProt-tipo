

namespace Restaurante.Entities
{
    public class Mesa:Entity 
    {
        public int Numero { get; set; }
        public Mesa()
        {
            
        }
        public Mesa(int mesa)
        {
            Numero = mesa;  
        }

        public Mesa(Guid id,int mesa):base(id) 
        {
            Numero = mesa;
        }
        public override string ToString()
        {
            return "Mesa: " + Numero.ToString();
        }
    }
}
