using System;
using ROSHAMBO;
using Xunit;

namespace ROSHAMBOTests
{
    public class UnitTest1
    {
        [Fact]
        public void RockBeatsScissorsTests()
        {
            //Arrange
            var inputOne = "rock";
            var inputTwo = "scissors";
            var expectedResult = "rock";
            Service service = new Service();

            //Act
            string result = service.Play(inputOne, inputTwo);


        }
    }
}
