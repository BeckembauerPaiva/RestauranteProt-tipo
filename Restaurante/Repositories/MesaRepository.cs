using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Entities;
using Restaurante.Services;

namespace Restaurante.Repositories
{
    public class MesaRepository : Repository<Mesa>
    {
        public List<Mesa> Mesas { get; set; } = new List<Mesa>();

        public MesaRepository()
        {
        }
        



        public override bool AdicionarRepository(Mesa mesa)
        {


            Mesas.Add(mesa);
            return true;

        }

        public override bool RemoverRepository(Mesa mesa)//nao remove      (testar)
        {

           Mesas.Remove(mesa);

            return true;


        }
        public void ListarMesas()
        {
            Console.WriteLine("Lista de mesas");
            foreach (Mesa mesa in Mesas)
            {
                Console.WriteLine($"Mesa: {mesa.ToString()}");
            }
        }

    }
}
