using CryptoMiningSystem.Entities.Components.Processors;
using CryptoMiningSystem.Entities.Components.VideoCards;
using CryptoMiningSystem.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities
{
    public class Computer : IComputer
    {
        private Processor processor;

        public Processor Processor
        {
            get { return processor; }
            protected set { processor = value; }
        }

        private VideoCard videoCard;

        public VideoCard VideoCard
        {
            get { return videoCard; }
            protected set { videoCard = value; }
        }

        private int ram;

        public int Ram
        {
            get { return ram; }
            private set
            {
                if (!((value >= 0) && (value <= 32)))
                    throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
                ram = value;
            }
        }

        private decimal minedAmountPerHour;

        public Computer(Processor processor, VideoCard videoCard, int ram)
        {
            Processor = processor;
            VideoCard = videoCard;
            Ram = ram;
            MinedAmountPerHour = videoCard.MinedMoneyPerHour * processor.MineMultiplier;
        }

        public decimal MinedAmountPerHour
        {
            get { return minedAmountPerHour; }
            protected set { minedAmountPerHour = value; }

        }
    }
}
