using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class PlayState: IState
    {
        public void Stop()
        {
            Console.WriteLine("остановка трэка");
        }

        public void Play()
        {
            Console.WriteLine("трэк уже воспроизведен");
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
            return "воспроизведен";
        }
    }
}
