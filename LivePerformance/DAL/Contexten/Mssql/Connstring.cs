using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL.Contexten.Mssql
{
    public class Connstring
    {
        protected string ConnectionString { get; private set; }

        public Connstring()
        {
            ConnectionString = "Server=mssql.fhict.local;Database=dbi359166;User Id=dbi359166;Password=Pizzeria;";
        }
    }
}
