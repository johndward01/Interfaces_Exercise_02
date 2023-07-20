namespace Interfaces_Exercise_02;

public class VideoPlayer : IMediaPlayer
{
    public void Pause()
    {
        Console.WriteLine("Video Paused");
    }

    public void Play()
    {
        Console.WriteLine("Video Playing");
    }

    public void Stop()
    {
        Console.WriteLine("Video Stopped");
    }
}
