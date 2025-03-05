using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class StoppedState: IPlayerState
    {
        private PlayerContext _context;

        public void SetContext(PlayerContext context)
        {
            _context = context;
        }

        public void Play(PlayerContext context)
        {
            Console.WriteLine("Воспроизведение музыки.");
            context.TransitionTo(new PlayingState());
        }

        public void Pause(PlayerContext context)
        {
            Console.WriteLine("Музыка уже остановлена.");
        }

        public void Stop(PlayerContext context)
        {
            Console.WriteLine("Музыка уже остановлена.");
        }

        public void Rewind(PlayerContext context)
        {
            Console.WriteLine("Музыка остановлена. Перемотка невозможна.");
        }
    }
}
