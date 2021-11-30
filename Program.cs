using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
           List <Member> TeamMembers = new List<Member>();
           
          
          
            int teamSkill = 0;
            Console.WriteLine("Plan your heist!");

            while(true)
            {
            Console.WriteLine("Enter your name.");
            string memberName = Console.ReadLine();

            if (memberName == "")
            {
                break;
            }
            Console.WriteLine("Enter your skill level (1-50)");
            string skillLevel = Console.ReadLine();
            int intSkillLevel = Convert.ToInt32(skillLevel);
            teamSkill = (teamSkill + intSkillLevel);
            Console.WriteLine("Enter your courage factor (0.0-2.0)");
            string courageFactor = Console.ReadLine();
            double decCourageFactor = Convert.ToDouble(courageFactor);



            TeamMembers.Add(new Member{

                Name = ($"{memberName}"),
                SkillLevel = intSkillLevel,
                Courage = decCourageFactor

            });
          
            }

           
            Console.WriteLine("How many times do you want to try the heist?");
            string trialRunsString = Console.ReadLine();
            int trialRuns = Convert.ToInt32(trialRunsString);
            int trials = 0;
            int heistSuccess = 0;
            int heistFail = 0;

            while (trials < trialRuns){

           

            int TeamSize = TeamMembers.Count;
            Console.WriteLine("What is the bank's difficulty level from 1-100?");
            string BankLevelString = Console.ReadLine();
            int BankLevel = Convert.ToInt32(BankLevelString);
            int LuckValue = new Random().Next(-10, 11);
            int NewBankLevel = (BankLevel + LuckValue);
            Console.WriteLine($"Factoring in luck, your bank's difficulty level is now {NewBankLevel}");
            Console.WriteLine($"{TeamSize} team members");
            Console.WriteLine($"Total Team Skill Score: {teamSkill}");
            Console.WriteLine($"Bank difficulty level: {NewBankLevel}");
            
            
            if(BankLevel < teamSkill){
                Console.WriteLine("Success! You win!");
                heistSuccess += 1;
            }
            else{
                Console.WriteLine("Uh-oh! You lose!");
                heistFail += 1; 
            }

            trials += 1;

            }

            Console.WriteLine($"You won the heist {heistSuccess} times.");
            Console.WriteLine($"You lost the heist {heistFail} times.");
           

            


         }
    }
}
