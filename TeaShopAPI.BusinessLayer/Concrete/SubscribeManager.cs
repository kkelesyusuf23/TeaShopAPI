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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TAdd(Subscribe entity)
        {
            _subscribeDal.Add(entity);
        }

        public void TDelete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        public List<Subscribe> TGetListAll()
        {
            return _subscribeDal.GetListAll();
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribeDal.Update(entity);
        }
    }
}
