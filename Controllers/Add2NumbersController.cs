using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Add_2_Numbers__Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumbersController : ControllerBase
    {
         public List<string> numbers = new();
    [HttpPost]
    [Route("addNumber/{numberOne}/{numberTwo}")]
    public List<string> AddNumbers(int numberOne, int numberTwo){
        numbers.Add(numberOne + " Plus " + numberTwo + " is Euqal to: " + (numberOne+numberTwo) + ". WOWZERS!");
        return numbers;
    }
    }
}