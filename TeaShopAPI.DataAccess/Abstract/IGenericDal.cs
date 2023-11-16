﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.DataAccess.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		List<T> GetListAll();
		T GetById(int id);
	}
}
