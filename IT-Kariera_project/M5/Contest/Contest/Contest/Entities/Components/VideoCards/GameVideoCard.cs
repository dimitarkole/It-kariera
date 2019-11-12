using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    public class GameVideoCard : VideoCard
    {
        public GameVideoCard(string model, int ram, int generation, decimal minedMoneyPerHour)
           : base(model, ram, generation, minedMoneyPerHour)
        {
            /*if (this.Generation < 9)
            {
                throw new ArgumentException("Game video card generation cannot be more than 9!");
            }*/
            this.MinedMoneyPerHour *= 2;
        }

    }
}
