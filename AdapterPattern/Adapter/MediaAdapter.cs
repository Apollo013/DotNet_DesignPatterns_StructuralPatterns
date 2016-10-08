using AdapterPattern.Adaptees;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AdapterPattern.Adapter
{
    /// <summary>
    /// Thisi is the 'Adapter' class
    /// </summary>
    public class MediaAdapter : IMediaPlayer
    {
        Dictionary<string, Type> _players = null;

        public MediaAdapter()
        {
            LoadPlayers();
        }

        /// <summary>
        /// Plays a media file
        /// </summary>
        /// <param name="fileName"></param>
        public void Play(string fileName)
        {
            // Get the format
            var fileFormat = fileName.Substring(fileName.LastIndexOf('.') + 1).ToLower();

            // Check it
            if (String.IsNullOrWhiteSpace(fileFormat))
            {
                throw new ArgumentNullException("Please specifiy a valid file to play");
            }

            // Get the appropriate player for this format
            var player = GetPlayer(fileFormat);

            // Check it
            if (player == null)
            {
                Console.WriteLine($"{fileFormat} is not a valid media format");
                return;
            }

            // Play it
            player.Play(fileName);
        }

        /// <summary>
        /// Gets the appropriate player for the specified format
        /// </summary>
        /// <param name="fileFormat"></param>
        /// <returns></returns>
        private IMediaFormatPlayer GetPlayer(string fileFormat)
        {
            if (_players.ContainsKey(fileFormat))
            {
                // Create a new instance of the type
                return Activator.CreateInstance(_players[fileFormat]) as IMediaFormatPlayer;
            }
            // Format not recognised
            return null;
        }

        /// <summary>
        /// Creates a list of all class types that implement the 'IMediaFormatPlayer' interface
        /// </summary>
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
