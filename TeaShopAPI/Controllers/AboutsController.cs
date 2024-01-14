using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.AboutDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public ActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public ActionResult AddAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageURl = createAboutDto.ImageURl,
            };
            _aboutService.TAdd(about);
            return Ok("Hakkında bilgisi başarılı bir şekilde eklendi.");
        }
        [HttpDelete]
        public ActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Silme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpGet("{id}")]
        public ActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public ActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID = updateAboutDto.AboutID,
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                ImageURl= updateAboutDto.ImageURl,
            };
            _aboutService.TUpdate(about);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
    }
}
