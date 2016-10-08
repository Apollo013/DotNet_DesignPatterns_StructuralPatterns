using AdapterPattern.Adapter;
using AdapterPattern.Target;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                By default, the audio player can only play 'wav' files, but
                by supplying an adapter, it can now also play MP3 & MP4 formats.
            */
            IMediaPlayer adapter = new MediaAdapter();
            IMediaPlayer player = new AudioPlayer(adapter);

            player.Play("whole lotta rosie.wav");
            player.Play("back in black.mp3");
            player.Play("down payment blues.mp4");
            player.Play("asong.lala");
        }
    }
}
