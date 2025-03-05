using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class PlayingState: IPlayerState
    {
        private PlayerContext _context;

        public void SetContext(PlayerContext context)
        {
            _context = context;
        }

        public void Play(PlayerContext context)
        {
            Console.WriteLine("Музыка уже воспроизводится.");
        }

        public void Pause(PlayerContext context)
        {
            Console.WriteLine("Приостановка музыки.");
            context.TransitionTo(new PausedState());
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
