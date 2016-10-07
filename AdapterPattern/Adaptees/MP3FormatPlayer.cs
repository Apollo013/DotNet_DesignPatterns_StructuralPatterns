using System;

namespace AdapterPattern.Adaptees
{
    public class MP3FormatPlayer : IMediaFormatPlayer
    {
        public string Name { get { return "MP3"; } }

        public void Play(string fileName)
        {
            Console.WriteLine($"{Name} Player: {fileName}");
        }
    }
}
