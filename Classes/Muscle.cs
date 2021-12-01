using System;
using System.Collections.Generic;


namespace Heist
{
    public class Muscle: IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        void PerformSKill(Bank AlarmScore)
        {
           
           
             int AlarmScoreInt = Convert.ToInt32(AlarmScore);
             AlarmScoreInt = AlarmScoreInt - SkillLevel;

             Console.WriteLine($"{Name} is hacking alarm system. Decreased security by {SkillLevel} points.");

             if(AlarmScoreInt <= 0){
                 Console.WriteLine($"{Name} has disabled the alarm system!");
             }

           
        }
    }
}