﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance.DAL.Models
{
     public class Bestelling
    {
        public int Id { get; private set; }
        public double Price { get; private set; }
        public double Btw { get; private set; }
        public bool Afhalen { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Product> Products { get; private set; }

    }
}