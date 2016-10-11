using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldPieces = 1023;
            Console.WriteLine($"You have killed the Monster and gained {goldPieces} coins!");

            IParticipant andy = new Player { Name = "Andy" };
            IParticipant jane = new Player { Name = "Jane" };
            IParticipant eve = new Player { Name = "Eve" };

            IParticipant ann = new Player { Name = "Ann" };
            IParticipant edith = new Player { Name = "Edith" };

            IParticipant oldBob = new Player { Name = "Old Bob" };
            IParticipant newBob = new Player { Name = "New Bob" };

            IParticipant bobs = new Group { Members = { oldBob, newBob } };
            IParticipant developers = new Group { Name = "Developers", Members = { andy, jane, eve, bobs } }; // Individuals and groups
            IParticipant participants = new Group { Members = { developers, ann, edith } }; // Individuals and groups

            participants.Gold += goldPieces;
            participants.Stats();

            Console.ReadKey();
        }
    }
}
