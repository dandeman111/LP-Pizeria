using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Enumurations;

namespace LivePerformance.DAL.Models
{
    public class Pizza
    {
        public int Id { get; private set; }
        public double Prijs { get; private set; }
        public bool Halal { get; private set; }
        public bool Veganistisch { get; private set; }
        public int BaktijdInMin { get; private set; }
        public Vorm Vorm { get; private set; }
        public string Naam { get; private set; }
    }
}
