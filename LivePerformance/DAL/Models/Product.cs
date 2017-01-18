using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public Double Prijs { get; private set; }
        public string Naam { get; private set; }
        public bool Alcohol { get; private set; }

    }
}
