using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.AboutDtos;
using TeaShopAPI.DtoLayer.OurTeaShopDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurTeaShopsController : ControllerBase
    {
        private readonly IOurTeaShopService _ourTeaShopService;

        public OurTeaShopsController(IOurTeaShopService ourTeaShopService)
        {
            _ourTeaShopService = ourTeaShopService;
        }
        [HttpGet]
        public ActionResult OurTeaShopList()
        {
            var values = _ourTeaShopService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddOurTeaShop(CreateOurTeaShopDto createOurTeaShopDto)
        {
            OurTeaShop ourTeaShop = new OurTeaShop()
            {
                Title = createOurTeaShopDto.Title,
                Description = createOurTeaShopDto.Description,
                ImageURL = createOurTeaShopDto.ImageURL,
            };
            _ourTeaShopService.TAdd(ourTeaShop);
            return Ok("Ekleme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpDelete]
        public ActionResult DeleteOurTeaShop(int id)
        {
            var value = _ourTeaShopService.TGetById(id);
            _ourTeaShopService.TDelete(value);
            return Ok("Silme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpGet("{id}")]
        public ActionResult GetOurTeShop(int id)
        {
            var value = _ourTeaShopService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public ActionResult UpdateOurTeaShop(UpdateOurTeaShopDto updateOurTeaShopDto)
        {
            OurTeaShop ourTeaShop = new OurTeaShop()
            {
                OurTeaShopID = updateOurTeaShopDto.OurTeaShopID,
                Title = updateOurTeaShopDto.Title,
                Description = updateOurTeaShopDto.Description,
                ImageURL = updateOurTeaShopDto.ImageURL,
            };
            _ourTeaShopService.TUpdate(ourTeaShop);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }
    }
}
