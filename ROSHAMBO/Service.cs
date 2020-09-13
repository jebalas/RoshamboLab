using System;
namespace ROSHAMBO
{
    public class Service
    {
        public Service()
        {
        }
        public string Play(string inputOne, string inputTwo)
        {
            if ((inputOne == "rock" && inputTwo == "scissors") || (inputOne == "scissors" && inputTwo == "rock"))
                return "rock";
            else if ((inputOne == "paper" && inputTwo == "rock") || (inputOne == "rock" && inputTwo == "paper"))
                return "paper";
            else if (inputOne == "paper" && inputTwo == "scissors" || (inputOne == "scissors" && inputTwo == "paper"))
                return "scissors";
            else if (inputOne == "rock" && inputTwo == "rock")
                return "tie";
            return "0";
        }
    }
}
