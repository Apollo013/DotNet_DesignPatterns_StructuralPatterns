using System.Collections.Generic;

namespace CompositePattern
{
    public class Group : IParticipant
    {
        public string Name { get; set; }
        public List<IParticipant> Members { get; set; }
        public int Gold
        {
            get
            {
                // Return the total amount of gold for all participants in the group
                int totalGold = 0;
                foreach (IParticipant member in Members)
                {
                    totalGold += member.Gold;
                }

                return totalGold;
            }
            set
            {
                // Splits the gold as evenly as possible among all participants
                double eachSplit = value / Members.Count;
                int leftOver = value % Members.Count;
                foreach (IParticipant member in Members)
                {
                    member.Gold += (int)(eachSplit + leftOver);
                    leftOver = 0;
                }
            }
        }

        public Group()
        {
            Members = new List<IParticipant>();
        }

        public void Stats()
        {
            foreach (IParticipant member in Members)
            {
                member.Stats();
            }
        }
    }
}
