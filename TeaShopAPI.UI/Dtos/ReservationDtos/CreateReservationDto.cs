namespace TeaShopAPI.UI.Dtos.ReservationDtos
{
    public class CreateReservationDto
    {
        public string NameSurname { get; set; }
        public int PersonCount { get; set; }
        public int TableNo { get; set; }
    }
}
