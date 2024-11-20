using Restaurante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Repositories
{


    public class GarcomRepository : Repository<Garcom>
    {
        public List<Garcom> Garcoms { get; set; } = new List<Garcom>();


        public override bool AdicionarRepository(Garcom garcom)
        {
           

            Garcoms.Add(garcom);
            return true;


        }

        public override bool RemoverRepository(Garcom garcom)
        {

           Garcoms.Remove(garcom);
            return true;
        }

        public void ListarGarcoms()
        {
            Console.WriteLine("Lista de garçoms:");
            foreach (Garcom garcom in Garcoms)
            {
                Console.WriteLine($"id: {garcom.Id} Nome: {garcom.Nome}");
            }
        }
    }
}
