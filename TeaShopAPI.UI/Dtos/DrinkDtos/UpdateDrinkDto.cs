namespace TeaShopAPI.UI.Dtos.DrinkDtos
{
	public class UpdateDrinkDto
	{
		public int drinkID { get; set; }
		public string drinkName { get; set; }
		public decimal drinkPrice { get; set; }
		public string drinkImageURL { get; set; }
	}
}
