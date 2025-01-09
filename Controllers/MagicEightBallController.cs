using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCEightToTenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCEightToTenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagicEightBallController : ControllerBase
    {
        private readonly MagicEightBallServices _magicEightBallServices;

        public MagicEightBallController(MagicEightBallServices magicEightBallServices)
        {
            _magicEightBallServices = magicEightBallServices;
        }

        [HttpGet]
        [Route("Question")]
        public string Question()
        {
            return _magicEightBallServices.Question();
        }
    }
}