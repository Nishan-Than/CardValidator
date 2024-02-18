using CreditCardValidatorAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreditCardValidatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardValidatorController : ControllerBase
    {
        private readonly IValidationService _validationService;
        private readonly ILogger<CardValidatorController> _logger;

        public CardValidatorController(IValidationService validationService, ILogger<CardValidatorController> logger)
        {
            _validationService = validationService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult ValidateCard([FromBody] string cardNo)
        {
            cardNo = cardNo.Replace(" ", "");
            return Ok(_validationService.ValidateCard(cardNo));
        }
    }
}
