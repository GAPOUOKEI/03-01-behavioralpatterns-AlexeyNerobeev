using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class RewindState: IState
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
            Console.WriteLine("постановка трэка на паузу");
        }

        public void Rewind()
        {
            Console.WriteLine("трэк уже перематывается");
        }

        public override string ToString()
        {
            return "перематывается";
        }
    }
}
