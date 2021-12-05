using System;
using System.Collections.Generic;


namespace Heist
{
    public class Muscle: IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public string Job { get; set; }

        public void PerformSkill(Bank bank)
        {
           
           
             int SecurityScoreInt = Convert.ToInt32(bank.SecurityGuardScore);
             SecurityScoreInt = SecurityScoreInt - SkillLevel;

             Console.WriteLine($"{Name} is hacking alarm system. Decreased security by {SkillLevel} points.");

             if(SecurityScoreInt <= 0){
                 Console.WriteLine($"{Name} has defeated security! You win!");
             }

             else {
                 Console.WriteLine($"{Name} was no match for security. You lose!");
             }

           
        }
    }
}