using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.DtoLayer.ReservationDtos
{
    public class UpdateReservationDto
    {
        public int ReservationID { get; set; }
        public string NameSurname { get; set; }
        public int PersonCount { get; set; }
        public int TableNo { get; set; }
        public DateTime ReservationTime { get; set; }
    }
}
