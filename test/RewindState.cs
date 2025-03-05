using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class RewindState: IPlayerState
    {
        private PlayerContext _context;

        public void SetContext(PlayerContext context)
        {
            _context = context;
        }

        public void Play(PlayerContext context)
        {
            Console.WriteLine("Возобновление воспроизведения музыки после перемотки.");
            context.TransitionTo(new PlayingState());
        }

        public void Pause(PlayerContext context)
        {
            Console.WriteLine("Перемотка невозможна во время паузы.");
        }

        public void Stop(PlayerContext context)
        {
            Console.WriteLine("Остановка музыки.");
            context.TransitionTo(new StoppedState());
        }

        public void Rewind(PlayerContext context)
        {
            Console.WriteLine("Музыка уже перематывается.");
        }
    }
}
