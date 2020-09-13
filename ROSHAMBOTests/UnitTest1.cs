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

            //Arrange
            var input1 = "scissors";
            var input2 = "rock";
            var expectedResult2 = "rock";
            Service service2 = new Service();

            //Act
            string result2 = service.Play(input1, input2);

            //Assert
            Assert.Equal(expectedResult2, result2);

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

            //Arrange
            var input1 = "rock";
            var input2 = "paper";
            var expectedResult2 = "paper";
            Service service2 = new Service();

            //Act
            string result2 = service.Play(input1, input2);

            //Assert
            Assert.Equal(expectedResult2, result2);
        }

        [Fact]
        public void ScissorsBeatsPaperTests()
        {
            //Arrange
            var inputOne = "paper";
            var inputTwo = "scissors";
            var expectedResult = "scissors";
            Service service = new Service();

            //Act
            string result = service.Play(inputOne, inputTwo);

            //Assert
            Assert.Equal(expectedResult, result);

            //Arrange
            var input1 = "scissors";
            var input2 = "paper";
            var expectedResult2 = "scissors";
            Service service2 = new Service();

            //Act
            string result2 = service.Play(input1, input2);

            //Assert
            Assert.Equal(expectedResult2, result2);

        }

        [Fact]
        public void TieGameTests()
        {
            //Arrange
            var inputOne = "rock";
            var inputTwo = "rock";
            var expectedResult = "tie";
            Service service = new Service();

            //Act
            string result = service.Play(inputOne, inputTwo);

            //Assert
            Assert.Equal(expectedResult, result);

            //Arrange
            var input1 = "paper";
            var input2 = "paper";
            var expectedResult2 = "tie";
            Service service2 = new Service();

            //Act
            string result2 = service.Play(input1, input2);

            //Assert
            Assert.Equal(expectedResult2, result2);

            //Arrange
            var input3 = "scissors";
            var input4 = "scissors";
            var expectedResult3 = "tie";
            Service service3 = new Service();

            //Act
            string result3 = service.Play(input3, input4);

            //Assert
            Assert.Equal(expectedResult3, result3);
        }
    }
}
