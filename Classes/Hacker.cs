using System;
using System.Collections.Generic;


namespace Heist
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public string Job { get; set; }

        public void PerformSkill(Bank bank)
        {
           
           
             int AlarmScoreInt = Convert.ToInt32(bank.AlarmScore);
             int bankScore = AlarmScoreInt - SkillLevel;
             int payout = bank.CashOnHand;
             

             Console.WriteLine($"{Name} is hacking alarm system. Please stand by.");
    

             if(bankScore >= 0)
             {
                Console.WriteLine($"{Name} was no match for the alarm system. You have failed to hack the bank!");
               
            
             }

             else
             {

                  Console.WriteLine($"{Name} has disabled the alarm system! Your team wins!");
                 Console.WriteLine($"You have ${payout} to split among yourselves.");
                 bool v = bank.IsSecure()== false;
                 
             }
           
        }
    }
}
