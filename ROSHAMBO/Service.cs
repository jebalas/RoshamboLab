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
                    return "0";
        }
    }
}
