using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Data.Entities
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
            this.Id = Guid.NewGuid().ToString();

        }
        public string FullName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
