

namespace Heist

{
    public interface IRobber

    {
        string Name { get;  }
        int SkillLevel { get; }
        int PercentageCut { get; }
        string Job {get; }

        // string MemberRole { get; }

        void PerformSkill(int param)
        {

        }

        void PerformSkill(Bank newBank);
    }



}
