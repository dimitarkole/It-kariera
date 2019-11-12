using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    public class MineVideoCard : VideoCard
    {
        public MineVideoCard(string model, int ram , int generation,  decimal minedMoneyPerHour) 
            : base(model, ram, generation, minedMoneyPerHour)
        {
           /* if(this.Generation > 6)
            {
                throw new ArgumentException("Mine video card generation cannot be more than 6!");
            }*/

            this.MinedMoneyPerHour *= 8;
            this.LifeWorkingHours *= 2;

        }
    }
}
