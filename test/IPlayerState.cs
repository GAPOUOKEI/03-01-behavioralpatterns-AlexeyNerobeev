using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal interface IPlayerState
    {
        void Play(PlayerContext context);
        void Pause(PlayerContext context);
        void Stop(PlayerContext context);
        void Rewind(PlayerContext context);
    }
}
