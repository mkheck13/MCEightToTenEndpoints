using MCEightToTenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCEightToTenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;
        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("EasyMode/{input}")]
        public string EasyMode(string input)
        {
            return _guessItServices.EasyMode(input);
        }

        [HttpGet]
        [Route("MedMode/{input}")]
        public string MedMode(string input)
        {
            return _guessItServices.MedMode(input);
        }

        [HttpGet]
        [Route("HardMode/{input}")]
        public string HardMode(string input)
        {
            return _guessItServices.HardMode(input);
        }
    }
}