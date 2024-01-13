using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.DataAccess.Abstract
{
    public interface IStatisticDal
    {
        int DrinkCount();
        decimal DrinkAveragePrice();
        string LastDrinkName();
        string MaxPriceDrinkName();
    }
}
