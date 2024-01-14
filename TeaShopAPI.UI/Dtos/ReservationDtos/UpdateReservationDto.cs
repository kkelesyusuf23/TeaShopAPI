namespace TeaShopAPI.UI.Dtos.ReservationDtos
{
    public class UpdateReservationDto
    {
        public int ReservationID { get; set; }
        public string NameSurname { get; set; }
        public int PersonCount { get; set; }
        public int TableNo { get; set; }
    }
}
