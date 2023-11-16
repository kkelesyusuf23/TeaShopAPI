using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DataAccess.Abstract;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.BusinessLayer.Concrete
{
	public class DrinkManager : IDrinkService
	{
		private readonly IDrinkDal _drinkDal;

		public DrinkManager(IDrinkDal drinkDal)
		{
			_drinkDal = drinkDal;
		}

		public void TAdd(Drink entity)
		{
			_drinkDal.Add(entity);
		}

		public void TDelete(Drink entity)
		{
			_drinkDal.Delete(entity);
		}

		public Drink TGetById(int id)
		{
			return _drinkDal.GetById(id);
		}

		public List<Drink> TGetListAll()
		{
			return _drinkDal.GetListAll();
		}

		public void TUpdate(Drink entity)
		{
			_drinkDal.Update(entity);
		}
	}
}
