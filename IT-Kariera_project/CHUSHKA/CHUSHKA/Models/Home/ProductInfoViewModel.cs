using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Models.Home
{
    public class ProductInfoViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string DescriptionFormated
        {
            get
            {
                if (this.Description.Length > 50)
                {
                    return this.Description.Substring(0, 50) + "...";
                }
                else return this.Description;
            }
        }
    }

}
