using System;
namespace ROSHAMBO
{
    public class Service
    {
        public Service()
        {
        }
        public string Play(string inputFirst, string inputSecond)
        {
            var inputOne = inputFirst.ToLower();
            var inputTwo = inputSecond.ToLower();
            if ((inputOne == "rock" || inputOne == "paper" || inputOne == "scissors") && (inputTwo == "rock" || inputTwo == "paper" || inputTwo == "scissors"))
                {
                switch (inputOne)
                {
                    case "rock":
                        if (inputTwo == "rock")
                            return "tie";
                        else if (inputTwo == "paper")
                            return "paper";
                        else if (inputTwo == "scissors")
                            return "rock";
                        break;
                    case "paper":
                        if (inputTwo == "rock")
                            return "paper";
                        else if (inputTwo == "paper")
                            return "tie";
                        else if (inputTwo == "scissors")
                            return "scissors";
                        break;
                    case "scissors":
                        if (inputTwo == "rock")
                            return "rock";
                        else if (inputTwo == "paper")
                            return "scissors";
                        else if (inputTwo == "scissors")
                            return "tie";
                        break;
                }
                } else
                {
                    return "Input not valid - Please enter rock, paper or scissors";
                }
            return "0";
        }
    }
}
