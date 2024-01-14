using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.MessageDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult MessagesList()
        {
            var values = _messageService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {
                MessageSenderName = createMessageDto.MessageSenderName,
                MessageDetail = createMessageDto.MessageDetail,
                MessageEmail = createMessageDto.MessageEmail,
                MessageSubject = createMessageDto.MessageSubject,
                MessageSendDate = DateTime.Now,
            };
            _messageService.TAdd(message);
            return Ok("Mesaj başarılı bir şekilde eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetById(id);
            _messageService.TDelete(value);
            return Ok("Silme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            Message message = new Message()
            {
                MessageID = updateMessageDto.MessageID,
                MessageSenderName = updateMessageDto.MessageSenderName,
                MessageDetail = updateMessageDto.MessageDetail,
                MessageEmail = updateMessageDto.MessageEmail,
                MessageSubject = updateMessageDto.MessageSubject,
                MessageSendDate = DateTime.Now,
            };
            _messageService.TUpdate(message);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
    }

}
