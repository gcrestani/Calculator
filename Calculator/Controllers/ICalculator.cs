using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public interface ICalculator
    {
        public IActionResult GetSum(string number1, string number2);
        public IActionResult GetSub(string number1, string number2);
        public IActionResult GetTimes(string number1, string number2);
        public IActionResult GetAvg(string number1, string number2);
        public IActionResult GetSqRoot(string number1, string number2);

    }
}
