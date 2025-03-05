using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class PausedState: IPlayerState
    {
        private PlayerContext _context;

        public void SetContext(PlayerContext context)
        {
            _context = context;
        }

        public void Play(PlayerContext context)
        {
            Console.WriteLine("Возобновление воспроизведения музыки.");
            context.TransitionTo(new PlayingState());
        }

        public void Pause(PlayerContext context)
        {
            Console.WriteLine("Музыка уже приостановлена.");
        }

        public void Stop(PlayerContext context)
        {
            Console.WriteLine("Остановка музыки.");
            context.TransitionTo(new StoppedState());
        }

        public void Rewind(PlayerContext context)
        {
            Console.WriteLine("Перемотка музыки.");
            context.TransitionTo(new RewindState());
        }
    }
}
