using AdapterPattern.Adaptees;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AdapterPattern.Adapter
{
    public class MediaAdapter : IMediaPlayer
    {
        Dictionary<string, Type> _players = null;

        public MediaAdapter()
        {
            LoadPlayers();
        }

        public void Play(string fileName)
        {
            // Get the format
            var fileFormat = fileName.Substring(fileName.LastIndexOf('.') + 1).ToLower();

            // Check it
            if (String.IsNullOrWhiteSpace(fileFormat))
            {
                throw new ArgumentNullException("Please specifiy a valid file to play");
            }

            // Get the appropriate Player
            var player = GetPlayer(fileFormat);

            // Check it
            if (player == null)
            {
                Console.WriteLine($"{fileFormat} is not a valid media format");
                return;
            }

            player.Play(fileName);
        }

        private IMediaFormatPlayer GetPlayer(string fileFormat)
        {
            if (_players.ContainsKey(fileFormat))
            {
                return Activator.CreateInstance(_players[fileFormat]) as IMediaFormatPlayer;
            }
            return null;
        }

        private void LoadPlayers()
        {
            _players = new Dictionary<string, Type>();

            Type[] formats = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var format in formats)
            {
                if (format.GetInterface(typeof(IMediaFormatPlayer).ToString()) != null)
                {
                    var formatPlayer = Activator.CreateInstance(format) as IMediaFormatPlayer; // Get an instance so that we can access it's Name
                    _players.Add(formatPlayer.Name.ToLower(), format);
                }
            }
        }
    }
}
