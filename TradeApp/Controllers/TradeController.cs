using Microsoft.AspNetCore.Mvc;

namespace TradeApp.Controllers
{
    [ApiController]
    [Route("api/trade")]
    public class TradeController:ControllerBase
    {
        /// <summary>
        /// api trade method get.
        /// </summary>
        /// <returns></returns>
        [HttpGet("get")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public IActionResult Get()
        {
            return Ok("Execute Trade Get Method");
        }
    }
}