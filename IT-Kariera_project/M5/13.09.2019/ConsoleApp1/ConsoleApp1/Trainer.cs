using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Trainer
    {
        public Trainer(IAnimal entity)
        {
            this.Entity = entity;
        }

        private IAnimal entity;

        internal IAnimal Entity { get => entity; set => entity = value; }

        public void Make()
        {
            entity.Perform();
        }
    }
}
