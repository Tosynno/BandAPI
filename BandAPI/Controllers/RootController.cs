using BandAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name ="GetRoot")]
        public IActionResult GetRoot()
        {
            var links = new List<LinkDto>();

           // links.Add();

            return Ok(links);
        }
    }
}
