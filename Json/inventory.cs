using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class inventory
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public List<inventory> GetProducts()
        {
            return new List<inventory>()
            {
                new inventory{Name = "Rice", Price = 20, Weight = 10},
                new inventory{Name = "Wheat", Price = 30, Weight = 5},
                new inventory{Name = "Pulses", Price = 50, Weight = 3}
            };

        }
    }
}
