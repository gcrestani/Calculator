using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase, ICalculator
    {

        [HttpGet("sum/{number1}/{number2}")]
        public IActionResult GetSum(string number1, string number2)
        {
            if (IsNumeric(number1) && IsNumeric(number2))
            {
                var sum = ConvertToDecimal(number1) + ConvertToDecimal(number2);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input"); 
        }

        private decimal ConvertToDecimal(string numberString)
        {
            decimal decimalValue;
            if (decimal.TryParse(numberString, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string numberString)
        {
            double number;
            bool isNumber = double.TryParse(numberString,
                                            System.Globalization.NumberStyles.Any,
                                            System.Globalization.NumberFormatInfo.InvariantInfo,
                                            out number);
            return isNumber;
        }

        public IActionResult GetAvg(string number1, string number2)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetSqRoot(string number1, string number2)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetSub(string number1, string number2)
        {
            throw new NotImplementedException();
        }


        public IActionResult GetTimes(string number1, string number2)
        {
            throw new NotImplementedException();
        }
    }
}