using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASPUdemy.src.Controllers
{
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {

            if (
            Decimal.TryParse(firstNumber, out decimal firstNumberConverted) &&
            Decimal.TryParse(secondNumber, out decimal secondNumberConverted))
            {
                var result = firstNumberConverted + secondNumberConverted;
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {

            if (
            Decimal.TryParse(firstNumber, out decimal firstNumberConverted) &&
            Decimal.TryParse(secondNumber, out decimal secondNumberConverted))
            {
                var result = firstNumberConverted - secondNumberConverted;
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {

            if (
            Decimal.TryParse(firstNumber, out decimal firstNumberConverted) &&
            Decimal.TryParse(secondNumber, out decimal secondNumberConverted))
            {
                var result = firstNumberConverted * secondNumberConverted;
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {

            if (
            Decimal.TryParse(firstNumber, out decimal firstNumberConverted) &&
            Decimal.TryParse(secondNumber, out decimal secondNumberConverted))
            {
                var result = firstNumberConverted / secondNumberConverted;
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber)
        {

            if (
            Decimal.TryParse(firstNumber, out decimal firstNumberConverted) &&
            Decimal.TryParse(secondNumber, out decimal secondNumberConverted))
            {
                var result = (firstNumberConverted + secondNumberConverted) / 2;
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("squareRoot/{number}")]
        public IActionResult SquareRoot(string number)
        {

            if (Double.TryParse(number, out double numberConverted))
            {
                var result = Math.Sqrt(numberConverted);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }
    }
}