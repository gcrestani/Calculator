using Calculator.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Calculator.Tests
{
    public class CalculatorTests
    {

        private readonly CalculatorController _calculator;

        public CalculatorTests()
        {
            _calculator = new CalculatorController();
        }

        [Fact (DisplayName ="Should sum two numbers given as string")]
        public void ShouldSumTwoNumberGivenAsString()
        {
            //Arrange
            var number1 = "2,2";
            var number2 = "3,1";

            //Act
            var result = _calculator.GetSum(number1, number2);
            
            //Assert
            OkObjectResult res = result as OkObjectResult;
            Assert.Equal("5,3" , res.Value);
        }
    }
}