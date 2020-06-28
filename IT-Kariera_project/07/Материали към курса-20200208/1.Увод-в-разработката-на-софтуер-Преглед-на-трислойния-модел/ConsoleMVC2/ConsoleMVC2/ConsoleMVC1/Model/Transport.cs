using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC1.Model
{
    public class Transport
    {
		public Transport(int distation, string when)
		{
			this.Distation = distation;
			this.When = when;
		}

		public Transport() : this(0, "day")
		{
		}

		private double distation;

		public double Distation
		{
			get { return distation; }
			set { distation = value; }
		}

		private string when;

		public string When
		{
			get { return when; }
			set
			{
				this.when = value;
			}
		}

		public double CalculateTotal()
		{
			var taxiPricePerKm = this.When == "day" ? 0.79 : 0.90;
			var busPricePerKm = 0.09;
			var trainPricePerKm = 0.06;

			var taxiPrice = 0.70 + taxiPricePerKm* this.Distation;
			var busPrice = busPricePerKm * this.Distation;
			var trainPrice = trainPricePerKm * this.Distation;
			if(this.Distation > 100)
			{
				return Math.Min(taxiPrice, Math.Min(busPrice,trainPrice));

			}
			else if( this.Distation>20)
			{
				return Math.Min(taxiPrice, busPrice);
			}
			return taxiPrice;
		}
	}
}
