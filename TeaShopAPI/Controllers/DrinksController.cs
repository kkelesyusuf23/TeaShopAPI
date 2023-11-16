using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.DrinkDtos;
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
			return Ok("İçeceğiniz eklendi.");
		}
	}
}
