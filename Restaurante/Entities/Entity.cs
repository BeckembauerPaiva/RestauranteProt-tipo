﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Entities
{
    public abstract class Entity
    {
        public Entity(Guid id)
        {
            Id = id;
        }

        public Entity()
        {
            Id = Guid.NewGuid();
                    
        }

        public Guid Id { get; set; }
    }
}
