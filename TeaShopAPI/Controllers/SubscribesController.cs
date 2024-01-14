using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.SubscribeDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribesController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddSubscribe(CreateSubscribeDto createSubscribeDto)
        {
            Subscribe subscribe = new Subscribe()
            {
                Email = createSubscribeDto.Email,
            };
            _subscribeService.TAdd(subscribe);
            return Ok("Abonelik başarılı ile eklendi.");
        }
        [HttpDelete]
        public ActionResult DeleteSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);
            _subscribeService.TDelete(value);
            return Ok("Abonelik başarılı bir şekilde silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public ActionResult UpdateSubscribe(UpdateSubscribeDto updateSubscribeDto)
        {
            Subscribe sub = new Subscribe()
            {
                SubscribeID = updateSubscribeDto.SubscribeID,
                Email = updateSubscribeDto.Email,
            };
            _subscribeService.TUpdate(sub);
            return Ok("Abonelik başarılı bir şekilde güncelleştirildi.");
        }

    }
}
