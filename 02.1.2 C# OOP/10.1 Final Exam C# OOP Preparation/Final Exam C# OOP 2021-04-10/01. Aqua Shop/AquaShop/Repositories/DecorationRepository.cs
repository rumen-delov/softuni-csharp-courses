﻿using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> decorations; // readonly?
        
        public DecorationRepository()
        {
            this.decorations = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models 
            => this.decorations.AsReadOnly();

        public void Add(IDecoration model)
        {
           this.decorations.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            return this.Models.FirstOrDefault(m => m.GetType().Name == type);
        }

        public bool Remove(IDecoration model)
        {
            return this.decorations.Remove(model);
        }
    }
}
