using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC1.Model
{
	public class Tip
	{
		public Tip(double amaunt, double procent)
		{
			Amaunt = amaunt;
			Procent = procent;
		}

		public Tip() : this(0, 0)
		{
		}

		private double amaunt;

		public double Amaunt
		{
			get { return amaunt; }
			set { amaunt = value; }
		}

		private double procent;

		public double Procent
		{
			get { return procent; }
			set
			{
				if (value < 1)
				{
					this.procent = value;
				}
				else
				{
					procent = value / 100.0;
				}
			}
		}

		public double CalculateTip()
		{
			return this.Amaunt * this.Procent;
		}

		public double CalculateTotal()
		{
			return this.CalculateTip() + this.Amaunt;
		}
	}
}
