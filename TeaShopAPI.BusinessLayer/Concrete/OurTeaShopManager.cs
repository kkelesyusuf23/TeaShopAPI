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
    public class OurTeaShopManager : IOurTeaShopService
    {
        private readonly IOurTeaShopDal _ourTeaShopDal;

        public OurTeaShopManager(IOurTeaShopDal ourTeaShopDal)
        {
            _ourTeaShopDal = ourTeaShopDal;
        }

        public void TAdd(OurTeaShop entity)
        {
            _ourTeaShopDal.Add(entity);
        }

        public void TDelete(OurTeaShop entity)
        {
            _ourTeaShopDal.Delete(entity);
        }

        public OurTeaShop TGetById(int id)
        {
            return _ourTeaShopDal.GetById(id);
        }

        public List<OurTeaShop> TGetListAll()
        {
            return _ourTeaShopDal.GetListAll();
        }

        public void TUpdate(OurTeaShop entity)
        {
            _ourTeaShopDal.Update(entity);
        }
    }
}
