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
	public class QuestionManager : IQuestionService
	{
		private readonly IQuestionDal _questionDal;

		public QuestionManager(IQuestionDal questionDal)
		{
			_questionDal = questionDal;
		}

		public void TAdd(Question entity)
		{
			_questionDal.Add(entity);
		}

		public void TDelete(Question entity)
		{
			_questionDal.Delete(entity);
		}

		public Question TGetById(int id)
		{
			return _questionDal.GetById(id);	
		}

		public List<Question> TGetListAll()
		{
			return _questionDal.GetListAll();
		}

		public void TUpdate(Question entity)
		{
			_questionDal.Update(entity);
		}
	}
}
