using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopAPI.DataAccess.Abstract;
using TeaShopAPI.DataAccess.Context;

namespace TeaShopAPI.DataAccess.EntityFramework
{
    public class EfStatisticDal : IStatisticDal
    {
        private readonly TeaContext _context;

        public EfStatisticDal(TeaContext context)
        {
            _context = context;
        }

        public decimal DrinkAveragePrice()
        {
            decimal value = _context.Drinks.Average(x => x.DrinkPrice); 
            return value;
        }

        public int DrinkCount()
        {
            int value = _context.Drinks.Count();
            return value;
        }

        public string LastDrinkName()
        {
            string value = _context.Drinks.OrderByDescending(x => x.DrinkID).Select(x => x.DrinkName).FirstOrDefault();
            return value;
        }

        public string MaxPriceDrinkName()
        {
            decimal price = _context.Drinks.Max(x => x.DrinkPrice);
            string value =  _context.Drinks.Where(x => x.DrinkPrice == price).Select(y => y.DrinkName).FirstOrDefault();
            return value;
        }
    }
}
