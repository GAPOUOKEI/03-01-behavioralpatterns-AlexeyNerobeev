using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class StopState: IState
    {
        public void Stop()
        {
            Console.WriteLine("трэк уже остановлен");
        }

        public void Play()
        {
            Console.WriteLine("воспроизведение трэка");
        }

        public void Pause()
        {
            Console.WriteLine("постановка трэка на паузу");
        }

        public void Rewind()
        {
            Console.WriteLine("перемотка трэка");
        }

        public override string ToString()
        {
            return "остановлен";
        }
    }
}
