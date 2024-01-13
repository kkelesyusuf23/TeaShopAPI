using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DataAccess.Abstract;

namespace TeaShopAPI.BusinessLayer.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private readonly IStatisticDal _statisticDal;

        public StatisticManager(IStatisticDal statisticDal)
        {
            _statisticDal = statisticDal;
        }

        public decimal TDrinkAveragePrice()
        {
            return _statisticDal.DrinkAveragePrice();
        }

        public int TDrinkCount()
        {
            return _statisticDal.DrinkCount();
        }

        public string TLastDrinkName()
        {
            return _statisticDal.LastDrinkName();
        }

        public string TMaxPriceDrinkName()
        {
            return _statisticDal.MaxPriceDrinkName();
        }
    }
}
