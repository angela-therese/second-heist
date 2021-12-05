using System;
using System.Collections.Generic;


namespace Heist
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public string Job { get; set; }

        public void PerformSkill(Bank bank)
        {
           
           
             int VaultScoreInt = Convert.ToInt32(bank.VaultScore);
             int bankScore = VaultScoreInt - SkillLevel;

            //  Console.WriteLine($"{Name} has unlocked the vault . Decreased security by {SkillLevel} points.");

             if(bankScore <= 0){
                 Console.WriteLine($"{Name} has unlocked the vault! You win!");
             }

             else {
                 Console.WriteLine($"{Name} was no match for the vault. You lose!");
             }

           
        }
    }
}