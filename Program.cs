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
                    { Name = "Luca", SkillLevel = 82, PercentageCut = 20, Job = "Hacker"},
                    new Hacker()
                    { Name = "Hazel", SkillLevel = 32, PercentageCut = 20, Job = "Hacker"},
                    new Muscle()
                    { Name = "Izzi", SkillLevel = 32, PercentageCut = 30, Job = "Muscle" },
                    new LockSpecialist()
                    { Name = "Hazel", SkillLevel = 86, PercentageCut = 35, Job = "Lock Specialist"},
                    new Muscle()
                    { Name = "Celia", SkillLevel = 32, PercentageCut = 60, Job = "Muscle" }
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
                    member.Job = "Hacker";
                    rolodex.Add (member);
                }
                else if (specialty == "2")
                {
                    Muscle member = new Muscle();
                    member.Name = memberName;
                    member.SkillLevel = intSkillLevel;
                    member.Job = "Muscle";
                    member.PercentageCut = cutInt;
                    rolodex.Add (member);
                }
                else if (specialty == "3")
                {
                   
                    LockSpecialist member = new LockSpecialist();
                    member.Name = memberName;
                    member.SkillLevel = intSkillLevel;
                    member.PercentageCut = cutInt;
                    member.Job = "Lock Specialist";
                    rolodex.Add (member);
                }


               
                Console.WriteLine("Enter your courage factor (0.0-2.0)");
                string courageFactor = Console.ReadLine();
                double decCourageFactor = Convert.ToDouble(courageFactor);

                TeamMembers
                    .Add(new Member {
                        Name = ($"{memberName}"),
                        SkillLevel = intSkillLevel,
                        Courage = decCourageFactor,
                       
                    });
            }
            
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

                foreach(IRobber r in rolodex){
                    int memberNumber = (rolodex.IndexOf(r) +1);
                   Console.WriteLine($"{memberNumber}");
                    Console.WriteLine($"Member Name: {r.Name}");
                    Console.WriteLine($"Specialty: {r.Job}");
                     Console.WriteLine($"Skill Level: {r.SkillLevel}");
                     Console.WriteLine($"Percentage Cut: {r.PercentageCut}");
                };

                List<IRobber> crew = new List<IRobber>();
                int intCrewMemberNumber; 
                int i;
                //how to eliminate operative choices based on percentage capacity
               
               

                 while (true)
            {
                //START TEAM SELECTION
                Console.WriteLine("Choose your crew! Enter the number of the person you wish to add. Push enter when you are finished. Remember, your team's percentage of the cut cannot total more than 100, so you may run out of choices!");
                string crewMemberNumber = Console.ReadLine();
                int rolodexSize = rolodex.Count();

                if(crewMemberNumber == "")
                {
                    break;
                }
                
                else {
            
                    intCrewMemberNumber = Convert.ToInt32(crewMemberNumber);
                    if (intCrewMemberNumber > rolodexSize)
                {
                   Console.WriteLine("Try Again. Enter a valid number.");   
                   crewMemberNumber = Console.ReadLine();
                }

                else {
                    i = (intCrewMemberNumber - 1);
                    crew.Add(rolodex[i]);
                    rolodex.RemoveAt(i);
                }

                }

                Console.WriteLine("Your current team: ");
                 int percentTotal = 0;
                foreach(IRobber c in crew){
                    percentTotal += c.PercentageCut;
                    int percentLeft = 100-percentTotal;
                    Console.WriteLine($"{c.Name} wants {c.PercentageCut} of the cut. You have {percentLeft} percent left.");
                    
                    
                };
                
                

                 foreach(IRobber r in rolodex){

                  if(r.PercentageCut + percentTotal <= 100)
                  {
                   int memberNumber = (rolodex.IndexOf(r) +1);
                   Console.WriteLine($"{memberNumber}");
                    Console.WriteLine($"Member Name: {r.Name}");
                    Console.WriteLine($"Specialty: {r.Job}");
                     Console.WriteLine($"Skill Level: {r.SkillLevel}");
                     Console.WriteLine($"Percentage Cut: {r.PercentageCut}");
                     }
                    
                };

                 //END TEAM SELECTION

            }
            
                Console.WriteLine("Your final team: ");
                foreach(IRobber c in crew){
                    Console.WriteLine($"{c.Name}");   
                };

               
                foreach(IRobber c in crew) 
                {
                    c.PerformSkill(newBank);
                   
                    
                    
                };
                    
                
                  //HOW DO YOU CHANGE THE BOOLEAN TO FALSE? 
                  if(newBank.IsSecure() == true) {

                      
                    foreach(IRobber c in crew) 
                {
                            double cutToDecimal = (c.PercentageCut / 100.00);
                            double payout = cutToDecimal * newBank.CashOnHand;
                             Console.WriteLine($"{c.Name}: {payout}");
                }
                         }
               

               


                }
                            

        }
    }

    





