using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.SliderDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        [HttpGet]
        public IActionResult SliderList()
        {
            var values = _sliderService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSlider(CreateSliderDto createSliderDto)
        {
            Slider slider = new Slider()
            {
               Title = createSliderDto.Title,
               ImageURL = createSliderDto.ImageURL,
            };
            _sliderService.TAdd(slider);
            return Ok("Ekleme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpDelete]
        public IActionResult DeleteSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            _sliderService.TDelete(value);
            return Ok("Silme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public ActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            Slider slider = new Slider()
            {
                SliderID = updateSliderDto.SliderID,
                Title = updateSliderDto.Title,
                ImageURL = updateSliderDto.ImageURL,
            };
            _sliderService.TUpdate(slider);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
    }
}
