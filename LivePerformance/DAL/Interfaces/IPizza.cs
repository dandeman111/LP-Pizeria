﻿using System.Collections.Generic;
using LivePerformance.DAL.Models;

namespace LivePerformance.DAL.Interfaces
{
     public interface IPizza
    {
        Pizza GetbyId(int id);
        void Add(Pizza product);
        void Update(Pizza product);
        void Delete(Pizza product);
        List<Pizza> GetAll();
    }
}
