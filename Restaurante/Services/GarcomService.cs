using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante.Repositories;
using Restaurante.Entities;

namespace Restaurante.Services
{

    public class GarcomService : Service<Garcom>
    {
        private GarcomRepository _repository;//    garcom repository

        public GarcomService(GarcomRepository repository)// importante no PROGAM: costrutor para não perder dados
        {
            _repository = repository;
        }

        public override bool Adicionar(Garcom garcom)
        {
            _repository.AdicionarRepository(garcom);
            return true;
        }

        public override bool Remover(Garcom garcom)
        {
            _repository.RemoverRepository(garcom);
            return true;
        }
    }
}
