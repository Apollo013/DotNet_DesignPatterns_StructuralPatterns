using System;

namespace CompositePattern
{
    public class Player : IParticipant
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine($"{Name} has {Gold} coins.");
        }
    }
}
