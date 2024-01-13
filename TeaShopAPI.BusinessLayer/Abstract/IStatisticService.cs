using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.BusinessLayer.Abstract
{
    public interface IStatisticService
    {
        int TDrinkCount();
        decimal TDrinkAveragePrice();
        string TLastDrinkName();
        string TMaxPriceDrinkName();
    }
}
