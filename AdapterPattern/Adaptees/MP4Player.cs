using System;

namespace AdapterPattern.Adaptees
{
    public class MP4Player : IMediaFormatPlayer
    {
        public string Name { get { return "MP4"; } }

        public void Play(string fileName)
        {
            Console.WriteLine($"{Name} Player: {fileName}");
        }
    }
}
