

namespace Heist

{
    public interface IRobber

    {
        string Name { get;  }
        int SkillLevel { get; }
        int PercentageCut { get; }

        // string MemberRole { get; }

        void PerformSkill(Bank param)
        {

        }
    }



}
