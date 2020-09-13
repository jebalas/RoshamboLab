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

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void PaperBeatsRockTests()
        {
            //Arrange
            var inputOne = "paper";
            var inputTwo = "rock";
            var expectedResult = "paper";
            Service service = new Service();

            //Act
            string result = service.Play(inputOne, inputTwo);

            //Assert
            Assert.Equal(expectedResult, result);

        }
    }
}
