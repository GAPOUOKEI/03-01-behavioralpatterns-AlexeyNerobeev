using System.Numerics;

namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Track track = new Track("Lucid Dreams");
            Console.WriteLine(track);
            track.Stop();
            track.Play();
            track.Pause();
            track.Rewind();
            Console.WriteLine("-----------------");

            while (true)
            {
                Console.WriteLine("\nКоманды: play, pause, stop, rewind, exit");
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "play":
                        track.ChangeState(new PlayState());
                        Console.WriteLine(track);
                        track.Stop();
                        track.Play();
                        track.Pause();
                        track.Rewind();
                        Console.WriteLine("-----------------");
                        break;
                    case "pause":
                        track.ChangeState(new PauseState());
                        Console.WriteLine(track);
                        track.Stop();
                        track.Play();
                        track.Pause();
                        track.Rewind();
                        Console.WriteLine("-----------------");
                        break;
                    case "stop":
                        track.ChangeState(new StopState());
                        Console.WriteLine(track);
                        track.Stop();
                        track.Play();
                        track.Pause();
                        track.Rewind();
                        Console.WriteLine("-----------------");
                        break;
                    case "rewind":
                        track.ChangeState(new RewindState());
                        Console.WriteLine(track);
                        track.Stop();
                        track.Play();
                        track.Pause();
                        track.Rewind();
                        Console.WriteLine("-----------------");
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
        }
    }
}
