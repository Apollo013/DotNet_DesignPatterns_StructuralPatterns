using AdapterPattern.Adapter;
using AdapterPattern.Target;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediaPlayer adapter = new MediaAdapter();
            IMediaPlayer wavPlayer = new AudioPlayer(adapter);

            wavPlayer.Play("whole lotta rosie.wav");
            wavPlayer.Play("back in black.mp3");
            wavPlayer.Play("down payment blues.mp4");
            wavPlayer.Play("asong.lala");
        }
    }
}
