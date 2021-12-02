using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex =
                new List<IRobber>()
                {
                    new Hacker()
                    { Name = "Luca", SkillLevel = 42, PercentageCut = 20 },
                    new Hacker()
                    { Name = "Hazel", SkillLevel = 32, PercentageCut = 20 },
                    new Muscle()
                    { Name = "Izzi", SkillLevel = 32, PercentageCut = 20 },
                    new LockSpecialist()
                    { Name = "Hazel", SkillLevel = 32, PercentageCut = 20 },
                    new Muscle()
                    { Name = "Celia", SkillLevel = 32, PercentageCut = 30 }
                };

            int rolodexCount = rolodex.Count();
            Console
                .WriteLine($"There are currently {rolodexCount} operatives in your rolodex.");

            List<Member> TeamMembers = new List<Member>();

            int teamSkill = 0;
            Console.WriteLine("Plan your heist!");

            while (true)
            {
                Console.WriteLine("Enter your name.");
                string memberName = Console.ReadLine();

                if (memberName == "")
                {
                    break;
                }

                Console.WriteLine("What is your specialty? Press 1 for Hacker. Press 2 for Muscle. Press 3 for Lock Specialist.");
                string specialty = Console.ReadLine();
                
                if(specialty != "1" && specialty != "2" && specialty != "3"){
                    Console.WriteLine("Try Again. Enter 1, 2, or 3.");   
                    specialty = Console.ReadLine();
                }

                Console.WriteLine("Enter your skill level (1-100)");
                string skillLevel = Console.ReadLine();
                int intSkillLevel = Convert.ToInt32(skillLevel);

                Console
                    .WriteLine("What's your percentage cut of the heist? Enter a number from 1-100.");
                string cut = Console.ReadLine();
                int cutInt = Convert.ToInt32(cut);

                if (specialty == "1")
                {
                    Hacker member = new Hacker();
                    member.Name = memberName;
                    member.SkillLevel = intSkillLevel;
                    member.PercentageCut = cutInt;
                    rolodex.Add (member);
                }
                else if (specialty == "2")
                {
                    Muscle member = new Muscle();
                    member.Name = memberName;
                    member.SkillLevel = intSkillLevel;
                    member.PercentageCut = cutInt;
                    rolodex.Add (member);
                }
                else if (specialty == "3")
                {
                    LockSpecialist member = new LockSpecialist();
                    member.Name = memberName;
                    member.SkillLevel = intSkillLevel;
                    member.PercentageCut = cutInt;
                    rolodex.Add (member);
                }


                teamSkill = (teamSkill + intSkillLevel);
                Console.WriteLine("Enter your courage factor (0.0-2.0)");
                string courageFactor = Console.ReadLine();
                double decCourageFactor = Convert.ToDouble(courageFactor);

                TeamMembers
                    .Add(new Member {
                        Name = ($"{memberName}"),
                        SkillLevel = intSkillLevel,
                        Courage = decCourageFactor
                    });
            }

     
            // int heistSuccess = 0;
            // int heistFail = 0;
            
                Bank newBank = new Bank()
                   {    AlarmScore = new Random().Next(0, 101),
                        VaultScore = new Random().Next(0, 101),
                        SecurityGuardScore = new Random().Next(0, 101),
                        CashOnHand = new Random().Next(50000, 1000001)
                   };

                Dictionary<string, int> bankScores = new Dictionary<string, int>()
                {
                    {"Alarm", newBank.AlarmScore},
                    {"Vault", newBank.VaultScore},
                    {"Security", newBank.SecurityGuardScore}
                };

                var result = bankScores.OrderByDescending(i => i.Value);
                var mostSecureSystem = result.ElementAt(0).Key;
                var leastSecureSystem = result.ElementAt(2).Key;

                Console.WriteLine($"The most secure system is the {mostSecureSystem}");
                Console.WriteLine($"The least secure system is the {leastSecureSystem}");
                
                int TeamSize = rolodex.Count();
               
                Console.WriteLine($"Total Team Skill Score: {teamSkill}");
              
           
            // Console.WriteLine($"You won the heist {heistSuccess} times.");
            // Console.WriteLine($"You lost the heist {heistFail} time(s).");
        }
    }
}




// Console.WriteLine("What is the bank's difficulty level from 1-100?");
                // string BankLevelString = Console.ReadLine();
                // int BankLevel = Convert.ToInt32(BankLevelString);
                // int LuckValue = new Random().Next(-10, 11);
                // int NewBankLevel = (BankLevel + LuckValue);
               // Console.WriteLine($"Factoring in luck, your bank's difficulty level is now { NewBankLevel}.");
                 // Console.WriteLine($"Bank difficulty level: {NewBankLevel}");

                // if (BankLevel < teamSkill)
                // {
                //     Console.WriteLine("Success! You win!");
                //     heistSuccess += 1;
                // }
                // else
                // {
                //     Console.WriteLine("Uh-oh! You lose!");
                //     heistFail += 1;
                // }
                       // Console.WriteLine("How many times do you want to try the heist?");
            // string trialRunsString = Console.ReadLine();
            // int trialRuns = Convert.ToInt32(trialRunsString);