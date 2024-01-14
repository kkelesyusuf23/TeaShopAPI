using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.DrinkDtos;
using TeaShopAPI.DtoLayer.QuestionsDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DrinksController : ControllerBase
	{
		private readonly IDrinkService _drinkService;

		public DrinksController(IDrinkService drinkService)
		{
			_drinkService = drinkService;
		}
		[HttpGet]
		public ActionResult DrinkList()
		{
			var values = _drinkService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public ActionResult AddDrink(CreateDrinkDto createDrinkDto)
		{
			Drink drink = new Drink()
			{
				DrinkImageURL = createDrinkDto.DrinkImageURL,
				DrinkName = createDrinkDto.DrinkName,
				DrinkPrice = createDrinkDto.DrinkPrice,
			};
			_drinkService.TAdd(drink);
			return Ok("İçecek başarılı bir şekilde eklendi.");
		}
        [HttpDelete]
        public IActionResult DeleteDrink(int id)
        {
            var value = _drinkService.TGetById(id);
            _drinkService.TDelete(value);
            return Ok("İçecek başarılı bir şekilde silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetDrink(int id)
        {
            var value = _drinkService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDrink(UpdateDrinkDto updateDrinkDto)
        {
			Drink drink = new Drink()
			{
				DrinkName = updateDrinkDto.DrinkName,
				DrinkPrice = updateDrinkDto.DrinkPrice,
				DrinkImageURL = updateDrinkDto.DrinkImageURL,
				DrinkID = updateDrinkDto.DrinkID,
			};
            _drinkService.TUpdate(drink);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi.");
        }

    }
}
