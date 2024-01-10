using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;
using TeaShopAPI.DtoLayer.QuestionsDtos;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [HttpGet]
        public IActionResult QuestionList()
        {
            var values = _questionService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddQuestion(CreateQuestionDto createQuestionDto)
        {
            Question question = new Question()
            {
                AnswerDetail = createQuestionDto.AnswerDetail,
                QuestionDetail = createQuestionDto.QuestionDetail
            };
            _questionService.TAdd(question);
            return Ok("Soru başarılı bir şeilde eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteQuestion(int id)
        {
            var value = _questionService.TGetById(id);
            _questionService.TDelete(value);
            return Ok("Soru başarılı bir şekilde silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetQuestion(int id)
        {
            var value = _questionService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateQuestion(UpdateQuestionDto updateQuestionDto)
        {
            Question question = new Question()
            {
                AnswerDetail = updateQuestionDto.AnswerDetail,
                QuestionDetail = updateQuestionDto.QuestionDetail,
                QuestionID = updateQuestionDto.QuestionID
            };
            _questionService.TUpdate(question);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi.");
        }
    }
}
