﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopAPI.DataAccess.Abstract;
using TeaShopAPI.DataAccess.Concrete;
using TeaShopAPI.DataAccess.Context;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.DataAccess.EntityFramework
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(TeaContext context) : base(context)
        {
        }
    }
}
