using AdapterPattern.Adapter;
using System;

namespace AdapterPattern.Target
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioPlayer : IMediaPlayer
    {
        private IMediaPlayer _playerAdapter = null; // This is the adapter

        public AudioPlayer(IMediaPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("Please supply a valid media player");
            }
            _playerAdapter = player;
        }

        public void Play(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("Please specifiy a filename");
            }

            // Get the format
            var fileFormat = fileName.Substring(fileName.LastIndexOf('.') + 1).ToLower();

            // Check it
            if (String.IsNullOrWhiteSpace(fileFormat))
            {
                throw new ArgumentNullException("Please specifiy a valid file to play");
            }

            // This object can play 'wav' files, however, any other format requires another player
            switch (fileFormat)
            {
                case "wav":
                    Console.WriteLine();
                    break;
                default:
                    _playerAdapter.Play(fileName);  // Use the adapter
                    break;
            }
        }
    }
}
