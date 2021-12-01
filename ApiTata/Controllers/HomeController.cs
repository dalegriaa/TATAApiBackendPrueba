using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTata.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
  
    public class HomeController : ControllerBase
    {
        private readonly ICountInputTextApplication _countInputTextApplication;
        public HomeController(ICountInputTextApplication countInputTextApplication)
        {
            _countInputTextApplication = countInputTextApplication;
        }
        [HttpPost("[action]/{id}")]
        public IActionResult GetNumberTimesWordRepeated([FromRoute] int id)
        {
            //if (String.IsNullOrEmpty(phrase)) return BadRequest();
            var response = _countInputTextApplication.GetNumberTimesRepeatInputText("hola mundo");
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }
    }
}
