﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.EntityLayer.Concrete
{
	public class Drink
	{
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }
        public decimal DrinkPrice { get; set; }
        public string DrinkImageURL { get; set;}
    }
}
