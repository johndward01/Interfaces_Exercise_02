using Interfaces_Exercise_02;
// TODO: Create an interface called IMediaPlayer
// TODO: Inside of the interface make a method called Play()
// TODO: Inside of the interface make a method called Pause()
// TODO: Inside of the interface make a method called Stop()

// TODO: Create 2 classes that implement the interface called VideoPlayer and AudioPlayer

// TODO: Create instances of each implementing classes 

// TODO: Call each of the methods for the objects creatively

var audioPlayer = new AudioPlayer();
Console.WriteLine(nameof(audioPlayer).ToUpper());
audioPlayer.Play();
audioPlayer.Pause();
audioPlayer.Stop();

Console.WriteLine();

var videoPlayer = new VideoPlayer();
Console.WriteLine(nameof(videoPlayer).ToUpper());
videoPlayer.Play();
videoPlayer.Pause();
videoPlayer.Stop();


