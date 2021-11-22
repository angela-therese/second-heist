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

            int TeamSize = TeamMembers.Count;
            int BankLevel = 100;

            Console.WriteLine($"{TeamSize} team members");
            Console.WriteLine($"Total Team Skill Score: {teamSkill}");
            
            if(BankLevel < teamSkill){
                Console.WriteLine("Success! Your skill level exceed the bank's difficulty.");
            }
            else{
                Console.WriteLine("Uh-oh! Bank difficulty is greater than your skill level. You're in trouble!");
            }





            //DISPLAY MEMBERS' INFORMATION
            // Console.WriteLine("************");
            // foreach(Member t in TeamMembers){
            //     Console.WriteLine(t.Name);
            //     Console.WriteLine($"Skill Level: {t.SkillLevel}");
            //     Console.WriteLine($"Courage: {t.Courage}");
            //     Console.WriteLine("--------------------");

            // }
           

            // Console.WriteLine("Player Information");
            // Console.WriteLine("--------------");
            // Console.WriteLine(memberName);
            // Console.WriteLine(intSkillLevel);
            // Console.WriteLine(decCourageFactor);

         }
    }
}
