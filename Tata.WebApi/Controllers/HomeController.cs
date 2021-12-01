using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tata.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICountInputTextApplication _countInputTextApplication;
        public HomeController(ICountInputTextApplication countInputTextApplication)
        {
            _countInputTextApplication = countInputTextApplication;
        }

        [HttpGet("{inputText}")]
        public IActionResult GetNumberTimesWordRepeated(string inputText)
        {
            if (string.IsNullOrEmpty(inputText)) return BadRequest();
            var response = _countInputTextApplication.GetNumberTimesRepeatInputText(inputText);
            if (response.IsSuccess) return Ok(response);
            return BadRequest(response.Message);
        }
    }
}
