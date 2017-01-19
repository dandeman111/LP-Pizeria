using System.Collections.Generic;

namespace LivePerformance.DAL.Models
{
    public class Baklijst
    {
        public List<Pizza> Wachtrij { get; private set; }
        public List<Pizza> Oven { get; private set; }
    }
}
