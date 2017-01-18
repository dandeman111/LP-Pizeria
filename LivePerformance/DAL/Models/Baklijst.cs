using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL.Models
{
    public class Baklijst
    {
        public List<Pizza> Wachtrij { get; private set; }
        public List<Pizza> Oven { get; private set; }
    }
}
