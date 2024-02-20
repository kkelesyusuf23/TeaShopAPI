using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.ReservationDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpGet]
        public IActionResult ReservationList()
        {
            var values = _reservationService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddReservation(CreateReservationDto createReservationDto)
        {
            Reservation reservation = new Reservation()
            {
                PersonCount = createReservationDto.PersonCount,
                TableNo = createReservationDto.TableNo,
                NameSurname = createReservationDto.NameSurname,
                ReservationTime = createReservationDto.ReservationTime,
            };
            _reservationService.TAdd(reservation);
            return Ok("Rezervasyon başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpDelete]
        public ActionResult DeleteReservation(int id)
        {
            var value = _reservationService.TGetById(id);
            _reservationService.TDelete(value);
            return Ok("Silme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetReservation(int id)
        {
            var value = _reservationService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public ActionResult UpdateReservation(UpdateReservationDto updateReservationDto)
        {
            Reservation reservation = new Reservation()
            {
                ReservationID = updateReservationDto.ReservationID,
                NameSurname = updateReservationDto.NameSurname,
                PersonCount = updateReservationDto.PersonCount,
                TableNo = updateReservationDto.TableNo,
                ReservationTime= updateReservationDto.ReservationTime,
            };
            _reservationService.TUpdate(reservation);
            return Ok("Güncelle işlemi başarılı bir şekilde gerçekleştirildi.");
        }
    }
}
