namespace Interfaces_Exercise_02;

public class AudioPlayer : IMediaPlayer
{
    public void Pause()
    {
        Console.WriteLine("Audio Paused");
    }

    public void Play()
    {
        Console.WriteLine("Audio Playing");
    }

    public void Stop()
    {
        Console.WriteLine("Audio Stopped");
    }
}
