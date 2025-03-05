namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerContext player = new PlayerContext(new StoppedState());

            while (true)
            {
                Console.WriteLine("\nКоманды: play, pause, stop, rewind, exit");
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "play":
                        player.Play();
                        break;
                    case "pause":
                        player.Pause();
                        break;
                    case "stop":
                        player.Stop();
                        break;
                    case "rewind":
                        player.Rewind();
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
