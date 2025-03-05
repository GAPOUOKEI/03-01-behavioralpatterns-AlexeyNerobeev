using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class PauseState: IState
    {
        public void Stop()
        {
            Console.WriteLine("остановка трэка");
        }

        public void Play()
        {
            Console.WriteLine("воспроизведение трэка");
        }

        public void Pause()
        {
            Console.WriteLine("трэк уже на паузе");
        }

        public void Rewind()
        {
            Console.WriteLine("перемотка трэка");
        }

        public override string ToString()
        {
            return "на паузе";
        }
    }
}
