﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.ViewModels
{
    public class BasketRazorVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
