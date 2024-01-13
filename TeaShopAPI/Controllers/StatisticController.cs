using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopAPI.BusinessLayer.Abstract;

namespace TeaShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        [HttpGet("GetDrinkAveragePrice")]
        public IActionResult GetDrinkAveragePrice() 
        {
            return Ok(_statisticService.TDrinkAveragePrice());
        }

        [HttpGet("GetDrinkCount")]
        public IActionResult GetDrinkCount()
        {
            return Ok(_statisticService.TDrinkCount());
        }

        [HttpGet("GetLastDrinkName")]
        public IActionResult GetLastDrinkName()
        {
            return Ok(_statisticService.TLastDrinkName());
        }

        [HttpGet("GetMaxPriceDrinkName")]
        public IActionResult GetMaxPriceDrinkName()
        {
            return Ok(_statisticService.TMaxPriceDrinkName());
        }
    }
}
