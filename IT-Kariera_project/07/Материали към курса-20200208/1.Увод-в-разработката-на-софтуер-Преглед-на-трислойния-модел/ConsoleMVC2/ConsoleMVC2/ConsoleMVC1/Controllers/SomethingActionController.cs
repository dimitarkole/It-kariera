using ConsoleMVC1.Model;
using ConsoleMVC1.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC1.Controllers
{
    public class SomethingActionController
    {
        private Transport transport;
        private Display display;

        public SomethingActionController()
        {
            this.display = new Display();
            transport = new Transport(display.Distance, display.When);
            display.TotalPrice = transport.CalculateTotal(); 
            display.ShowResult();
        }
    }
}
