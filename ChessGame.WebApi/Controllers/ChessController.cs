using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChessGame.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChessController : ControllerBase
    {
        [Route("rules")]
        [HttpGet]
        public ActionResult Rules() 
        {
            return Ok("This is the chess game. The page is for rules of the game.");
        }

        [Route("play")]
        [HttpGet]
        public ActionResult Play()
        {
            return Ok("This is the chess game. The page is for playing the game.");
        }
    }
}
