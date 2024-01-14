using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.TestimonialDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public ActionResult TestimonialList()
        {
            var values = _testimonialService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialName = createTestimonialDto.TestimonialName,
                TestimonialComment = createTestimonialDto.TestimonialComment,
                TestimonialImageURL = createTestimonialDto.TestimonialImageURL,
            };
            _testimonialService.TAdd(testimonial);
            return Ok("Ekleme işlemi başarılı bir şekilde gerçekleştirilmiştir");
        }
        [HttpDelete]
        public ActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("Silme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }
        [HttpGet("{id}")]
        public ActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public ActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialID = updateTestimonialDto.TestimonialID,
                TestimonialName = updateTestimonialDto.TestimonialName,
                TestimonialComment = updateTestimonialDto.TestimonialComment,
                TestimonialImageURL = updateTestimonialDto.TestimonialImageURL,
            };
            _testimonialService.TUpdate(testimonial);
            return Ok("Güncelle işlemi başarılı bir şekilde gerçekleştirilmitri.");
        }
    }
}
