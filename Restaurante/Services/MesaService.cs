using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Repositories;
using Restaurante.Entities;

namespace Restaurante.Services
{
    public class MesaService : Service<Mesa>
    {
        private MesaRepository _repository;

        public MesaService(MesaRepository mesarepository)
        {
            _repository = mesarepository;
        }

        public override bool Adicionar(Mesa mesa)
        {
           return _repository.AdicionarRepository(mesa);
             
        }

        public override bool Remover(Mesa mesa)
        {
           return _repository.RemoverRepository(mesa);

        }

      
    }
}
