namespace TeaShopAPI.UI.Dtos.ReservationDtos
{
    public class ResultReservationDto
    {
        public int ReservationID { get; set; }
        public string NameSurname { get; set; }
        public int PersonCount { get; set; }
        public int TableNo { get; set; }
        public DateTime ReservationTime { get; set; }
    }
}
