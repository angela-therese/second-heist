using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
           List <Member> TeamMembers = new List<Member>();
           
          
          
          
            Console.WriteLine("Plan your heist!");

            while(true)
            {
            Console.WriteLine("Enter your name.");
            string memberName = Console.ReadLine();

            if (memberName == "")
            {
                break;
            }
            Console.WriteLine("Enter your skill level (1-10)");
            string skillLevel = Console.ReadLine();
            int intSkillLevel = Convert.ToInt32(skillLevel);
            Console.WriteLine("Enter your courage factor (0.0-2.0)");
            string courageFactor = Console.ReadLine();
            double decCourageFactor = Convert.ToDouble(courageFactor);


            TeamMembers.Add(new Member{

                Name = ($"{memberName}"),
                SkillLevel = intSkillLevel,
                Courage = decCourageFactor

            });
           

            // Console.WriteLine("Player Information");
            // Console.WriteLine("--------------");
            // Console.WriteLine(memberName);
            // Console.WriteLine(intSkillLevel);
            // Console.WriteLine(decCourageFactor);

        } }
    }
}
